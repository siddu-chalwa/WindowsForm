namespace SixthClient
{
    partial class EntryForm
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
            this.groupBox_signup = new System.Windows.Forms.GroupBox();
            this.textBox_ContactNo = new System.Windows.Forms.TextBox();
            this.label_mobileNo = new System.Windows.Forms.Label();
            this.textBox_salary = new System.Windows.Forms.TextBox();
            this.label_salary = new System.Windows.Forms.Label();
            this.label_dataEntry = new System.Windows.Forms.Label();
            this.button_submit = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_age = new System.Windows.Forms.Label();
            this.errorProvider_name = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_age = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_salary = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_contactNo = new System.Windows.Forms.ErrorProvider(this.components);
            this.button_uploadimg = new System.Windows.Forms.Button();
            this.openFileDialog_imageUpload = new System.Windows.Forms.OpenFileDialog();
            this.groupBox_signup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_salary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_contactNo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_signup
            // 
            this.groupBox_signup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_signup.Controls.Add(this.button_uploadimg);
            this.groupBox_signup.Controls.Add(this.textBox_ContactNo);
            this.groupBox_signup.Controls.Add(this.label_mobileNo);
            this.groupBox_signup.Controls.Add(this.textBox_salary);
            this.groupBox_signup.Controls.Add(this.label_salary);
            this.groupBox_signup.Controls.Add(this.label_dataEntry);
            this.groupBox_signup.Controls.Add(this.button_submit);
            this.groupBox_signup.Controls.Add(this.textBox_name);
            this.groupBox_signup.Controls.Add(this.textBox_age);
            this.groupBox_signup.Controls.Add(this.label_name);
            this.groupBox_signup.Controls.Add(this.label_age);
            this.groupBox_signup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_signup.Location = new System.Drawing.Point(0, 0);
            this.groupBox_signup.Name = "groupBox_signup";
            this.groupBox_signup.Size = new System.Drawing.Size(800, 450);
            this.groupBox_signup.TabIndex = 2;
            this.groupBox_signup.TabStop = false;
            // 
            // textBox_ContactNo
            // 
            this.textBox_ContactNo.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ContactNo.Location = new System.Drawing.Point(171, 311);
            this.textBox_ContactNo.MaxLength = 30;
            this.textBox_ContactNo.Name = "textBox_ContactNo";
            this.textBox_ContactNo.Size = new System.Drawing.Size(310, 47);
            this.textBox_ContactNo.TabIndex = 16;
            this.textBox_ContactNo.TextChanged += new System.EventHandler(this.textBox_ContactNo_TextChanged);
            this.textBox_ContactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress_NoCharacterAllowed);
            // 
            // label_mobileNo
            // 
            this.label_mobileNo.AutoSize = true;
            this.label_mobileNo.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mobileNo.Location = new System.Drawing.Point(30, 307);
            this.label_mobileNo.Name = "label_mobileNo";
            this.label_mobileNo.Size = new System.Drawing.Size(135, 51);
            this.label_mobileNo.TabIndex = 15;
            this.label_mobileNo.Text = "Contact NO.:";
            // 
            // textBox_salary
            // 
            this.textBox_salary.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_salary.Location = new System.Drawing.Point(171, 242);
            this.textBox_salary.MaxLength = 30;
            this.textBox_salary.Name = "textBox_salary";
            this.textBox_salary.Size = new System.Drawing.Size(310, 47);
            this.textBox_salary.TabIndex = 14;
            this.textBox_salary.TextChanged += new System.EventHandler(this.textBox_salary_TextChanged);
            this.textBox_salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress_NoCharacterAllowed);
            // 
            // label_salary
            // 
            this.label_salary.AutoSize = true;
            this.label_salary.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_salary.Location = new System.Drawing.Point(30, 238);
            this.label_salary.Name = "label_salary";
            this.label_salary.Size = new System.Drawing.Size(79, 51);
            this.label_salary.TabIndex = 13;
            this.label_salary.Text = "Salary:";
            // 
            // label_dataEntry
            // 
            this.label_dataEntry.AutoSize = true;
            this.label_dataEntry.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_dataEntry.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dataEntry.ForeColor = System.Drawing.Color.Green;
            this.label_dataEntry.Location = new System.Drawing.Point(3, 18);
            this.label_dataEntry.Name = "label_dataEntry";
            this.label_dataEntry.Size = new System.Drawing.Size(200, 32);
            this.label_dataEntry.TabIndex = 1;
            this.label_dataEntry.Text = "Enter details";
            // 
            // button_submit
            // 
            this.button_submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_submit.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_submit.ForeColor = System.Drawing.Color.Blue;
            this.button_submit.Location = new System.Drawing.Point(171, 372);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(103, 49);
            this.button_submit.TabIndex = 11;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_name.Location = new System.Drawing.Point(171, 107);
            this.textBox_name.MaxLength = 30;
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(310, 47);
            this.textBox_name.TabIndex = 8;
            this.textBox_name.TextChanged += new System.EventHandler(this.RuntimeNameValidation);
            // 
            // textBox_age
            // 
            this.textBox_age.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_age.Location = new System.Drawing.Point(171, 176);
            this.textBox_age.MaxLength = 30;
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(310, 47);
            this.textBox_age.TabIndex = 10;
            this.textBox_age.TextChanged += new System.EventHandler(this.textBox_age_TextChanged);
            this.textBox_age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress_NoCharacterAllowed);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(33, 107);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(78, 51);
            this.label_name.TabIndex = 7;
            this.label_name.Text = "Name:";
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_age.Location = new System.Drawing.Point(30, 172);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(61, 51);
            this.label_age.TabIndex = 9;
            this.label_age.Text = "Age:";
            // 
            // errorProvider_name
            // 
            this.errorProvider_name.ContainerControl = this;
            // 
            // errorProvider_age
            // 
            this.errorProvider_age.ContainerControl = this;
            // 
            // errorProvider_salary
            // 
            this.errorProvider_salary.ContainerControl = this;
            // 
            // errorProvider_contactNo
            // 
            this.errorProvider_contactNo.ContainerControl = this;
            // 
            // button_uploadimg
            // 
            this.button_uploadimg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_uploadimg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_uploadimg.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_uploadimg.ForeColor = System.Drawing.Color.SeaGreen;
            this.button_uploadimg.Location = new System.Drawing.Point(507, 311);
            this.button_uploadimg.Name = "button_uploadimg";
            this.button_uploadimg.Size = new System.Drawing.Size(171, 49);
            this.button_uploadimg.TabIndex = 17;
            this.button_uploadimg.Text = "upload image";
            this.button_uploadimg.UseVisualStyleBackColor = true;
            this.button_uploadimg.Click += new System.EventHandler(this.button_uploadimg_Click);
            // 
            // openFileDialog_imageUpload
            // 
            this.openFileDialog_imageUpload.FileName = "openFileDialog1";
            // 
            // EntryForm
            // 
            this.AcceptButton = this.button_submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_signup);
            this.Name = "EntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Entry Window Form";
            this.groupBox_signup.ResumeLayout(false);
            this.groupBox_signup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_salary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_contactNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_signup;
        private System.Windows.Forms.TextBox textBox_salary;
        private System.Windows.Forms.Label label_salary;
        private System.Windows.Forms.Label label_dataEntry;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_age;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.TextBox textBox_ContactNo;
        private System.Windows.Forms.Label label_mobileNo;
        private System.Windows.Forms.ErrorProvider errorProvider_name;
        private System.Windows.Forms.ErrorProvider errorProvider_age;
        private System.Windows.Forms.ErrorProvider errorProvider_salary;
        private System.Windows.Forms.ErrorProvider errorProvider_contactNo;
        private System.Windows.Forms.Button button_uploadimg;
        private System.Windows.Forms.OpenFileDialog openFileDialog_imageUpload;
    }
}