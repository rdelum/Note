namespace Notepad
{
    partial class ConfigureDataBase
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
            this.LabelDataBase = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_NT = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TextBox_DataBase = new System.Windows.Forms.TextBox();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_Serwer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelDataBase
            // 
            this.LabelDataBase.AutoSize = true;
            this.LabelDataBase.Location = new System.Drawing.Point(65, 138);
            this.LabelDataBase.Name = "LabelDataBase";
            this.LabelDataBase.Size = new System.Drawing.Size(53, 13);
            this.LabelDataBase.TabIndex = 0;
            this.LabelDataBase.Text = "Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "password";
            // 
            // checkBox_NT
            // 
            this.checkBox_NT.AutoSize = true;
            this.checkBox_NT.Checked = true;
            this.checkBox_NT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_NT.Location = new System.Drawing.Point(50, 170);
            this.checkBox_NT.Name = "checkBox_NT";
            this.checkBox_NT.Size = new System.Drawing.Size(112, 17);
            this.checkBox_NT.TabIndex = 3;
            this.checkBox_NT.Text = "NT Authentication";
            this.checkBox_NT.UseVisualStyleBackColor = true;
            this.checkBox_NT.CheckedChanged += new System.EventHandler(this.checkBox_NT_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Test connection";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_TestConnection);
            // 
            // TextBox_DataBase
            // 
            this.TextBox_DataBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Notepad.Properties.Settings.Default, "DatabaseName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TextBox_DataBase.Location = new System.Drawing.Point(162, 135);
            this.TextBox_DataBase.Name = "TextBox_DataBase";
            this.TextBox_DataBase.Size = new System.Drawing.Size(100, 20);
            this.TextBox_DataBase.TabIndex = 5;
            this.TextBox_DataBase.Text = global::Notepad.Properties.Settings.Default.DatabaseName;
            // 
            // textBox_login
            // 
            this.textBox_login.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Notepad.Properties.Settings.Default, "Login", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_login.Location = new System.Drawing.Point(162, 193);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(100, 20);
            this.textBox_login.TabIndex = 6;
            this.textBox_login.Text = global::Notepad.Properties.Settings.Default.Login;
            // 
            // textBox_password
            // 
            this.textBox_password.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Notepad.Properties.Settings.Default, "Password", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_password.Location = new System.Drawing.Point(162, 226);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(100, 20);
            this.textBox_password.TabIndex = 7;
            this.textBox_password.Text = global::Notepad.Properties.Settings.Default.Password;
            // 
            // textBox_Serwer
            // 
            this.textBox_Serwer.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.textBox_Serwer.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Notepad.Properties.Settings.Default, "SerwerName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_Serwer.Location = new System.Drawing.Point(162, 109);
            this.textBox_Serwer.Name = "textBox_Serwer";
            this.textBox_Serwer.Size = new System.Drawing.Size(100, 20);
            this.textBox_Serwer.TabIndex = 8;
            this.textBox_Serwer.Text = global::Notepad.Properties.Settings.Default.SerwerName;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Serwer";
            // 
            // ConfigureDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 384);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Serwer);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.TextBox_DataBase);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox_NT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelDataBase);
            this.Name = "ConfigureDataBase";
            this.Text = "ConfigureDataBase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelDataBase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_NT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TextBox_DataBase;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_Serwer;
        private System.Windows.Forms.Label label1;
    }
}