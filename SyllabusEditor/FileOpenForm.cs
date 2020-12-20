using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;


namespace SyllabusEditor
{
    public partial class FileOpenForm : Form
    {
        public FileOpenForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string constantURL = "https://ce.ieu.edu.tr/tr/syllabus/type/read/id/";
            String userInputFaculty = facultyCode.Text;
            String userInputLectureCode = lectureCode.Text;
            string enteredURL = constantURL + userInputFaculty+ "+"+userInputLectureCode ;
            System.Diagnostics.Process.Start(enteredURL);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(enteredURL);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            htmlOutputTextBox.Text = streamReader.ReadToEnd();
            streamReader.Close();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //TO DO get highlighted text and save them DB or txt.
            string[] words = searchTextBox.Text.Split(',');
            foreach (string word in words)
            {
                int startIndex = 0;
                while (startIndex < htmlOutputTextBox.TextLength)
                {
                    int wordStartIndex = htmlOutputTextBox.Find(word,startIndex,RichTextBoxFinds.None);
                    if (wordStartIndex != -1)
                    {
                        htmlOutputTextBox.SelectionStart = wordStartIndex;
                        htmlOutputTextBox.SelectionLength = word.Length;
                        htmlOutputTextBox.SelectionBackColor = Color.Yellow;

                    }
                    else
                    {
                        break;
                    }
                    startIndex += wordStartIndex + word.Length;
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            htmlOutputTextBox.SelectionStart = 0;
            htmlOutputTextBox.SelectAll();
            htmlOutputTextBox.SelectionBackColor = Color.White;

        }
    }
}
