using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class SyllabusForm : Form
    {
        List<SyllabusModel> syllabus = new List<SyllabusModel>();

        public SyllabusForm()
        {
            InitializeComponent();

            LoadSyllabusList();
        }

        private void LoadSyllabusList()
        {
            syllabus = SqliteDataAccess.LoadSyllabusList();

            SyllabusList();
        }

        private void SyllabusList()
        {
            listSyllabusListBox.DataSource = null;
            listSyllabusListBox.DataSource = syllabus;
            listSyllabusListBox.DisplayMember = "FullName";
        }

        private void AddSyllabusButton_Click(object sender, EventArgs e)
        {
            SyllabusModel p = new SyllabusModel
            {
                Faculty = facultyText.Text,
                Code = codeText.Text
            };

            SqliteDataAccess.SaveSyllabus(p);
            LoadSyllabusList();
            facultyText.Text = "";
            codeText.Text = "";
        }
    }
}
