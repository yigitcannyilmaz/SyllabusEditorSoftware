using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyllabusEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileNewForm fileNewForm = new FileNewForm();
            fileNewForm.Show();
            
            
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileOpenForm fileOpenForm = new FileOpenForm();
            fileOpenForm.Show();
        }
    }
}
