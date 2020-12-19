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
using Tulpep.NotificationWindow;

namespace SyllabusEditor
{
    public partial class FileNewForm : Form
    {
        public FileNewForm()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            String fileName = openFileDialog1.FileName;
            string readFile = File.ReadAllText(fileName);
            richTextBox1.Text = readFile;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (Stream save = File.Open(saveFileDialog.FileName, FileMode.OpenOrCreate))
                using (StreamWriter streamWriter = new StreamWriter(save))
                {
                    streamWriter.Write(richTextBox1.Text);
                }
                PopupNotifier successPopupNotifier = new PopupNotifier();
                successPopupNotifier.Image = Properties.Resources.Success1;
                successPopupNotifier.TitleText = "Success";
                successPopupNotifier.ContentText = "Successfully Saved";
                successPopupNotifier.Popup();
            }

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                listFiles.Items.Clear();
                string[] files = Directory.GetFiles(folderBrowserDialog.SelectedPath);
                string[] directions = Directory.GetDirectories(folderBrowserDialog.SelectedPath);

                foreach (string file in files)
                {
                    listFiles.Items.Add(file);
                }
                foreach (string direction in directions)
                {
                    listFiles.Items.Add(direction);
                }

            }
        }
    }
}
