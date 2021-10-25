
namespace TechArmy
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Menu = new System.Windows.Forms.TabControl();

            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmbPortName = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();

            this.cmbFingerID = new System.Windows.Forms.ComboBox();

            this.btnRegister = new System.Windows.Forms.Button();
            this.txtDataArea = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUserType = new System.Windows.Forms.ComboBox();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.txtCellNumber = new System.Windows.Forms.TextBox();
            this.lblCellNumber = new System.Windows.Forms.Label();
            this.lblFingerID = new System.Windows.Forms.Label();
            this.GenderGroupBox = new System.Windows.Forms.GroupBox();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.txtIDnumber = new System.Windows.Forms.TextBox();
            this.lblNationalID = new System.Windows.Forms.Label();
            this.txtPhysicalAddress = new System.Windows.Forms.TextBox();
            this.lblPhysicalAddress = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.Label();

            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmployee_ID = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtReasonArea = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();

            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GenderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.MainMenu.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.MainMenu.Controls.Add(this.tabPage1);
            this.MainMenu.Controls.Add(this.tabPage2);
            this.MainMenu.Controls.Add(this.tabPage3);
            this.MainMenu.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.MainMenu.ItemSize = new System.Drawing.Size(25, 100);
            this.MainMenu.Location = new System.Drawing.Point(10, 29);
            this.MainMenu.Multiline = true;
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MainMenu.SelectedIndex = 0;
            this.MainMenu.Size = new System.Drawing.Size(710, 419);
            this.MainMenu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MainMenu.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::TechArmy.Properties.Resources.Background_Image;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnConnect);
            this.tabPage1.Controls.Add(this.btnRefresh);
            this.tabPage1.Controls.Add(this.cmbPortName);
            this.tabPage1.Location = new System.Drawing.Point(104, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(602, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Connect";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 55);
            this.label1.TabIndex = 11;
            this.label1.Text = "Virtual COM Port:";
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(389, 211);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(183, 77);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click_1);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(175, 211);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(174, 77);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // cmbPortName
            // 
            this.cmbPortName.FormattingEnabled = true;
            this.cmbPortName.Location = new System.Drawing.Point(218, 144);
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(312, 21);
            this.cmbPortName.TabIndex = 8;
            this.cmbPortName.Text = "Refresh and select port:";
            // 
            // tabPage2
            // 

            this.tabPage2.Controls.Add(this.btnSearch);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtEmployee_ID);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);

            this.tabPage2.BackgroundImage = global::TechArmy.Properties.Resources.Background_Image;

            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(602, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Clocks";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(21, 176);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(653, 210);
            this.dataGridView2.TabIndex = 45;
            // 
            // tabPage3
            // 
            this.tabPage3.AllowDrop = true;
            this.tabPage3.AutoScroll = true;

            this.tabPage3.Controls.Add(this.cmbFingerID);

            this.tabPage3.BackgroundImage = global::TechArmy.Properties.Resources.Background_Image;

            this.tabPage3.Controls.Add(this.btnRegister);
            this.tabPage3.Controls.Add(this.txtDataArea);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.txtCellNumber);
            this.tabPage3.Controls.Add(this.lblCellNumber);
            this.tabPage3.Controls.Add(this.lblFingerID);
            this.tabPage3.Controls.Add(this.GenderGroupBox);
            this.tabPage3.Controls.Add(this.txtIDnumber);
            this.tabPage3.Controls.Add(this.lblNationalID);
            this.tabPage3.Controls.Add(this.txtPhysicalAddress);
            this.tabPage3.Controls.Add(this.lblPhysicalAddress);
            this.tabPage3.Controls.Add(this.txtEmailAddress);
            this.tabPage3.Controls.Add(this.lblEmail);
            this.tabPage3.Controls.Add(this.txtSurname);
            this.tabPage3.Controls.Add(this.lblSurname);
            this.tabPage3.Controls.Add(this.txtFirstname);
            this.tabPage3.Controls.Add(this.lblFirstname);
            this.tabPage3.Location = new System.Drawing.Point(104, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(602, 411);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Register";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 

            // cmbFingerID
            // 
            this.cmbFingerID.FormattingEnabled = true;
            this.cmbFingerID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50"});
            this.cmbFingerID.Location = new System.Drawing.Point(110, 274);
            this.cmbFingerID.Name = "cmbFingerID";
            this.cmbFingerID.Size = new System.Drawing.Size(184, 21);
            this.cmbFingerID.TabIndex = 43;
            this.cmbFingerID.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            this.cmbFingerID.Validating += new System.ComponentModel.CancelEventHandler(this.cmbFingerID_Validating);

            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(342, 157);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 41;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtDataArea
            // 
            this.txtDataArea.AutoWordSelection = true;
            this.txtDataArea.BackColor = System.Drawing.SystemColors.Window;
            this.txtDataArea.ForeColor = System.Drawing.Color.Lime;
            this.txtDataArea.Location = new System.Drawing.Point(342, 210);
            this.txtDataArea.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataArea.Name = "txtDataArea";
            this.txtDataArea.ReadOnly = true;
            this.txtDataArea.Size = new System.Drawing.Size(343, 154);
            this.txtDataArea.TabIndex = 40;
            this.txtDataArea.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbUserType);
            this.groupBox1.Controls.Add(this.txtUserPassword);
            this.groupBox1.Location = new System.Drawing.Point(342, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UserType";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Select User";
            // 
            // cmbUserType
            // 
            this.cmbUserType.FormattingEnabled = true;
            this.cmbUserType.Items.AddRange(new object[] {
            "admin",
            "security"});
            this.cmbUserType.Location = new System.Drawing.Point(72, 20);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Size = new System.Drawing.Size(121, 21);
            this.cmbUserType.TabIndex = 38;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(73, 57);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PasswordChar = 'X';
            this.txtUserPassword.Size = new System.Drawing.Size(121, 20);
            this.txtUserPassword.TabIndex = 37;
            // 
            // txtCellNumber
            // 
            this.txtCellNumber.Location = new System.Drawing.Point(110, 87);
            this.txtCellNumber.Name = "txtCellNumber";
            this.txtCellNumber.Size = new System.Drawing.Size(184, 20);
            this.txtCellNumber.TabIndex = 36;
            this.txtCellNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtCellNumber_Validating);
            // 
            // lblCellNumber
            // 
            this.lblCellNumber.AutoSize = true;
            this.lblCellNumber.Location = new System.Drawing.Point(16, 94);
            this.lblCellNumber.Name = "lblCellNumber";
            this.lblCellNumber.Size = new System.Drawing.Size(64, 13);
            this.lblCellNumber.TabIndex = 35;
            this.lblCellNumber.Text = "Cell Number";
            // 
            // lblFingerID
            // 
            this.lblFingerID.AutoSize = true;
            this.lblFingerID.Location = new System.Drawing.Point(16, 277);
            this.lblFingerID.Name = "lblFingerID";
            this.lblFingerID.Size = new System.Drawing.Size(50, 13);
            this.lblFingerID.TabIndex = 33;
            this.lblFingerID.Text = "Finger ID";
            // 
            // GenderGroupBox
            // 
            this.GenderGroupBox.Controls.Add(this.rbtnFemale);
            this.GenderGroupBox.Controls.Add(this.rbtnMale);
            this.GenderGroupBox.Location = new System.Drawing.Point(19, 312);
            this.GenderGroupBox.Name = "GenderGroupBox";
            this.GenderGroupBox.Size = new System.Drawing.Size(275, 52);
            this.GenderGroupBox.TabIndex = 32;
            this.GenderGroupBox.TabStop = false;
            this.GenderGroupBox.Text = "Gender";
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(200, 21);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(59, 17);
            this.rbtnFemale.TabIndex = 1;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(91, 21);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(48, 17);
            this.rbtnMale.TabIndex = 0;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // txtIDnumber
            // 
            this.txtIDnumber.Location = new System.Drawing.Point(110, 235);
            this.txtIDnumber.Name = "txtIDnumber";
            this.txtIDnumber.Size = new System.Drawing.Size(184, 20);
            this.txtIDnumber.TabIndex = 9;
            this.txtIDnumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtIDnumber_Validating);
            // 
            // lblNationalID
            // 
            this.lblNationalID.AutoSize = true;
            this.lblNationalID.Location = new System.Drawing.Point(16, 242);
            this.lblNationalID.Name = "lblNationalID";
            this.lblNationalID.Size = new System.Drawing.Size(58, 13);
            this.lblNationalID.TabIndex = 8;
            this.lblNationalID.Text = "ID Number";
            // 
            // txtPhysicalAddress
            // 
            this.txtPhysicalAddress.Location = new System.Drawing.Point(110, 157);
            this.txtPhysicalAddress.Multiline = true;
            this.txtPhysicalAddress.Name = "txtPhysicalAddress";
            this.txtPhysicalAddress.Size = new System.Drawing.Size(184, 63);
            this.txtPhysicalAddress.TabIndex = 7;
            this.txtPhysicalAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhysicalAddress_Validating);
            // 
            // lblPhysicalAddress
            // 
            this.lblPhysicalAddress.AutoSize = true;
            this.lblPhysicalAddress.Location = new System.Drawing.Point(16, 157);
            this.lblPhysicalAddress.Name = "lblPhysicalAddress";
            this.lblPhysicalAddress.Size = new System.Drawing.Size(87, 13);
            this.lblPhysicalAddress.TabIndex = 6;
            this.lblPhysicalAddress.Text = "Physical Address";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(110, 122);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(184, 20);
            this.txtEmailAddress.TabIndex = 5;
            this.txtEmailAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmailAddress_Validating);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(16, 129);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(76, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-mail Address";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(110, 52);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(184, 20);
            this.txtSurname.TabIndex = 3;
            this.txtSurname.Validating += new System.ComponentModel.CancelEventHandler(this.txtSurname_Validating);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(16, 59);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(110, 17);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(184, 20);
            this.txtFirstname.TabIndex = 1;
            this.txtFirstname.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstname_Validating);
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(16, 24);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(52, 13);
            this.lblFirstname.TabIndex = 0;
            this.lblFirstname.Text = "Firstname";
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLogout.Location = new System.Drawing.Point(682, 9);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(40, 13);
            this.lblLogout.TabIndex = 2;
            this.lblLogout.Text = "Logout";
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            // 

            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(130, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 46);
            this.label4.TabIndex = 51;
            this.label4.Text = "Employee_ID#";
            // 
            // txtEmployee_ID
            // 
            this.txtEmployee_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployee_ID.Location = new System.Drawing.Point(430, 24);
            this.txtEmployee_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployee_ID.Multiline = true;
            this.txtEmployee_ID.Name = "txtEmployee_ID";
            this.txtEmployee_ID.Size = new System.Drawing.Size(50, 46);
            this.txtEmployee_ID.TabIndex = 49;
            // 
            // richTextBox1
            // 
            this.richTextBox1.AutoWordSelection = true;
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.ForeColor = System.Drawing.Color.Lime;
            this.richTextBox1.Location = new System.Drawing.Point(7, 20);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(116, 106);
            this.richTextBox1.TabIndex = 48;
            this.richTextBox1.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSubmit);
            this.groupBox2.Controls.Add(this.txtReasonArea);
            this.groupBox2.Location = new System.Drawing.Point(510, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 123);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reason";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(72, 94);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 43;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtReasonArea
            // 
            this.txtReasonArea.Location = new System.Drawing.Point(3, 19);
            this.txtReasonArea.Multiline = true;
            this.txtReasonArea.Name = "txtReasonArea";
            this.txtReasonArea.Size = new System.Drawing.Size(186, 72);
            this.txtReasonArea.TabIndex = 44;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(265, 113);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 52;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
          
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::TechArmy.Properties.Resources.Background_Image;
            this.ClientSize = new System.Drawing.Size(736, 463);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GenderGroupBox.ResumeLayout(false);
            this.GenderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl MainMenu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cmbPortName;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.TextBox txtCellNumber;
        private System.Windows.Forms.Label lblCellNumber;
        private System.Windows.Forms.Label lblFingerID;
        private System.Windows.Forms.GroupBox GenderGroupBox;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.TextBox txtIDnumber;
        private System.Windows.Forms.Label lblNationalID;
        private System.Windows.Forms.TextBox txtPhysicalAddress;
        private System.Windows.Forms.Label lblPhysicalAddress;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtDataArea;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox cmbFingerID;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmployee_ID;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtReasonArea;
        private System.Windows.Forms.Button btnSearch;
    }
}