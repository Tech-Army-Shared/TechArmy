using System;
using System.IO.Ports;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Threading.Tasks;
using System.Threading;
using System.Data.SQLite;
using System.Drawing;

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
        static String filename = "datasheet.txt";
        int id = 0;
        String clockIN="", lunchOUT="", lunchIN="", clockOUT="", Reason="", Date="";
        public SecurityForm()
        {

            InitializeComponent();
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);

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
            cmbPortName.Enabled = true;
            

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
            cmbPortName.Items.Clear();
            foreach (string port in ports)
            {
                cmbPortName.Items.Add(port);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            updatePorts();
            MessageBox.Show("refreshed", "Alert", MessageBoxButtons.OKCancel);
        }
      
        static void Appendy(string ui, String ci, String lo, String li, String co,string r, String d)

        {
            StreamWriter sw = new StreamWriter(filename, true);

            sw.Write("\n" + ui + "\t" + ci + "\t" + lo + "\t" + li + "\t" + co + "\t"+ r +"\t\t" + d);

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

        private void SecurityForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

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
                try
                {
                    
                    if (!string.IsNullOrEmpty(text))
                    {
                        this.txtDataArea.Text += text.Trim();

                        //this.txtDataArea.AppendText(text);



                        // userID = RichTextBoxLines[txtDataArea.Lines.Length - 2];

                      

                        }
                }
                catch { }
                // set the current caret position to the end
                txtDataArea.SelectionStart = txtDataArea.Text.Length;
                // scroll it automatically
                txtDataArea.ScrollToCaret();
               // txtDataArea.Clear();


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
            var work = new Thread(workerThread);
            work.Name = "Worker thread";
            work.Start();
        }

      void workerThread( ) {

            var DailyTime = "03:18:00";
            var timeParts = DailyTime.Split(new char[1] { ':' });
            while (true)
            {

                var dateNow = DateTime.Now;
                var date = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day,
                        int.Parse(timeParts[0]), int.Parse(timeParts[1]), int.Parse(timeParts[2]));
                TimeSpan ts;
                if (date > dateNow)
                { ts = date - dateNow; }
                else
                {
                    date = date.AddDays(1);
                    ts = date - dateNow;
                }



                //waits certan time and run the code
                //Task.Delay(ts).Wait();
                //MessageBox.Show(ts.Hours.ToString());
                Thread.Sleep(ts);
                SomeMethod();
                //workerThread();

            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDataArea.Clear();
            txtReasonArea.Clear();
            txtEmployee_ID.Text = "";
            LoadData();
        }

        private void txtDataArea_TextChanged(object sender, EventArgs e)
        {
            string[] RichTextBoxLines = txtDataArea.Lines;
            try
            { 
                userID = RichTextBoxLines[RichTextBoxLines.Length - 1];
                txtDataArea.Clear();
              //  MessageBox.Show(userID);
                DateTime now = DateTime.Now;

                string strDate = $"{now:dd/MM/yy}"; 
                string strDateTime = $"{now:hh:mm:ss}";

                string stm = "SELECT * FROM registration WHERE fingerID ='" + userID + "'";
                SetConnection();
                sql_con.Open();
                var cmd = new SQLiteCommand(stm, sql_con);
                SQLiteDataReader rdr = cmd.ExecuteReader();


                try
                {
                    rdr.Read();
                    id = rdr.GetInt32(0);
                    txtEmployee_ID.Text = id.ToString();
                    rdr.Close();


                    SetConnection();
                    sql_con.Open();
                    sql_cmd = sql_con.CreateCommand();

                    sql_cmd.CommandText = "INSERT INTO userlogs ('userID', 'ClockIN','date') VALUES(@ID,@clock,@date)";
                    sql_cmd.Parameters.AddWithValue("@ID", id);
                    sql_cmd.Parameters.AddWithValue("@clock", strDateTime);
                    sql_cmd.Parameters.AddWithValue("@date", strDate);
                    sql_cmd.Prepare();
                    sql_cmd.ExecuteNonQuery();//bug
                }
                catch
                {
                    // MessageBox.Show("Good Morning.");
                    String sql = "SELECT * FROM userLogs WHERE userID = '" + id + "'";
                    var cmd2 = new SQLiteCommand(sql, sql_con);
                    SQLiteDataReader rdr2 = cmd2.ExecuteReader();
                    rdr2.Read();
                    try
                    {

                        // MessageBox.Show("You went out for lunch\n@: " + rdr2.GetString(3));// bug2 
                        rdr2.GetString(3);
                        try
                        {
                            // MessageBox.Show("You came back from lunch\n@: " + rdr2.GetString(4));//bug3
                            rdr2.GetString(4);
                            lunchIN = rdr2.GetString(4);
                            try
                            {
                                //MessageBox.Show("You left\n@: " + rdr2.GetString(5));//bug4
                                rdr2.GetString(5);

                                try { 
                                    rdr2.GetString(6);
                                    /*Appendy(id, rdr2.GetString(2), rdr2.GetString(3), rdr2.GetString(4), rdr2.GetString(5), rdr2.GetString(6), rdr2.GetString(7));

                                    sql_cmd.CommandText = "INSERT INTO datasheet ('userID','time1','time2','time3','time4','reason','date') VALUES(@userID,@time1,@time2,@time3,@time4,@reason,@date)";
                                    sql_cmd.Parameters.AddWithValue("@userID", id);
                                    sql_cmd.Parameters.AddWithValue("@time1", rdr2.GetString(2));
                                    sql_cmd.Parameters.AddWithValue("@time2", rdr2.GetString(3));
                                    sql_cmd.Parameters.AddWithValue("@time3", rdr2.GetString(4));
                                    sql_cmd.Parameters.AddWithValue("@time4", rdr2.GetString(5));
                                    sql_cmd.Parameters.AddWithValue("@reason", rdr2.GetString(6));
                                    sql_cmd.Parameters.AddWithValue("@date", rdr2.GetString(7));
                                    sql_cmd.Prepare();
                                    sql_cmd.ExecuteNonQuery();

                                    sql_cmd.CommandText = "DELETE FROM userLogs WHERE userID=@uID";
                                    sql_cmd.Parameters.AddWithValue("@uID", id);
                                    sql_cmd.Prepare();
                                    sql_cmd.ExecuteNonQuery();*/

                                } catch {

                                    /*Appendy(id, rdr2.GetString(2), rdr2.GetString(3), rdr2.GetString(4), rdr2.GetString(5), "n/a", rdr2.GetString(7));

                                    sql_cmd.CommandText = "INSERT INTO datasheet ('userID','time1','time2','time3','time4','reason','date') VALUES(@userID,@time1,@time2,@time3,@time4,@reason,@date)";
                                    sql_cmd.Parameters.AddWithValue("@userID", id);
                                    sql_cmd.Parameters.AddWithValue("@time1", rdr2.GetString(2));
                                    sql_cmd.Parameters.AddWithValue("@time2", rdr2.GetString(3));
                                    sql_cmd.Parameters.AddWithValue("@time3", rdr2.GetString(4));
                                    sql_cmd.Parameters.AddWithValue("@time4", rdr2.GetString(5));
                                    sql_cmd.Parameters.AddWithValue("@reason", "n/a");
                                    sql_cmd.Parameters.AddWithValue("@date", rdr2.GetString(7));
                                    sql_cmd.Prepare();
                                    sql_cmd.ExecuteNonQuery();

                                    sql_cmd.CommandText = "DELETE FROM userLogs WHERE userID=@uID";
                                    sql_cmd.Parameters.AddWithValue("@uID", id);
                                    sql_cmd.Prepare();
                                    sql_cmd.ExecuteNonQuery();*/
                                }
                                //Appendy(rdr2.GetInt32(1), rdr2.GetString(2), rdr2.GetString(3), rdr2.GetString(4), rdr2.GetString(5), rdr2.GetString(7));


                                /*  Appendy(id, rdr2.GetString(2), rdr2.GetString(3), rdr2.GetString(4), rdr2.GetString(5), "n/a", rdr2.GetString(7));
                                  sql_cmd.CommandText = "DELETE FROM userLogs WHERE userID=@uID";
                                  sql_cmd.Parameters.AddWithValue("@uID", id);
                                  sql_cmd.Prepare();
                                  sql_cmd.ExecuteNonQuery();*/





                                //  sql_cmd.CommandText = "INSERT INTO datasheet('userID','time1','time2','time3','time4','reason','date') VALUES(@)";
                                //     "" +
                                //     "'" + id+"','"+ rdr2.GetString(2) + "','"+ rdr2.GetString(3) + "','"+ rdr2.GetString(4) + "','"+ rdr2.GetString(5) + "','hh','"+ rdr2.GetString(7) + "')";
                                //   sql_cmd.Prepare();
                                //   sql_cmd.ExecuteNonQuery();

                                // sql_cmd.CommandText = "DELETE FROM userLogs WHERE userID = '" + id + "'";
                                // sql_cmd.Prepare();
                                // sql_cmd.ExecuteNonQuery();
                            }
                            catch
                            {
                                //MessageBox.Show("Good Afternoon.");

                                sql_cmd.CommandText = "UPDATE userLogs SET clockOUT = @ClockOUT WHERE userID = '" + id + "'";
                                sql_cmd.Parameters.AddWithValue("@ClockOUT", strDateTime);
                                sql_cmd.Prepare();
                                sql_cmd.ExecuteNonQuery();
                               



                            }
                        }
                        catch
                        {
                            //  MessageBox.Show("Coming Back from lunch.");
                            sql_cmd.CommandText = "UPDATE userLogs SET lunchIN = @LunchIN WHERE userID = '" + id + "'";
                            sql_cmd.Parameters.AddWithValue("@LunchIN", strDateTime);
                            sql_cmd.Prepare();
                            sql_cmd.ExecuteNonQuery();
                        }
                    }
                    catch
                    {
                        // MessageBox.Show("Going to lunch.");
                        if (sql_cmd != null)
                        {
                            sql_cmd.CommandText = "UPDATE userLogs SET lunchOUT = @LunchOUT WHERE userID = '" + id + "'";
                            sql_cmd.Parameters.AddWithValue("@LunchOUT", strDateTime);
                            sql_cmd.Prepare();
                            sql_cmd.ExecuteNonQuery();
                        }
                    }
                    rdr2.Close();
                }

                sql_con.Close();
                LoadData();
            }
            catch { }
        
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String reason = txtReasonArea.Text;
            if (reason != "")
            {
                try
                {
                    SetConnection();
                    sql_con.Open();

                    sql_cmd = sql_con.CreateCommand();
                    sql_cmd.CommandText = "UPDATE userLogs SET reason = @reason WHERE userID = '" + id + "'";
                    sql_cmd.Parameters.AddWithValue("@reason", reason);
                    sql_cmd.Prepare();
                    sql_cmd.ExecuteNonQuery();
                    LoadData();

                    sql_con.Close();

                    txtDataArea.Clear();
                    txtReasonArea.Clear();
                    txtEmployee_ID.Text = "";

                }
                catch
                {
                    MessageBox.Show("Something went wrong...");

                    txtDataArea.Clear();
                    txtReasonArea.Clear();
                    txtEmployee_ID.Text = "";

                }
            }
        }

         void SomeMethod()
        {
           
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();

            var cmd = new SQLiteCommand("SELECT * FROM userlogs", sql_con);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
           
            while (rdr.Read())
            {
                String user_ID = rdr.GetString(1);
                clockIN = rdr.GetString(2);

                try { if (!String.IsNullOrEmpty(rdr.GetString(3))) { lunchOUT = rdr.GetString(3); } } catch { lunchOUT = "n/a"; }
                try { if (!String.IsNullOrEmpty(rdr.GetString(4))) { lunchIN = rdr.GetString(4); } } catch { lunchIN = "n/a"; }
                try { if (!String.IsNullOrEmpty(rdr.GetString(5))) { clockOUT = rdr.GetString(5); } } catch {clockOUT = "n/a"; }
                try { if (!String.IsNullOrEmpty(rdr.GetString(6))) { Reason = rdr.GetString(6); } } catch { Reason = "n/a"; }

                Date = rdr.GetString(7);

                Appendy(user_ID,clockIN,lunchOUT,lunchIN,clockOUT,Reason,Date);

                sql_cmd.CommandText = "INSERT INTO datasheet ('userID','time1','time2','time3','time4','reason','date') VALUES(@userID,@time1,@time2,@time3,@time4,@reason,@date)";
                sql_cmd.Parameters.AddWithValue("@userID", user_ID);
                sql_cmd.Parameters.AddWithValue("@time1", clockIN);
                sql_cmd.Parameters.AddWithValue("@time2", lunchOUT);
                sql_cmd.Parameters.AddWithValue("@time3", lunchIN);
                sql_cmd.Parameters.AddWithValue("@time4",clockOUT);
                sql_cmd.Parameters.AddWithValue("@reason", Reason);
                sql_cmd.Parameters.AddWithValue("@date", Date);
                sql_cmd.Prepare();
                sql_cmd.ExecuteNonQuery();

                sql_cmd.CommandText = "DELETE FROM userLogs WHERE userID=@uID";
                sql_cmd.Parameters.AddWithValue("@uID", user_ID);
                sql_cmd.Prepare();
                sql_cmd.ExecuteNonQuery();
            }
                
           rdr.Close();sql_con.Close();LoadData();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void SecurityForm_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_DrawItem(Object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.White);
                g.FillRectangle(Brushes.SteelBlue, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", 10.0f, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }


    }
}
