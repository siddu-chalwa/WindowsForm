﻿namespace SecondClient
{
    partial class DisplayForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.display_button = new System.Windows.Forms.Button();
            this.age_textbox = new System.Windows.Forms.TextBox();
            this.age_label = new System.Windows.Forms.Label();
            this.salary_textbox = new System.Windows.Forms.TextBox();
            this.salary_label = new System.Windows.Forms.Label();
            this.emailid_textbox = new System.Windows.Forms.TextBox();
            this.emailid_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(45, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(629, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Press Display Button To Display Data";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.name_label.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(174, 180);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(94, 33);
            this.name_label.TabIndex = 1;
            this.name_label.Text = "Name: ";
            // 
            // name_textbox
            // 
            this.name_textbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.name_textbox.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_textbox.Location = new System.Drawing.Point(330, 180);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(330, 39);
            this.name_textbox.TabIndex = 5;
            // 
            // display_button
            // 
            this.display_button.Location = new System.Drawing.Point(330, 554);
            this.display_button.Name = "display_button";
            this.display_button.Size = new System.Drawing.Size(150, 53);
            this.display_button.TabIndex = 6;
            this.display_button.Text = "Display";
            this.display_button.UseVisualStyleBackColor = true;
            this.display_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DisplayButton_OpenRegistrationForm);
            // 
            // age_textbox
            // 
            this.age_textbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.age_textbox.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_textbox.Location = new System.Drawing.Point(330, 258);
            this.age_textbox.Name = "age_textbox";
            this.age_textbox.Size = new System.Drawing.Size(330, 39);
            this.age_textbox.TabIndex = 9;
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.age_label.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_label.Location = new System.Drawing.Point(174, 258);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(67, 33);
            this.age_label.TabIndex = 8;
            this.age_label.Text = "Age:";
            // 
            // salary_textbox
            // 
            this.salary_textbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.salary_textbox.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_textbox.Location = new System.Drawing.Point(330, 336);
            this.salary_textbox.Name = "salary_textbox";
            this.salary_textbox.Size = new System.Drawing.Size(330, 39);
            this.salary_textbox.TabIndex = 11;
            // 
            // salary_label
            // 
            this.salary_label.AutoSize = true;
            this.salary_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.salary_label.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_label.Location = new System.Drawing.Point(174, 336);
            this.salary_label.Name = "salary_label";
            this.salary_label.Size = new System.Drawing.Size(93, 33);
            this.salary_label.TabIndex = 10;
            this.salary_label.Text = "Salary:";
            // 
            // emailid_textbox
            // 
            this.emailid_textbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.emailid_textbox.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailid_textbox.Location = new System.Drawing.Point(330, 412);
            this.emailid_textbox.Name = "emailid_textbox";
            this.emailid_textbox.Size = new System.Drawing.Size(330, 39);
            this.emailid_textbox.TabIndex = 13;
            // 
            // emailid_label
            // 
            this.emailid_label.AutoSize = true;
            this.emailid_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.emailid_label.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailid_label.Location = new System.Drawing.Point(174, 412);
            this.emailid_label.Name = "emailid_label";
            this.emailid_label.Size = new System.Drawing.Size(123, 33);
            this.emailid_label.TabIndex = 12;
            this.emailid_label.Text = "Email ID:";
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.emailid_textbox);
            this.Controls.Add(this.emailid_label);
            this.Controls.Add(this.salary_textbox);
            this.Controls.Add(this.salary_label);
            this.Controls.Add(this.age_textbox);
            this.Controls.Add(this.age_label);
            this.Controls.Add(this.display_button);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DisplayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Button display_button;
        private System.Windows.Forms.TextBox age_textbox;
        private System.Windows.Forms.Label age_label;
        private System.Windows.Forms.TextBox salary_textbox;
        private System.Windows.Forms.Label salary_label;
        private System.Windows.Forms.TextBox emailid_textbox;
        private System.Windows.Forms.Label emailid_label;
    }
}