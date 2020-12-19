using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
