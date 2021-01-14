namespace WinFormUI
{
    partial class SyllabusForm
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.facultyText = new System.Windows.Forms.TextBox();
            this.codeText = new System.Windows.Forms.TextBox();
            this.addPersonHeader = new System.Windows.Forms.Label();
            this.listPeopleHeader = new System.Windows.Forms.Label();
            this.listSyllabusListBox = new System.Windows.Forms.ListBox();
            this.addSyllabusButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(46, 101);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(89, 29);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "Faculty";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(46, 190);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(72, 29);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Code";
            // 
            // facultyText
            // 
            this.facultyText.Location = new System.Drawing.Point(52, 137);
            this.facultyText.Name = "facultyText";
            this.facultyText.Size = new System.Drawing.Size(234, 35);
            this.facultyText.TabIndex = 2;
            // 
            // codeText
            // 
            this.codeText.Location = new System.Drawing.Point(52, 226);
            this.codeText.Name = "codeText";
            this.codeText.Size = new System.Drawing.Size(234, 35);
            this.codeText.TabIndex = 3;
            // 
            // addPersonHeader
            // 
            this.addPersonHeader.AutoSize = true;
            this.addPersonHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPersonHeader.Location = new System.Drawing.Point(32, 42);
            this.addPersonHeader.Name = "addPersonHeader";
            this.addPersonHeader.Size = new System.Drawing.Size(231, 39);
            this.addPersonHeader.TabIndex = 4;
            this.addPersonHeader.Text = "Add Syllabus";
            // 
            // listPeopleHeader
            // 
            this.listPeopleHeader.AutoSize = true;
            this.listPeopleHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPeopleHeader.Location = new System.Drawing.Point(380, 42);
            this.listPeopleHeader.Name = "listPeopleHeader";
            this.listPeopleHeader.Size = new System.Drawing.Size(226, 39);
            this.listPeopleHeader.TabIndex = 5;
            this.listPeopleHeader.Text = "List Syllabus";
            // 
            // listSyllabusListBox
            // 
            this.listSyllabusListBox.FormattingEnabled = true;
            this.listSyllabusListBox.ItemHeight = 29;
            this.listSyllabusListBox.Location = new System.Drawing.Point(388, 107);
            this.listSyllabusListBox.Name = "listSyllabusListBox";
            this.listSyllabusListBox.Size = new System.Drawing.Size(332, 352);
            this.listSyllabusListBox.TabIndex = 6;
            // 
            // addSyllabusButton
            // 
            this.addSyllabusButton.Location = new System.Drawing.Point(52, 300);
            this.addSyllabusButton.Name = "addSyllabusButton";
            this.addSyllabusButton.Size = new System.Drawing.Size(234, 69);
            this.addSyllabusButton.TabIndex = 7;
            this.addSyllabusButton.Text = "Add Syllabus";
            this.addSyllabusButton.UseVisualStyleBackColor = true;
            this.addSyllabusButton.Click += new System.EventHandler(this.AddSyllabusButton_Click);
            // 
            // SyllabusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 492);
            this.Controls.Add(this.addSyllabusButton);
            this.Controls.Add(this.listSyllabusListBox);
            this.Controls.Add(this.listPeopleHeader);
            this.Controls.Add(this.addPersonHeader);
            this.Controls.Add(this.codeText);
            this.Controls.Add(this.facultyText);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "SyllabusForm";
            this.Text = "Export";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox facultyText;
        private System.Windows.Forms.TextBox codeText;
        private System.Windows.Forms.Label addPersonHeader;
        private System.Windows.Forms.Label listPeopleHeader;
        private System.Windows.Forms.ListBox listSyllabusListBox;
        private System.Windows.Forms.Button addSyllabusButton;
    }
}

