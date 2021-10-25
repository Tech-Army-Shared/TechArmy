using System;
using System.IO.Ports;
using System.Data.SQLite;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using System.Drawing;

namespace TechArmy
{
    public partial class AdminForm : Form
    {
        private SQLiteConnection sql_con; //sqlite connection string
        private SQLiteCommand sql_cmd; //Sqlite command
        private string userID;
        public AdminForm()
        {
            InitializeComponent();
            MainMenu.DrawItem += new DrawItemEventHandler(MainMenu_DrawItem);
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
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
        }
        //whenever the connect button is clicked, it will check if the port is already open, call the disconnect function.
        // if the port is closed, call the connect function.
     
        private void updatePorts()
        {
            // Retrieve the list of all COM ports on your Computer
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cmbPortName.Items.Add(port);
            }
        }
      
        private void btnRegister_Click(object sender, EventArgs e)
        {
           

            if (rbtnMale.Checked)
            {
                SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                RegisterUsers("M");

                if (sendData() == 1 & txtFingerID.Text != "")
                {
                   // sendID();
                    sql_cmd.ExecuteNonQuery();


                    String sql = "SELECT * FROM registration WHERE fingerID='" + txtFingerID.Text + "'";
                    var cmd2 = new SQLiteCommand(sql, sql_con);
                    SQLiteDataReader rdr2 = cmd2.ExecuteReader();
                    rdr2.Read();
                   // MessageBox.Show("You went out for lunch\n@: " + rdr2.GetString(1));

                    int id = rdr2.GetInt32(0);


                    if (txtUserPassword.Text != "")
                    {
                        sql_cmd.CommandText = "INSERT INTO login (userID,username,password,userType) VALUES(@userID,@username,@password,@userType)";
                        sql_cmd.Parameters.AddWithValue("@userID", id); rdr2.Close();
                        sql_cmd.Parameters.AddWithValue("@username", txtSurname.Text);
                        sql_cmd.Parameters.AddWithValue("@password", txtUserPassword.Text);
                        sql_cmd.Parameters.AddWithValue("@userType", cmbUserType.SelectedItem.ToString());
                        sql_cmd.Prepare();
                        sql_cmd.ExecuteNonQuery();
                    }




                }
                else
                {
                    MessageBox.Show("Communication Error!!\n Registering again...please wait");
                  
                }
                sql_con.Close();
            }
            else if (rbtnFemale.Checked)
            {
                SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                RegisterUsers("F");

                if (sendData() == 1 & txtFingerID.Text != "")
                {
                    //sendID();
                    sql_cmd.ExecuteNonQuery();//


                    String sql = "SELECT * FROM registration WHERE fingerID='" + txtFingerID.Text + "'";
                    var cmd2 = new SQLiteCommand(sql, sql_con);
                    SQLiteDataReader rdr2 = cmd2.ExecuteReader();
                    rdr2.Read();
                    //   MessageBox.Show("You went out for lunch\n@: " + rdr2.GetString(1));

                    int id = rdr2.GetInt32(0);


                    if (txtUserPassword.Text != "")
                    {

                        sql_cmd.CommandText = "INSERT INTO login (userID,username,password,userType) VALUES(@userID,@username,@password,@userType)";
                        sql_cmd.Parameters.AddWithValue("@userID", id); rdr2.Close();
                        sql_cmd.Parameters.AddWithValue("@username", txtSurname.Text);
                        sql_cmd.Parameters.AddWithValue("@password", txtUserPassword.Text);
                        sql_cmd.Parameters.AddWithValue("@userType", cmbUserType.SelectedItem.ToString());
                        sql_cmd.Prepare();

                        sql_cmd.ExecuteNonQuery();
                    }

                    sql_con.Close();
                }
                else {
                    MessageBox.Show("Communication Error!!\n Registering again...please wait");
                   
                }


            }

        }

        private void RegisterUsers(String g) {
            string strDate = $"{DateTime.Now:dd/MM/yy - HH:mm:ss}";

            sql_cmd.CommandText = "INSERT INTO registration (firstName,lastName, cellNumber, emailAddress, physicalAddress,nationalID, gender,fingerID,regDate)" +
                    "VALUES(@firstName,@lastName,@cellNumber,@emailAddress,@physicalAddress,@nationalID,@gender,@fingerID,@regDate)";
            sql_cmd.Parameters.AddWithValue("@firstName", txtFirstname.Text);
            sql_cmd.Parameters.AddWithValue("@lastName", txtSurname.Text);
            sql_cmd.Parameters.AddWithValue("@cellNumber", txtCellNumber.Text);
            sql_cmd.Parameters.AddWithValue("@emailAddress", txtEmailAddress.Text);
            sql_cmd.Parameters.AddWithValue("@physicalAddress", txtPhysicalAddress.Text);
            sql_cmd.Parameters.AddWithValue("@nationalID", txtIDnumber.Text);
            sql_cmd.Parameters.AddWithValue("@gender", g);
            sql_cmd.Parameters.AddWithValue("@fingerID", txtFingerID.Text);
            sql_cmd.Parameters.AddWithValue("@regDate", strDate);
            sql_cmd.Prepare();
        }

        //set connect
        private void SetConnection()
        {
            sql_con = new SQLiteConnection("Data Source=afis.db;Version = 3;New=False;Compress=True;");
        }

        // Function to send data to the serial port
        private void sendID()
        {
         
            bool error = false;
            if (true)        //if text mode is selected, send data as tex
            {
                // Send the user's text straight out the port 
                ComPort.Write(txtFingerID.Text);

                // Show in the terminal window 
                // txtDataArea.ForeColor = Color.Green;    //write sent text data in green colour              
                //txtSend.Clear();                       //clear screen after sending data
               
            }
            else                    //if Hex mode is selected, send data in hexadecimal
            {
                try
                {
                    // Convert the user's string of hex digits (example: E1 FF 1B) to a byte array
                    byte[] data = HexStringToByteArray(txtFingerID.Text);

                    // Send the binary data out the port
                    ComPort.Write(data, 0, data.Length);
                  
                    // Show the hex digits on in the terminal window
                    //  rtxtDataArea.ForeColor = Color.Blue;   //write Hex data in Blue
                    //  rtxtDataArea.AppendText(txtSend.Text.ToUpper() + "\n");
                    //  txtSend.Clear();                       //clear screen after sending data
                }
                catch (FormatException) { error = true; }

                // Inform the user if the hex string was not properly formatted
                catch (ArgumentException) { error = true; }

                if (error) MessageBox.Show(this, "Not properly formatted hex string: " + "r" + "\n" + "example: E1 FF 1B", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Stop); 

            }

          


        }
        private int sendData()
        {
            
           String IDrecieved = userID, currentID = txtFingerID.Text;
           bool error = false;
           
            if (true)        //if text mode is selected, send data as tex
            {
                // Send the user's text straight out the port 
                ComPort.Write("r");

                // Show in the terminal window 
                // txtDataArea.ForeColor = Color.Green;    //write sent text data in green colour              
                //txtSend.Clear();                       //clear screen after sending data
                  sendID(); //Enroll Finger process began
              for(int i = 1; i<=10; i++)
                {
                    IDrecieved = userID;
                    if (IDrecieved == currentID)
                    {
                        return 1; //break;
                    }

                }
                return 0;


               
            }
            else                    //if Hex mode is selected, send data in hexadecimal
            {
                try
                {
                    // Convert the user's string of hex digits (example: E1 FF 1B) to a byte array
                    byte[] data = HexStringToByteArray("r");

                    // Send the binary data out the port
                    ComPort.Write(data, 0, data.Length);
                   
                sendID(); //Enroll Finger process began
                    for (int i = 1; i <= 10; i++)
                    {
                        IDrecieved = userID;
                        if (IDrecieved == currentID)
                        {
                            return 1; //break;
                        }

                    }
                    return 0;

                    // Show the hex digits on in the terminal window
                    //  rtxtDataArea.ForeColor = Color.Blue;   //write Hex data in Blue
                    //  rtxtDataArea.AppendText(txtSend.Text.ToUpper() + "\n");
                    //  txtSend.Clear();                       //clear screen after sending data
                }
            catch (FormatException) { error = true; }

                // Inform the user if the hex string was not properly formatted
                catch (ArgumentException) { error = true; }

                if (error) MessageBox.Show(this, "Not properly formatted hex string: " + "r" + "\n" + "example: E1 FF 1B", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);return 0;
            }


        }
        //Convert a string of hex digits (example: E1 FF 1B) to a byte array. 
        //The string containing the hex digits (with or without spaces)
        //Returns an array of bytes. </returns>
        private byte[] HexStringToByteArray(string s)
        {
            s = s.Replace(" ", "");
            byte[] buffer = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            return buffer;
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
                this.txtDataArea.Text +=text;
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

        private void SerialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var serialPort = (SerialPort)sender;
            var data = serialPort.ReadExisting();
            SetText(data);
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            updatePorts();MessageBox.Show("refreshed","Hi",MessageBoxButtons.OKCancel);
        }

        private void btnConnect_Click_1(object sender, EventArgs e)
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

        //This event will be raised when the form is closing.
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ComPort.IsOpen) ComPort.Close();  //close the port if open when exiting the application.
        }

        private void btnFinger_Click(object sender, EventArgs e)
        {
            if (txtFingerID.Text == null || txtFingerID.Text == "") {
                string message, title, defaultValue;
                string myValue;
                // Set prompt.
                message = "Enter a value between 1 and 127";
                // Set title.
                title = "InputBox";
                // Set default value.
                defaultValue = "1";//Display message, title, and default value.
                myValue = Interaction.InputBox(message, title, defaultValue);// If user has clicked Cancel, set myValue to defaultValue
                if (myValue == "")
                {
                    myValue = defaultValue;

                    MessageBox.Show(myValue);



                }
                else
                {
                    MessageBox.Show(myValue);

                }
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void MainMenu_DrawItem(Object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = MainMenu.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = MainMenu.GetTabRect(e.Index);

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
