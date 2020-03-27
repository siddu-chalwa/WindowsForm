namespace SixthClient
{
    partial class ControllerWindowForm
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
            this.groupBox_up = new System.Windows.Forms.GroupBox();
            this.groupBox_DB = new System.Windows.Forms.GroupBox();
            this.label_DPPassword = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.button_imageBrowser = new System.Windows.Forms.Button();
            this.label_dateTimePicker = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label_title = new System.Windows.Forms.Label();
            this.openFileDialog_image = new System.Windows.Forms.OpenFileDialog();
            this.groupBox_loginSignup = new System.Windows.Forms.GroupBox();
            this.groupBox_signup = new System.Windows.Forms.GroupBox();
            this.textBox_ConfirmPassS = new System.Windows.Forms.TextBox();
            this.label_confirmPassS = new System.Windows.Forms.Label();
            this.label_newUserJoin = new System.Windows.Forms.Label();
            this.label_signup = new System.Windows.Forms.Label();
            this.button_signup = new System.Windows.Forms.Button();
            this.textBox_emailidS = new System.Windows.Forms.TextBox();
            this.textBox_passwordS = new System.Windows.Forms.TextBox();
            this.label_emailodS = new System.Windows.Forms.Label();
            this.label_passwordS = new System.Windows.Forms.Label();
            this.groupBox_loginIn = new System.Windows.Forms.GroupBox();
            this.label_invalidUserDisplay = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_emaliid = new System.Windows.Forms.TextBox();
            this.label_emailid = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.groupBox_imageGridView = new System.Windows.Forms.GroupBox();
            this.groupBox_gridForm = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALARYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOBILENUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.signUPTABELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.acerNitroDBDataSet = new SixthClient.acerNitroDBDataSet();
            this.pictureBox_image = new System.Windows.Forms.PictureBox();
            this.signUPTABELTableAdapter = new SixthClient.acerNitroDBDataSetTableAdapters.SignUPTABELTableAdapter();
            this.errorProvider_emailid = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_password = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_emailidS = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_passwordS = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_confirmPassS = new System.Windows.Forms.ErrorProvider(this.components);
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.groupBox_up.SuspendLayout();
            this.groupBox_DB.SuspendLayout();
            this.groupBox_loginSignup.SuspendLayout();
            this.groupBox_signup.SuspendLayout();
            this.groupBox_loginIn.SuspendLayout();
            this.groupBox_imageGridView.SuspendLayout();
            this.groupBox_gridForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signUPTABELBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acerNitroDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_emailid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_emailidS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_passwordS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_confirmPassS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_up
            // 
            this.groupBox_up.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_up.Controls.Add(this.groupBox_DB);
            this.groupBox_up.Controls.Add(this.button_imageBrowser);
            this.groupBox_up.Controls.Add(this.label_dateTimePicker);
            this.groupBox_up.Controls.Add(this.dateTimePicker);
            this.groupBox_up.Controls.Add(this.label_title);
            this.groupBox_up.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_up.Location = new System.Drawing.Point(0, 0);
            this.groupBox_up.Name = "groupBox_up";
            this.groupBox_up.Size = new System.Drawing.Size(1023, 100);
            this.groupBox_up.TabIndex = 0;
            this.groupBox_up.TabStop = false;
            // 
            // groupBox_DB
            // 
            this.groupBox_DB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_DB.Controls.Add(this.label_DPPassword);
            this.groupBox_DB.Controls.Add(this.comboBox);
            this.groupBox_DB.Location = new System.Drawing.Point(504, 0);
            this.groupBox_DB.Name = "groupBox_DB";
            this.groupBox_DB.Size = new System.Drawing.Size(313, 100);
            this.groupBox_DB.TabIndex = 4;
            this.groupBox_DB.TabStop = false;
            this.groupBox_DB.Visible = false;
            // 
            // label_DPPassword
            // 
            this.label_DPPassword.AutoSize = true;
            this.label_DPPassword.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DPPassword.Location = new System.Drawing.Point(30, 55);
            this.label_DPPassword.Name = "label_DPPassword";
            this.label_DPPassword.Size = new System.Drawing.Size(91, 45);
            this.label_DPPassword.TabIndex = 10;
            this.label_DPPassword.Text = "password";
            // 
            // comboBox
            // 
            this.comboBox.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.comboBox.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(38, 24);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(261, 28);
            this.comboBox.TabIndex = 9;
            this.comboBox.Text = "select emailid";
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // button_imageBrowser
            // 
            this.button_imageBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_imageBrowser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_imageBrowser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_imageBrowser.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_imageBrowser.Location = new System.Drawing.Point(823, 36);
            this.button_imageBrowser.Name = "button_imageBrowser";
            this.button_imageBrowser.Size = new System.Drawing.Size(188, 44);
            this.button_imageBrowser.TabIndex = 3;
            this.button_imageBrowser.Text = "Browse Image";
            this.button_imageBrowser.UseVisualStyleBackColor = true;
            this.button_imageBrowser.Click += new System.EventHandler(this.button_imageBrowser_Click);
            // 
            // label_dateTimePicker
            // 
            this.label_dateTimePicker.AutoSize = true;
            this.label_dateTimePicker.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dateTimePicker.Location = new System.Drawing.Point(258, 71);
            this.label_dateTimePicker.Name = "label_dateTimePicker";
            this.label_dateTimePicker.Size = new System.Drawing.Size(125, 24);
            this.label_dateTimePicker.TabIndex = 2;
            this.label_dateTimePicker.Text = "selected date";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(13, 65);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(224, 30);
            this.dateTimePicker.TabIndex = 1;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_title.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.Purple;
            this.label_title.Location = new System.Drawing.Point(3, 18);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(480, 32);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Various Controllers In the Form";
            // 
            // openFileDialog_image
            // 
            this.openFileDialog_image.FileName = "openFileDialog_image";
            // 
            // groupBox_loginSignup
            // 
            this.groupBox_loginSignup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_loginSignup.Controls.Add(this.groupBox_signup);
            this.groupBox_loginSignup.Controls.Add(this.groupBox_loginIn);
            this.groupBox_loginSignup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox_loginSignup.Location = new System.Drawing.Point(0, 346);
            this.groupBox_loginSignup.Name = "groupBox_loginSignup";
            this.groupBox_loginSignup.Size = new System.Drawing.Size(1023, 416);
            this.groupBox_loginSignup.TabIndex = 1;
            this.groupBox_loginSignup.TabStop = false;
            // 
            // groupBox_signup
            // 
            this.groupBox_signup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_signup.Controls.Add(this.textBox_ConfirmPassS);
            this.groupBox_signup.Controls.Add(this.label_confirmPassS);
            this.groupBox_signup.Controls.Add(this.label_newUserJoin);
            this.groupBox_signup.Controls.Add(this.label_signup);
            this.groupBox_signup.Controls.Add(this.button_signup);
            this.groupBox_signup.Controls.Add(this.textBox_emailidS);
            this.groupBox_signup.Controls.Add(this.textBox_passwordS);
            this.groupBox_signup.Controls.Add(this.label_emailodS);
            this.groupBox_signup.Controls.Add(this.label_passwordS);
            this.groupBox_signup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_signup.Location = new System.Drawing.Point(497, 18);
            this.groupBox_signup.Name = "groupBox_signup";
            this.groupBox_signup.Size = new System.Drawing.Size(523, 395);
            this.groupBox_signup.TabIndex = 1;
            this.groupBox_signup.TabStop = false;
            // 
            // textBox_ConfirmPassS
            // 
            this.textBox_ConfirmPassS.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ConfirmPassS.Location = new System.Drawing.Point(165, 259);
            this.textBox_ConfirmPassS.MaxLength = 30;
            this.textBox_ConfirmPassS.Name = "textBox_ConfirmPassS";
            this.textBox_ConfirmPassS.Size = new System.Drawing.Size(310, 47);
            this.textBox_ConfirmPassS.TabIndex = 14;
            this.textBox_ConfirmPassS.TextChanged += new System.EventHandler(this.RuntimeConfirmPassValidation);
            // 
            // label_confirmPassS
            // 
            this.label_confirmPassS.AutoSize = true;
            this.label_confirmPassS.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_confirmPassS.Location = new System.Drawing.Point(18, 255);
            this.label_confirmPassS.Name = "label_confirmPassS";
            this.label_confirmPassS.Size = new System.Drawing.Size(141, 51);
            this.label_confirmPassS.TabIndex = 13;
            this.label_confirmPassS.Text = "Confirm Pass:";
            // 
            // label_newUserJoin
            // 
            this.label_newUserJoin.AutoSize = true;
            this.label_newUserJoin.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_newUserJoin.ForeColor = System.Drawing.Color.Red;
            this.label_newUserJoin.Location = new System.Drawing.Point(166, 86);
            this.label_newUserJoin.Name = "label_newUserJoin";
            this.label_newUserJoin.Size = new System.Drawing.Size(102, 37);
            this.label_newUserJoin.TabIndex = 12;
            this.label_newUserJoin.Text = "Account Exist";
            this.label_newUserJoin.Visible = false;
            // 
            // label_signup
            // 
            this.label_signup.AutoSize = true;
            this.label_signup.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_signup.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_signup.ForeColor = System.Drawing.Color.Green;
            this.label_signup.Location = new System.Drawing.Point(3, 18);
            this.label_signup.Name = "label_signup";
            this.label_signup.Size = new System.Drawing.Size(86, 24);
            this.label_signup.TabIndex = 1;
            this.label_signup.Text = "SignUp";
            // 
            // button_signup
            // 
            this.button_signup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_signup.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_signup.ForeColor = System.Drawing.Color.Blue;
            this.button_signup.Location = new System.Drawing.Point(165, 325);
            this.button_signup.Name = "button_signup";
            this.button_signup.Size = new System.Drawing.Size(103, 49);
            this.button_signup.TabIndex = 11;
            this.button_signup.Text = "SignUp";
            this.button_signup.UseVisualStyleBackColor = true;
            this.button_signup.Click += new System.EventHandler(this.button_signup_Click);
            // 
            // textBox_emailidS
            // 
            this.textBox_emailidS.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_emailidS.Location = new System.Drawing.Point(165, 124);
            this.textBox_emailidS.MaxLength = 30;
            this.textBox_emailidS.Name = "textBox_emailidS";
            this.textBox_emailidS.Size = new System.Drawing.Size(310, 47);
            this.textBox_emailidS.TabIndex = 8;
            this.textBox_emailidS.TextChanged += new System.EventHandler(this.RuntimeEmailIDValidationS);
            // 
            // textBox_passwordS
            // 
            this.textBox_passwordS.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_passwordS.Location = new System.Drawing.Point(165, 193);
            this.textBox_passwordS.MaxLength = 30;
            this.textBox_passwordS.Name = "textBox_passwordS";
            this.textBox_passwordS.Size = new System.Drawing.Size(310, 47);
            this.textBox_passwordS.TabIndex = 10;
            this.textBox_passwordS.TextChanged += new System.EventHandler(this.RuntimePasswordValidationS);
            // 
            // label_emailodS
            // 
            this.label_emailodS.AutoSize = true;
            this.label_emailodS.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_emailodS.Location = new System.Drawing.Point(57, 124);
            this.label_emailodS.Name = "label_emailodS";
            this.label_emailodS.Size = new System.Drawing.Size(102, 51);
            this.label_emailodS.TabIndex = 7;
            this.label_emailodS.Text = "Email ID:";
            // 
            // label_passwordS
            // 
            this.label_passwordS.AutoSize = true;
            this.label_passwordS.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_passwordS.Location = new System.Drawing.Point(54, 189);
            this.label_passwordS.Name = "label_passwordS";
            this.label_passwordS.Size = new System.Drawing.Size(107, 51);
            this.label_passwordS.TabIndex = 9;
            this.label_passwordS.Text = "Password:";
            // 
            // groupBox_loginIn
            // 
            this.groupBox_loginIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_loginIn.Controls.Add(this.label_invalidUserDisplay);
            this.groupBox_loginIn.Controls.Add(this.button_login);
            this.groupBox_loginIn.Controls.Add(this.textBox_password);
            this.groupBox_loginIn.Controls.Add(this.label_password);
            this.groupBox_loginIn.Controls.Add(this.textBox_emaliid);
            this.groupBox_loginIn.Controls.Add(this.label_emailid);
            this.groupBox_loginIn.Controls.Add(this.label_login);
            this.groupBox_loginIn.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox_loginIn.Location = new System.Drawing.Point(3, 18);
            this.groupBox_loginIn.Name = "groupBox_loginIn";
            this.groupBox_loginIn.Size = new System.Drawing.Size(494, 395);
            this.groupBox_loginIn.TabIndex = 0;
            this.groupBox_loginIn.TabStop = false;
            // 
            // label_invalidUserDisplay
            // 
            this.label_invalidUserDisplay.AutoSize = true;
            this.label_invalidUserDisplay.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_invalidUserDisplay.ForeColor = System.Drawing.Color.Red;
            this.label_invalidUserDisplay.Location = new System.Drawing.Point(127, 86);
            this.label_invalidUserDisplay.Name = "label_invalidUserDisplay";
            this.label_invalidUserDisplay.Size = new System.Drawing.Size(187, 37);
            this.label_invalidUserDisplay.TabIndex = 6;
            this.label_invalidUserDisplay.Text = "invalid email id or password";
            this.label_invalidUserDisplay.Visible = false;
            // 
            // button_login
            // 
            this.button_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_login.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.Color.Blue;
            this.button_login.Location = new System.Drawing.Point(131, 267);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(103, 49);
            this.button_login.TabIndex = 5;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(131, 191);
            this.textBox_password.MaxLength = 30;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(310, 47);
            this.textBox_password.TabIndex = 4;
            this.textBox_password.UseSystemPasswordChar = true;
            this.textBox_password.TextChanged += new System.EventHandler(this.RuntimePasswordValidation);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(23, 191);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(107, 51);
            this.label_password.TabIndex = 3;
            this.label_password.Text = "Password:";
            // 
            // textBox_emaliid
            // 
            this.textBox_emaliid.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_emaliid.Location = new System.Drawing.Point(134, 126);
            this.textBox_emaliid.MaxLength = 30;
            this.textBox_emaliid.Name = "textBox_emaliid";
            this.textBox_emaliid.Size = new System.Drawing.Size(310, 47);
            this.textBox_emaliid.TabIndex = 2;
            this.textBox_emaliid.TextChanged += new System.EventHandler(this.RuntimeEmailIDValidation);
            // 
            // label_emailid
            // 
            this.label_emailid.AutoSize = true;
            this.label_emailid.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_emailid.Location = new System.Drawing.Point(26, 126);
            this.label_emailid.Name = "label_emailid";
            this.label_emailid.Size = new System.Drawing.Size(102, 51);
            this.label_emailid.TabIndex = 1;
            this.label_emailid.Text = "Email ID:";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_login.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login.ForeColor = System.Drawing.Color.Green;
            this.label_login.Location = new System.Drawing.Point(3, 18);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(72, 24);
            this.label_login.TabIndex = 0;
            this.label_login.Text = "LogIn";
            // 
            // groupBox_imageGridView
            // 
            this.groupBox_imageGridView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_imageGridView.Controls.Add(this.groupBox_gridForm);
            this.groupBox_imageGridView.Controls.Add(this.pictureBox_image);
            this.groupBox_imageGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_imageGridView.Location = new System.Drawing.Point(0, 100);
            this.groupBox_imageGridView.Name = "groupBox_imageGridView";
            this.groupBox_imageGridView.Size = new System.Drawing.Size(1023, 246);
            this.groupBox_imageGridView.TabIndex = 2;
            this.groupBox_imageGridView.TabStop = false;
            // 
            // groupBox_gridForm
            // 
            this.groupBox_gridForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_gridForm.Controls.Add(this.dataGridView);
            this.groupBox_gridForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_gridForm.Location = new System.Drawing.Point(3, 18);
            this.groupBox_gridForm.Name = "groupBox_gridForm";
            this.groupBox_gridForm.Size = new System.Drawing.Size(820, 225);
            this.groupBox_gridForm.TabIndex = 3;
            this.groupBox_gridForm.TabStop = false;
            this.groupBox_gridForm.Visible = false;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowDrop = true;
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nAMEDataGridViewTextBoxColumn,
            this.aGEDataGridViewTextBoxColumn,
            this.sALARYDataGridViewTextBoxColumn,
            this.mOBILENUMBERDataGridViewTextBoxColumn,
            this.eMAILIDDataGridViewTextBoxColumn});
            this.dataGridView.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dataGridView.DataSource = this.signUPTABELBindingSource;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(3, 18);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(814, 204);
            this.dataGridView.TabIndex = 4;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.nAMEDataGridViewTextBoxColumn.Width = 76;
            // 
            // aGEDataGridViewTextBoxColumn
            // 
            this.aGEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.aGEDataGridViewTextBoxColumn.DataPropertyName = "AGE";
            this.aGEDataGridViewTextBoxColumn.HeaderText = "AGE";
            this.aGEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aGEDataGridViewTextBoxColumn.Name = "aGEDataGridViewTextBoxColumn";
            this.aGEDataGridViewTextBoxColumn.ReadOnly = true;
            this.aGEDataGridViewTextBoxColumn.Width = 66;
            // 
            // sALARYDataGridViewTextBoxColumn
            // 
            this.sALARYDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sALARYDataGridViewTextBoxColumn.DataPropertyName = "SALARY";
            this.sALARYDataGridViewTextBoxColumn.HeaderText = "SALARY";
            this.sALARYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sALARYDataGridViewTextBoxColumn.Name = "sALARYDataGridViewTextBoxColumn";
            this.sALARYDataGridViewTextBoxColumn.ReadOnly = true;
            this.sALARYDataGridViewTextBoxColumn.Width = 91;
            // 
            // mOBILENUMBERDataGridViewTextBoxColumn
            // 
            this.mOBILENUMBERDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.mOBILENUMBERDataGridViewTextBoxColumn.DataPropertyName = "MOBILENUMBER";
            this.mOBILENUMBERDataGridViewTextBoxColumn.HeaderText = "MOBILENUMBER";
            this.mOBILENUMBERDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mOBILENUMBERDataGridViewTextBoxColumn.Name = "mOBILENUMBERDataGridViewTextBoxColumn";
            this.mOBILENUMBERDataGridViewTextBoxColumn.ReadOnly = true;
            this.mOBILENUMBERDataGridViewTextBoxColumn.Width = 147;
            // 
            // eMAILIDDataGridViewTextBoxColumn
            // 
            this.eMAILIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.eMAILIDDataGridViewTextBoxColumn.DataPropertyName = "EMAILID";
            this.eMAILIDDataGridViewTextBoxColumn.HeaderText = "EMAILID";
            this.eMAILIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eMAILIDDataGridViewTextBoxColumn.Name = "eMAILIDDataGridViewTextBoxColumn";
            this.eMAILIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // signUPTABELBindingSource
            // 
            this.signUPTABELBindingSource.DataMember = "SignUPTABEL";
            this.signUPTABELBindingSource.DataSource = this.acerNitroDBDataSet;
            // 
            // acerNitroDBDataSet
            // 
            this.acerNitroDBDataSet.DataSetName = "acerNitroDBDataSet";
            this.acerNitroDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox_image
            // 
            this.pictureBox_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_image.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox_image.Location = new System.Drawing.Point(823, 18);
            this.pictureBox_image.Name = "pictureBox_image";
            this.pictureBox_image.Size = new System.Drawing.Size(197, 225);
            this.pictureBox_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_image.TabIndex = 2;
            this.pictureBox_image.TabStop = false;
            // 
            // signUPTABELTableAdapter
            // 
            this.signUPTABELTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider_emailid
            // 
            this.errorProvider_emailid.ContainerControl = this;
            // 
            // errorProvider_password
            // 
            this.errorProvider_password.ContainerControl = this;
            // 
            // errorProvider_emailidS
            // 
            this.errorProvider_emailidS.ContainerControl = this;
            // 
            // errorProvider_passwordS
            // 
            this.errorProvider_passwordS.ContainerControl = this;
            // 
            // errorProvider_confirmPassS
            // 
            this.errorProvider_confirmPassS.ContainerControl = this;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // ControllerWindowForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1023, 762);
            this.Controls.Add(this.groupBox_imageGridView);
            this.Controls.Add(this.groupBox_loginSignup);
            this.Controls.Add(this.groupBox_up);
            this.Name = "ControllerWindowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controller Window Form";
            this.Load += new System.EventHandler(this.ControllerWindowForm_Load);
            this.groupBox_up.ResumeLayout(false);
            this.groupBox_up.PerformLayout();
            this.groupBox_DB.ResumeLayout(false);
            this.groupBox_DB.PerformLayout();
            this.groupBox_loginSignup.ResumeLayout(false);
            this.groupBox_signup.ResumeLayout(false);
            this.groupBox_signup.PerformLayout();
            this.groupBox_loginIn.ResumeLayout(false);
            this.groupBox_loginIn.PerformLayout();
            this.groupBox_imageGridView.ResumeLayout(false);
            this.groupBox_gridForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signUPTABELBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acerNitroDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_emailid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_emailidS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_passwordS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_confirmPassS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_up;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_dateTimePicker;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button button_imageBrowser;
        private System.Windows.Forms.OpenFileDialog openFileDialog_image;
        private System.Windows.Forms.GroupBox groupBox_loginSignup;
        private System.Windows.Forms.GroupBox groupBox_imageGridView;
        private System.Windows.Forms.PictureBox pictureBox_image;
        private System.Windows.Forms.GroupBox groupBox_loginIn;
        private System.Windows.Forms.GroupBox groupBox_signup;
        private acerNitroDBDataSet acerNitroDBDataSet;
        private System.Windows.Forms.BindingSource signUPTABELBindingSource;
        private acerNitroDBDataSetTableAdapters.SignUPTABELTableAdapter signUPTABELTableAdapter;
        private System.Windows.Forms.GroupBox groupBox_gridForm;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label_signup;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_invalidUserDisplay;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_emaliid;
        private System.Windows.Forms.Label label_emailid;
        private System.Windows.Forms.ErrorProvider errorProvider_emailid;
        private System.Windows.Forms.ErrorProvider errorProvider_password;
        private System.Windows.Forms.Label label_newUserJoin;
        private System.Windows.Forms.Button button_signup;
        private System.Windows.Forms.TextBox textBox_emailidS;
        private System.Windows.Forms.TextBox textBox_passwordS;
        private System.Windows.Forms.Label label_emailodS;
        private System.Windows.Forms.Label label_passwordS;
        private System.Windows.Forms.TextBox textBox_ConfirmPassS;
        private System.Windows.Forms.Label label_confirmPassS;
        private System.Windows.Forms.ErrorProvider errorProvider_emailidS;
        private System.Windows.Forms.ErrorProvider errorProvider_passwordS;
        private System.Windows.Forms.ErrorProvider errorProvider_confirmPassS;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALARYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOBILENUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox_DB;
        private System.Windows.Forms.Label label_DPPassword;
        private System.Windows.Forms.ComboBox comboBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}

