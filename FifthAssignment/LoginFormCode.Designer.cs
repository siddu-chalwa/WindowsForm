namespace FifthAssignment
{
    partial class LoginFormCode
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
            this.title_name = new System.Windows.Forms.Label();
            this.userid_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.userid_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.userid_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.password_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.invalid_user_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userid_errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // title_name
            // 
            this.title_name.AutoSize = true;
            this.title_name.Font = new System.Drawing.Font("Georgia", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_name.ForeColor = System.Drawing.Color.Purple;
            this.title_name.Location = new System.Drawing.Point(32, 25);
            this.title_name.Name = "title_name";
            this.title_name.Size = new System.Drawing.Size(613, 43);
            this.title_name.TabIndex = 0;
            this.title_name.Text = "Login, to continue into organization";
            this.title_name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // userid_label
            // 
            this.userid_label.AutoSize = true;
            this.userid_label.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userid_label.ForeColor = System.Drawing.Color.Blue;
            this.userid_label.Location = new System.Drawing.Point(52, 127);
            this.userid_label.Name = "userid_label";
            this.userid_label.Size = new System.Drawing.Size(138, 32);
            this.userid_label.TabIndex = 1;
            this.userid_label.Text = "USER ID:";
            this.userid_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.ForeColor = System.Drawing.Color.Blue;
            this.password_label.Location = new System.Drawing.Point(55, 194);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(181, 32);
            this.password_label.TabIndex = 2;
            this.password_label.Text = "PASSWORD:";
            // 
            // userid_textbox
            // 
            this.userid_textbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.userid_textbox.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userid_textbox.ForeColor = System.Drawing.Color.Green;
            this.userid_textbox.Location = new System.Drawing.Point(242, 121);
            this.userid_textbox.Name = "userid_textbox";
            this.userid_textbox.Size = new System.Drawing.Size(370, 38);
            this.userid_textbox.TabIndex = 3;
            this.userid_textbox.TextChanged += new System.EventHandler(this.RuntimeUserValidation);
            // 
            // password_textbox
            // 
            this.password_textbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.password_textbox.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textbox.ForeColor = System.Drawing.Color.Green;
            this.password_textbox.Location = new System.Drawing.Point(242, 188);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(370, 38);
            this.password_textbox.TabIndex = 4;
            this.password_textbox.UseSystemPasswordChar = true;
            this.password_textbox.TextChanged += new System.EventHandler(this.RuntimePasswordValidation);
            // 
            // login_button
            // 
            this.login_button.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.ForeColor = System.Drawing.Color.Red;
            this.login_button.Location = new System.Drawing.Point(242, 254);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(139, 48);
            this.login_button.TabIndex = 5;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.LoginSubmissionButton);
            this.login_button.Enter += new System.EventHandler(this.LoginSubmissionButton);
            // 
            // userid_errorProvider
            // 
            this.userid_errorProvider.ContainerControl = this;
            // 
            // password_errorProvider
            // 
            this.password_errorProvider.ContainerControl = this;
            // 
            // invalid_user_label
            // 
            this.invalid_user_label.AutoSize = true;
            this.invalid_user_label.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalid_user_label.ForeColor = System.Drawing.Color.Red;
            this.invalid_user_label.Location = new System.Drawing.Point(239, 88);
            this.invalid_user_label.Name = "invalid_user_label";
            this.invalid_user_label.Size = new System.Drawing.Size(211, 18);
            this.invalid_user_label.TabIndex = 6;
            this.invalid_user_label.Text = "invalid userid or password";
            this.invalid_user_label.Visible = false;
            // 
            // LoginFormCode
            // 
            this.AcceptButton = this.login_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 314);
            this.Controls.Add(this.invalid_user_label);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.userid_textbox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.userid_label);
            this.Controls.Add(this.title_name);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "LoginFormCode";
            this.Text = "Window Form";
            ((System.ComponentModel.ISupportInitialize)(this.userid_errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_name;
        private System.Windows.Forms.Label userid_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox userid_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.ErrorProvider userid_errorProvider;
        private System.Windows.Forms.ErrorProvider password_errorProvider;
        private System.Windows.Forms.Label invalid_user_label;
    }
}

