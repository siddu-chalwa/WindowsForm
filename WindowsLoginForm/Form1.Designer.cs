namespace WindowsLoginForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this._Name = new System.Windows.Forms.Label();
            this.Name_T = new System.Windows.Forms.TextBox();
            this._Age = new System.Windows.Forms.Label();
            this.Age_T = new System.Windows.Forms.TextBox();
            this._Submit = new System.Windows.Forms.Button();
            this._Reset = new System.Windows.Forms.Button();
            this.EmailID_T = new System.Windows.Forms.TextBox();
            this._EmailID = new System.Windows.Forms.Label();
            this.Salary_T = new System.Windows.Forms.TextBox();
            this._Salary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // _Name
            // 
            this._Name.AllowDrop = true;
            this._Name.AutoEllipsis = true;
            resources.ApplyResources(this._Name, "_Name");
            this._Name.Name = "_Name";
            // 
            // Name_T
            // 
            resources.ApplyResources(this.Name_T, "Name_T");
            this.Name_T.Name = "Name_T";
            // 
            // _Age
            // 
            this._Age.AllowDrop = true;
            this._Age.AutoEllipsis = true;
            resources.ApplyResources(this._Age, "_Age");
            this._Age.Name = "_Age";
            // 
            // Age_T
            // 
            resources.ApplyResources(this.Age_T, "Age_T");
            this.Age_T.Name = "Age_T";
            // 
            // _Submit
            // 
            resources.ApplyResources(this._Submit, "_Submit");
            this._Submit.Name = "_Submit";
            this._Submit.UseVisualStyleBackColor = true;
            this._Submit.Enter += new System.EventHandler(this.Submit_Validation);
            // 
            // _Reset
            // 
            resources.ApplyResources(this._Reset, "_Reset");
            this._Reset.Name = "_Reset";
            this._Reset.UseVisualStyleBackColor = true;
            this._Reset.Enter += new System.EventHandler(this.Reset_Validation);
            // 
            // EmailID_T
            // 
            resources.ApplyResources(this.EmailID_T, "EmailID_T");
            this.EmailID_T.Name = "EmailID_T";
            // 
            // _EmailID
            // 
            this._EmailID.AllowDrop = true;
            this._EmailID.AutoEllipsis = true;
            resources.ApplyResources(this._EmailID, "_EmailID");
            this._EmailID.Name = "_EmailID";
            // 
            // Salary_T
            // 
            resources.ApplyResources(this.Salary_T, "Salary_T");
            this.Salary_T.Name = "Salary_T";
            // 
            // _Salary
            // 
            this._Salary.AllowDrop = true;
            this._Salary.AutoEllipsis = true;
            resources.ApplyResources(this._Salary, "_Salary");
            this._Salary.Name = "_Salary";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.Controls.Add(this.EmailID_T);
            this.Controls.Add(this._EmailID);
            this.Controls.Add(this.Salary_T);
            this.Controls.Add(this._Salary);
            this.Controls.Add(this._Reset);
            this.Controls.Add(this._Submit);
            this.Controls.Add(this.Age_T);
            this.Controls.Add(this._Age);
            this.Controls.Add(this.Name_T);
            this.Controls.Add(this._Name);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _Name;
        private System.Windows.Forms.TextBox Name_T;
        private System.Windows.Forms.Label _Age;
        private System.Windows.Forms.TextBox Age_T;
        private System.Windows.Forms.Button _Submit;
        private System.Windows.Forms.Button _Reset;
        private System.Windows.Forms.TextBox EmailID_T;
        private System.Windows.Forms.Label _EmailID;
        private System.Windows.Forms.TextBox Salary_T;
        private System.Windows.Forms.Label _Salary;
    }
}

