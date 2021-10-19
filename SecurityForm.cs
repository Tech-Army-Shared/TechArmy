using System;
using System.IO.Ports;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Data.SQLite;

namespace TechArmy
{
    public partial class SecurityForm : Form
    {
        private SQLiteConnection sql_con; //sqlite connection string
        private SQLiteCommand sql_cmd; //Sqlite command
        private string userID;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        public SecurityForm()
        {
            InitializeComponent();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void SerialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var serialPort = (SerialPort)sender;
            var data = serialPort.ReadExisting();
            SetText(data);

        }


        private SerialPort ComPort = new SerialPort();  //Initialise ComPort Variable as SerialPort
        private void connect()
        {
            bool error = false;

            // Check if all settings have been selected

            if (cmbPortName.SelectedIndex != -1)
            {
                //if yes than Set The Port's settings
                ComPort.PortName = cmbPortName.Text;
                ComPort.BaudRate = 9600;      //convert Text to Integer
                ComPort.Parity = (Parity)Enum.Parse(typeof(Parity), "None"); //convert Text to Parity
                ComPort.DataBits = 8;        //convert Text to Integer
                ComPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "2");  //convert Text to stop bits

                try  //always try to use this try and catch method to open your port. 
                     //if there is an error your program will not display a message instead of freezing.
                {
                    //Open Port
                    ComPort.Open();
                    ComPort.DataReceived += SerialPortDataReceived;  //Check for received data. When there is data in the receive buffer,
                                                                     //it will raise this event, we need to subscribe to it to know when there is data
                }
                catch (UnauthorizedAccessException) { error = true; }
                catch (System.IO.IOException) { error = true; }
                catch (ArgumentException) { error = true; }

                if (error) MessageBox.Show(this, "Could not open the COM port. Most likely it is already in use, has been removed, or is unavailable.", "COM Port unavailable", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
            {
                MessageBox.Show("Please select all the COM Serial Port Settings", "Serial Port Interface", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            //if the port is open, Change the Connect button to disconnect, enable the send button.
            //and disable the groupBox to prevent changing configuration of an open port.
            if (ComPort.IsOpen)
            {
                btnConnect.Text = "Disconnect";
                cmbPortName.Enabled = false;
            }
        }
        // Call this function to close the port.
        private void disconnect()
        {
            ComPort.Close();
            btnConnect.Text = "Connect";
            //btnSend.Enabled = false;
            //groupBox1.Enabled = true;

        }
        //whenever the connect button is clicked, it will check if the port is already open, call the disconnect function.
        // if the port is closed, call the connect function.
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (ComPort.IsOpen)
            {
                disconnect();
            }
            else
            {
                connect();
            }
        }

        private void updatePorts()
        {
            // Retrieve the list of all COM ports on your Computer
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cmbPortName.Items.Add(port);
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            updatePorts(); ; MessageBox.Show("refreshed", "Hi", MessageBoxButtons.OKCancel);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            string strDate = $"{now:dd/MM/yy}"; string strDateTime = $"{now:hh:mm:ss}";

            string stm = "SELECT * FROM registration WHERE fingerID ='" + userID + "'";
            SetConnection();
            sql_con.Open();
            var cmd = new SQLiteCommand(stm, sql_con);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            int id = 0;

            try
            {
                rdr.Read();
                id = rdr.GetInt32(0);
                textBox7.Text = id.ToString();
                rdr.Close();


                SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();

                sql_cmd.CommandText = "INSERT INTO userlogs ('userID', 'ClockIN','date')" + " VALUES(@ID,@clock,@date)";
                sql_cmd.Parameters.AddWithValue("@ID", id);
                sql_cmd.Parameters.AddWithValue("@clock", strDateTime);
                sql_cmd.Parameters.AddWithValue("@date", strDate);
                sql_cmd.Prepare();
                sql_cmd.ExecuteNonQuery();//bug
            }
            catch
            {
                MessageBox.Show("Good Morning.");
                String sql = "SELECT * FROM userLogs WHERE userID = '" + id + "'";
                var cmd2 = new SQLiteCommand(sql, sql_con);
                SQLiteDataReader rdr2 = cmd2.ExecuteReader();
                rdr2.Read();

                try
                {

                    MessageBox.Show("You went out for lunch\n@: " + rdr2.GetString(3));// bug2 

                    try
                    {
                        MessageBox.Show("You came back from lunch\n@: " + rdr2.GetString(4));//bug3

                        try
                        {
                            MessageBox.Show("You left\n@: " + rdr2.GetString(5));//bug4

                            Appendy(rdr2.GetString(1), rdr2.GetString(2), rdr2.GetString(3), rdr2.GetString(4), rdr2.GetString(5), rdr2.GetString(6));

                        }
                        catch
                        {
                            MessageBox.Show("Good Afternoon.");
                            sql_cmd.CommandText = "UPDATE userLogs SET clockOUT = @ClockOUT WHERE userID = '" + id + "'";
                            sql_cmd.Parameters.AddWithValue("@ClockOUT", strDateTime);
                            sql_cmd.Prepare();
                            sql_cmd.ExecuteNonQuery();

                        }
                    }
                    catch
                    {
                        MessageBox.Show("Coming Back from lunch.");
                        sql_cmd.CommandText = "UPDATE userLogs SET lunchIN = @LunchIN WHERE userID = '" + id + "'";
                        sql_cmd.Parameters.AddWithValue("@LunchIN", strDateTime);
                        sql_cmd.Prepare();
                        sql_cmd.ExecuteNonQuery();
                    }
                }
                catch
                {
                    MessageBox.Show("Going to lunch.");
                    sql_cmd.CommandText = "UPDATE userLogs SET lunchOUT = @LunchOUT WHERE userID = '" + id + "'";
                    sql_cmd.Parameters.AddWithValue("@LunchOUT", strDateTime);
                    sql_cmd.Prepare();
                    sql_cmd.ExecuteNonQuery();
                }
                rdr2.Close();
            }

            sql_con.Close();
            LoadData();
        }
        String filename = "datasheet.txt";
        void Appendy(String ui, String ci, String lo, String li, String co, String d)
        {
            StreamWriter sw = new StreamWriter(filename, true);

            sw.Write("\n" + ui + "\t" + ci + "\t" + lo + "\t" + li + "\t" + co + "\t" + d);

            MessageBox.Show("Appended text");
            sw.Close();
            //Read();
        }

        //set connect
        private void SetConnection()
        {
            sql_con = new SQLiteConnection("Data Source=afis.db;Version = 3;New=False;Compress=True;");
        }

        //Data recived from the serial port is coming from another thread context than the UI thread.
        //Instead of reading the content directly in the SerialPortDataReceived, we need to use a delegate.
        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            //invokeRequired required compares the thread ID of the calling thread to the thread of the creating thread.
            //// if these threads are different, it returns true
            if (this.txtDataArea.InvokeRequired)
            {
                //rtxtDataArea.ForeColor = Color.Green;    //write text data in Green colour

                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtDataArea.Text += text;
                // this.txtDataArea.AppendText(text);
                string[] RichTextBoxLines = txtDataArea.Lines;

                try
                {
                    userID = RichTextBoxLines[txtDataArea.Lines.Length - 2];
                    // MessageBox.Show(userID);
                }
                catch { }

                // set the current caret position to the end
                txtDataArea.SelectionStart = txtDataArea.Text.Length;
                // scroll it automatically
                txtDataArea.ScrollToCaret();

            }

        }

        private void LoadData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandTxt = "SELECT * FROM userlogs";
            DB = new SQLiteDataAdapter(CommandTxt, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView2.DataSource = DT;
            sql_con.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDataArea.Clear();
        }
    }
}
