namespace LogIn_SignUp_From
{
    partial class LogIn_SignUp_Window
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
            this.title_label = new System.Windows.Forms.Label();
            this.email_id_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.emailid_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.checkbox = new System.Windows.Forms.CheckBox();
            this.login_button = new System.Windows.Forms.Button();
            this.signup_button = new System.Windows.Forms.Button();
            this.emailid_T_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.password_T_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.age_textbox = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.age_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.salary_textbox = new System.Windows.Forms.TextBox();
            this.salary_label = new System.Windows.Forms.Label();
            this.name_T_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.age_T_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.salary_T_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.emailid_T_errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_T_errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.name_T_errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.age_T_errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salary_T_errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Microsoft Yi Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.ForeColor = System.Drawing.Color.Purple;
            this.title_label.Location = new System.Drawing.Point(79, 61);
            this.title_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(444, 38);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "joining each other, let\'s grow";
            // 
            // email_id_label
            // 
            this.email_id_label.AutoSize = true;
            this.email_id_label.Location = new System.Drawing.Point(16, 194);
            this.email_id_label.Name = "email_id_label";
            this.email_id_label.Size = new System.Drawing.Size(143, 35);
            this.email_id_label.TabIndex = 1;
            this.email_id_label.Text = "email_id:";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(12, 271);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(149, 35);
            this.password_label.TabIndex = 2;
            this.password_label.Text = "password:";
            // 
            // emailid_textbox
            // 
            this.emailid_textbox.Location = new System.Drawing.Point(200, 191);
            this.emailid_textbox.MaxLength = 30;
            this.emailid_textbox.Name = "emailid_textbox";
            this.emailid_textbox.Size = new System.Drawing.Size(323, 42);
            this.emailid_textbox.TabIndex = 3;
            this.emailid_textbox.Leave += new System.EventHandler(this.errorProviderClear_EmailT);
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(200, 268);
            this.password_textbox.MaxLength = 22;
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = 'x';
            this.password_textbox.Size = new System.Drawing.Size(323, 42);
            this.password_textbox.TabIndex = 4;
            this.password_textbox.Leave += new System.EventHandler(this.errorProvider_PasswordT);
            // 
            // checkbox
            // 
            this.checkbox.AutoSize = true;
            this.checkbox.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox.ForeColor = System.Drawing.Color.Green;
            this.checkbox.Location = new System.Drawing.Point(200, 343);
            this.checkbox.Name = "checkbox";
            this.checkbox.Size = new System.Drawing.Size(255, 24);
            this.checkbox.TabIndex = 5;
            this.checkbox.Text = "check me, if you are new to us";
            this.checkbox.UseVisualStyleBackColor = true;
            this.checkbox.CheckStateChanged += new System.EventHandler(this.UnhideSignupButton);
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(220, 646);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(122, 44);
            this.login_button.TabIndex = 6;
            this.login_button.Text = "LogIn";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LoginB_Validation);
            // 
            // signup_button
            // 
            this.signup_button.Location = new System.Drawing.Point(363, 646);
            this.signup_button.Name = "signup_button";
            this.signup_button.Size = new System.Drawing.Size(122, 44);
            this.signup_button.TabIndex = 7;
            this.signup_button.Text = "SignUp";
            this.signup_button.UseVisualStyleBackColor = true;
            this.signup_button.Visible = false;
            this.signup_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Signup_validation);
            // 
            // emailid_T_errorProvider
            // 
            this.emailid_T_errorProvider.ContainerControl = this;
            // 
            // password_T_errorProvider
            // 
            this.password_T_errorProvider.ContainerControl = this;
            // 
            // age_textbox
            // 
            this.age_textbox.Location = new System.Drawing.Point(200, 489);
            this.age_textbox.MaxLength = 22;
            this.age_textbox.Name = "age_textbox";
            this.age_textbox.Size = new System.Drawing.Size(323, 42);
            this.age_textbox.TabIndex = 11;
            this.age_textbox.Visible = false;
            this.age_textbox.Leave += new System.EventHandler(this.errorProvider_AgeClear);
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(200, 416);
            this.name_textbox.MaxLength = 20;
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(323, 42);
            this.name_textbox.TabIndex = 10;
            this.name_textbox.Visible = false;
            this.name_textbox.Leave += new System.EventHandler(this.errorProvide_NameClear);
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.Location = new System.Drawing.Point(12, 496);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(74, 35);
            this.age_label.TabIndex = 9;
            this.age_label.Text = "Age:";
            this.age_label.Visible = false;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(16, 419);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(98, 35);
            this.name_label.TabIndex = 8;
            this.name_label.Text = "name:";
            this.name_label.Visible = false;
            // 
            // salary_textbox
            // 
            this.salary_textbox.Location = new System.Drawing.Point(200, 563);
            this.salary_textbox.MaxLength = 22;
            this.salary_textbox.Name = "salary_textbox";
            this.salary_textbox.Size = new System.Drawing.Size(323, 42);
            this.salary_textbox.TabIndex = 13;
            this.salary_textbox.Visible = false;
            this.salary_textbox.Leave += new System.EventHandler(this.errorProvider_SalartClear);
            // 
            // salary_label
            // 
            this.salary_label.AutoSize = true;
            this.salary_label.Location = new System.Drawing.Point(12, 570);
            this.salary_label.Name = "salary_label";
            this.salary_label.Size = new System.Drawing.Size(107, 35);
            this.salary_label.TabIndex = 12;
            this.salary_label.Text = "Salary:";
            this.salary_label.Visible = false;
            // 
            // name_T_errorProvider
            // 
            this.name_T_errorProvider.ContainerControl = this;
            // 
            // age_T_errorProvider
            // 
            this.age_T_errorProvider.ContainerControl = this;
            // 
            // salary_T_errorProvider
            // 
            this.salary_T_errorProvider.ContainerControl = this;
            // 
            // LogIn_SignUp_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 726);
            this.Controls.Add(this.salary_textbox);
            this.Controls.Add(this.salary_label);
            this.Controls.Add(this.age_textbox);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.age_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.signup_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.checkbox);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.emailid_textbox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.email_id_label);
            this.Controls.Add(this.title_label);
            this.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "LogIn_SignUp_Window";
            this.Text = "Login Signup Window Form";
            ((System.ComponentModel.ISupportInitialize)(this.emailid_T_errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_T_errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.name_T_errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.age_T_errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salary_T_errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label email_id_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox emailid_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.CheckBox checkbox;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button signup_button;
        private System.Windows.Forms.ErrorProvider emailid_T_errorProvider;
        private System.Windows.Forms.ErrorProvider password_T_errorProvider;
        private System.Windows.Forms.TextBox salary_textbox;
        private System.Windows.Forms.Label salary_label;
        private System.Windows.Forms.TextBox age_textbox;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label age_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.ErrorProvider name_T_errorProvider;
        private System.Windows.Forms.ErrorProvider age_T_errorProvider;
        private System.Windows.Forms.ErrorProvider salary_T_errorProvider;
    }
}

