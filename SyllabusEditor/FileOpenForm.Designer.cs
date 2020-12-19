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
            // FileOpenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}