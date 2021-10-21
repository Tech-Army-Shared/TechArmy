
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
            this.MainMenu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmbPortName = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnFinger = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtDataArea = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUserType = new System.Windows.Forms.ComboBox();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.txtCellNumber = new System.Windows.Forms.TextBox();
            this.lblCellNumber = new System.Windows.Forms.Label();
            this.txtFingerID = new System.Windows.Forms.TextBox();
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
            this.MainMenu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GenderGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.MainMenu.Controls.Add(this.tabPage1);
            this.MainMenu.Controls.Add(this.tabPage2);
            this.MainMenu.Controls.Add(this.tabPage3);
            this.MainMenu.Location = new System.Drawing.Point(10, 29);
            this.MainMenu.Multiline = true;
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MainMenu.SelectedIndex = 0;
            this.MainMenu.Size = new System.Drawing.Size(710, 419);
            this.MainMenu.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnConnect);
            this.tabPage1.Controls.Add(this.btnRefresh);
            this.tabPage1.Controls.Add(this.cmbPortName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(702, 393);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(702, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Clocks";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.AllowDrop = true;
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.btnFinger);
            this.tabPage3.Controls.Add(this.btnRegister);
            this.tabPage3.Controls.Add(this.txtDataArea);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.txtCellNumber);
            this.tabPage3.Controls.Add(this.lblCellNumber);
            this.tabPage3.Controls.Add(this.txtFingerID);
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
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(702, 393);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Register";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnFinger
            // 
            this.btnFinger.Location = new System.Drawing.Point(335, 157);
            this.btnFinger.Name = "btnFinger";
            this.btnFinger.Size = new System.Drawing.Size(75, 23);
            this.btnFinger.TabIndex = 42;
            this.btnFinger.Text = "Enroll User";
            this.btnFinger.UseVisualStyleBackColor = true;
            this.btnFinger.Click += new System.EventHandler(this.btnFinger_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(414, 157);
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
            // txtFingerID
            // 
            this.txtFingerID.Location = new System.Drawing.Point(110, 270);
            this.txtFingerID.Name = "txtFingerID";
            this.txtFingerID.Size = new System.Drawing.Size(184, 20);
            this.txtFingerID.TabIndex = 34;
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
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(736, 463);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.MainMenu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GenderGroupBox.ResumeLayout(false);
            this.GenderGroupBox.PerformLayout();
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
        private System.Windows.Forms.TextBox txtFingerID;
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
        private System.Windows.Forms.Button btnFinger;
    }
}