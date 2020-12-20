namespace SyllabusEditor
{
    partial class FileOpenForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.facultyCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lectureCode = new System.Windows.Forms.TextBox();
            this.userInputFaculty = new System.Windows.Forms.Label();
            this.userInputCode = new System.Windows.Forms.Label();
            this.htmlOutputTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // facultyCode
            // 
            this.facultyCode.Location = new System.Drawing.Point(140, 51);
            this.facultyCode.Name = "facultyCode";
            this.facultyCode.Size = new System.Drawing.Size(100, 20);
            this.facultyCode.TabIndex = 1;
            this.facultyCode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Lecture Code: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lectureCode
            // 
            this.lectureCode.Location = new System.Drawing.Point(246, 51);
            this.lectureCode.Name = "lectureCode";
            this.lectureCode.Size = new System.Drawing.Size(100, 20);
            this.lectureCode.TabIndex = 3;
            // 
            // userInputFaculty
            // 
            this.userInputFaculty.AutoSize = true;
            this.userInputFaculty.Location = new System.Drawing.Point(167, 35);
            this.userInputFaculty.Name = "userInputFaculty";
            this.userInputFaculty.Size = new System.Drawing.Size(41, 13);
            this.userInputFaculty.TabIndex = 4;
            this.userInputFaculty.Text = "Faculty";
            // 
            // userInputCode
            // 
            this.userInputCode.AutoSize = true;
            this.userInputCode.Location = new System.Drawing.Point(276, 35);
            this.userInputCode.Name = "userInputCode";
            this.userInputCode.Size = new System.Drawing.Size(32, 13);
            this.userInputCode.TabIndex = 5;
            this.userInputCode.Text = "Code";
            // 
            // htmlOutputTextBox
            // 
            this.htmlOutputTextBox.Location = new System.Drawing.Point(12, 125);
            this.htmlOutputTextBox.Name = "htmlOutputTextBox";
            this.htmlOutputTextBox.Size = new System.Drawing.Size(776, 313);
            this.htmlOutputTextBox.TabIndex = 6;
            this.htmlOutputTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "HTML output of WebPage:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(584, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(171, 87);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(407, 20);
            this.searchTextBox.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(665, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FileOpenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.htmlOutputTextBox);
            this.Controls.Add(this.userInputCode);
            this.Controls.Add(this.userInputFaculty);
            this.Controls.Add(this.lectureCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.facultyCode);
            this.Controls.Add(this.button1);
            this.Name = "FileOpenForm";
            this.Text = "FileOpenForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox facultyCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lectureCode;
        private System.Windows.Forms.Label userInputFaculty;
        private System.Windows.Forms.Label userInputCode;
        private System.Windows.Forms.RichTextBox htmlOutputTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button button3;
    }
}