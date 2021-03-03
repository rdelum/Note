namespace Notepad
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
            this.textBox_Title = new System.Windows.Forms.TextBox();
            this.ConnectSQL_Button = new System.Windows.Forms.Button();
            this.textBox_NoteContent = new System.Windows.Forms.TextBox();
            this.Button_AddNote = new System.Windows.Forms.Button();
            this.button_EditNote = new System.Windows.Forms.Button();
            this.button_ShowNote = new System.Windows.Forms.Button();
            this.textBoxContentEdit = new System.Windows.Forms.TextBox();
            this.textBox_TitleEdit = new System.Windows.Forms.TextBox();
            this.textBoxContentShow = new System.Windows.Forms.TextBox();
            this.textBoxTitleShow = new System.Windows.Forms.TextBox();
            this.textBoxEditID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_Title
            // 
            this.textBox_Title.Location = new System.Drawing.Point(51, 195);
            this.textBox_Title.Name = "textBox_Title";
            this.textBox_Title.Size = new System.Drawing.Size(100, 20);
            this.textBox_Title.TabIndex = 0;
            // 
            // ConnectSQL_Button
            // 
            this.ConnectSQL_Button.Location = new System.Drawing.Point(51, 44);
            this.ConnectSQL_Button.Name = "ConnectSQL_Button";
            this.ConnectSQL_Button.Size = new System.Drawing.Size(185, 65);
            this.ConnectSQL_Button.TabIndex = 1;
            this.ConnectSQL_Button.Text = "Configure DataBase";
            this.ConnectSQL_Button.UseVisualStyleBackColor = true;
            this.ConnectSQL_Button.Click += new System.EventHandler(this.ConnectSQL_Button_Click);
            // 
            // textBox_NoteContent
            // 
            this.textBox_NoteContent.Location = new System.Drawing.Point(51, 232);
            this.textBox_NoteContent.Name = "textBox_NoteContent";
            this.textBox_NoteContent.Size = new System.Drawing.Size(185, 20);
            this.textBox_NoteContent.TabIndex = 2;
            // 
            // Button_AddNote
            // 
            this.Button_AddNote.Location = new System.Drawing.Point(51, 258);
            this.Button_AddNote.Name = "Button_AddNote";
            this.Button_AddNote.Size = new System.Drawing.Size(75, 23);
            this.Button_AddNote.TabIndex = 3;
            this.Button_AddNote.Text = "Add new note";
            this.Button_AddNote.UseVisualStyleBackColor = true;
            this.Button_AddNote.Click += new System.EventHandler(this.Button_AddNote_Click);
            // 
            // button_EditNote
            // 
            this.button_EditNote.Location = new System.Drawing.Point(305, 258);
            this.button_EditNote.Name = "button_EditNote";
            this.button_EditNote.Size = new System.Drawing.Size(75, 23);
            this.button_EditNote.TabIndex = 4;
            this.button_EditNote.Text = "Edit note";
            this.button_EditNote.UseVisualStyleBackColor = true;
            this.button_EditNote.Click += new System.EventHandler(this.button_EditNote_Click);
            // 
            // button_ShowNote
            // 
            this.button_ShowNote.Location = new System.Drawing.Point(605, 258);
            this.button_ShowNote.Name = "button_ShowNote";
            this.button_ShowNote.Size = new System.Drawing.Size(75, 23);
            this.button_ShowNote.TabIndex = 5;
            this.button_ShowNote.Text = "Show note";
            this.button_ShowNote.UseVisualStyleBackColor = true;
            // 
            // textBoxContentEdit
            // 
            this.textBoxContentEdit.Location = new System.Drawing.Point(305, 232);
            this.textBoxContentEdit.Name = "textBoxContentEdit";
            this.textBoxContentEdit.Size = new System.Drawing.Size(185, 20);
            this.textBoxContentEdit.TabIndex = 7;
            // 
            // textBox_TitleEdit
            // 
            this.textBox_TitleEdit.Location = new System.Drawing.Point(305, 195);
            this.textBox_TitleEdit.Name = "textBox_TitleEdit";
            this.textBox_TitleEdit.Size = new System.Drawing.Size(100, 20);
            this.textBox_TitleEdit.TabIndex = 6;
            // 
            // textBoxContentShow
            // 
            this.textBoxContentShow.Location = new System.Drawing.Point(592, 232);
            this.textBoxContentShow.Name = "textBoxContentShow";
            this.textBoxContentShow.Size = new System.Drawing.Size(185, 20);
            this.textBoxContentShow.TabIndex = 9;
            // 
            // textBoxTitleShow
            // 
            this.textBoxTitleShow.Location = new System.Drawing.Point(592, 195);
            this.textBoxTitleShow.Name = "textBoxTitleShow";
            this.textBoxTitleShow.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitleShow.TabIndex = 8;
            // 
            // textBoxEditID
            // 
            this.textBoxEditID.Location = new System.Drawing.Point(305, 154);
            this.textBoxEditID.Name = "textBoxEditID";
            this.textBoxEditID.Size = new System.Drawing.Size(100, 20);
            this.textBoxEditID.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxEditID);
            this.Controls.Add(this.textBoxContentShow);
            this.Controls.Add(this.textBoxTitleShow);
            this.Controls.Add(this.textBoxContentEdit);
            this.Controls.Add(this.textBox_TitleEdit);
            this.Controls.Add(this.button_ShowNote);
            this.Controls.Add(this.button_EditNote);
            this.Controls.Add(this.Button_AddNote);
            this.Controls.Add(this.textBox_NoteContent);
            this.Controls.Add(this.ConnectSQL_Button);
            this.Controls.Add(this.textBox_Title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Title;
        private System.Windows.Forms.Button ConnectSQL_Button;
        private System.Windows.Forms.TextBox textBox_NoteContent;
        private System.Windows.Forms.Button Button_AddNote;
        private System.Windows.Forms.Button button_EditNote;
        private System.Windows.Forms.Button button_ShowNote;
        private System.Windows.Forms.TextBox textBoxContentEdit;
        private System.Windows.Forms.TextBox textBox_TitleEdit;
        private System.Windows.Forms.TextBox textBoxContentShow;
        private System.Windows.Forms.TextBox textBoxTitleShow;
        private System.Windows.Forms.TextBox textBoxEditID;
    }
}

