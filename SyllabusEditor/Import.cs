using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net;
using System.IO;


namespace SyllabusEditor
{
    public partial class Import : Form
    {
        public Import()
        {
            InitializeComponent();
        }

        private void ImportSubmit_Click(object sender, EventArgs e)
        {
            String lectureCodeFaculty = LectureCodeFaculty.Text;
            String lectureCodeNumber = LectureCodeNumber.Text;
            String languageOfCourse = LanguageComboBox.SelectedItem.ToString() ;

            if (LanguageComboBox.SelectedIndex == 0)
            {
                languageOfCourse = "en";
            }
            else {
                languageOfCourse = "tr";
            }



          

            var url = "https://ce.ieu.edu.tr/"+languageOfCourse+"/syllabus/type/read/id/"+lectureCodeFaculty+"+"+lectureCodeNumber;
            var page = new WebClient();
            page.Encoding = Encoding.GetEncoding("utf-8");
            var htmlData = page.DownloadString(url);
            var htmlDoc = new HtmlAgilityPack.HtmlDocument();
            htmlDoc.LoadHtml(htmlData);

           /* WebRequest connectionRequest = HttpWebRequest.Create(url);
            WebResponse reqResponse = connectionRequest.GetResponse();
            StreamReader readResponse = new StreamReader(reqResponse.GetResponseStream());
            string sourceCode= readResponse.ReadToEnd();
            string[] codePiece = sourceCode.Split(new[] { "<td" }, StringSplitOptions.None);*/

           
            
            
            var HTMLTableList = from table in htmlDoc.DocumentNode.SelectNodes("//table").Cast<HtmlNode>()
                                from row in table.SelectNodes("//tr").Cast<HtmlNode>()
                                from cell in row.SelectNodes("th|td").Cast<HtmlNode>()
                                    //from strongcell in cell.SelectNodes("//strong").Cast<HtmlNode>()
                                select new { /*strontText = strongcell.InnerText*/ Cell_Text = cell.InnerText, Cell_tag = cell.ParentNode.XPath.Substring(cell.ParentNode.XPath.Length - 6, 6) };


            


            var labelArray = new[] { label1, label2, label3, label4, label5, label6,label7 };
            var textboxArray = new[] { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7 };

            var labelArrayTwo = new[] { label8, label9, label10, label11, label12, label13, label14 };
            var textboxArrayTwo = new[] { textBox8, textBox9, textBox10, textBox11, textBox12, textBox13, textBox14 };

            var labelArrayThree = new[] { label15, label16, label17 };
            var textboxArrayThree = new[] { richTextBox1, richTextBox2, richTextBox3 };
            
            var labelArrayFour = new[] { label18, label19, label20, label21, label22, label23 };
            var checkboxArray = new[] { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5 };





            int tableOneLCtr = 0;
            int tableoneLChk = 0;
            foreach (var tableOneL in HTMLTableList)
            {
                string element = tableOneL.Cell_Text.ToString().Replace("&uuml;", "ü").Replace("&nbsp;", string.Empty).Replace("&ouml;", "ö");
                if (tableOneLCtr < 1)
                {
                    labelArray[tableoneLChk].Text = element.Trim();
                }
                if (tableOneLCtr >= 2 && tableOneLCtr <= 7)
                {
                    labelArray[tableoneLChk - 1].Text = element.Trim();
                }
                if (tableOneLCtr > 13)
                {
                    labelArray[tableoneLChk - 1].Text = element.Trim() ;
                }
                tableOneLCtr++;
                tableoneLChk++;
                if (tableoneLChk == 9)
                    break;
            }


            int tableOneTCtr = 0;
            int tableOneTChk= 0;
            foreach (var tableOneT in HTMLTableList)
            {
                string element = tableOneT.Cell_Text.ToString().Replace("&uuml;", "ü").Replace("&nbsp;", string.Empty).Replace("&ouml;", "ö");
                if (tableOneTCtr == 1)
                {
                    textboxArray[tableOneTChk].Text = element.Trim();
                    tableOneTChk++;
                }
                if (tableOneTCtr > 7 && tableOneTCtr < 14)
                {
                    textboxArray[tableOneTChk].Text = element.Trim();
                    tableOneTChk++;
                }
                tableOneTCtr++;
                if (tableOneTChk == 9)
                    break;
            }



            int tableTwoChk = 0;
            int tableTwoCtr = 0;
            foreach (var tableTwo in HTMLTableList)
            {
                string element = tableTwo.Cell_Text.ToString().Replace("&uuml;", "ü").Replace("&nbsp;", string.Empty).Replace("&ouml;", "ö");
                tableTwoCtr++;
                if (tableTwoCtr > 14 && tableTwoCtr <= 17)
                {
                    if (tableTwoCtr % 2 == 1)
                    {
                        labelArrayTwo[tableTwoChk].Text = element.Trim();
                    }
                    else
                    {
                        textboxArrayTwo[tableTwoChk].Text = element.Trim();
                        tableTwoChk++;
                    }
                }
                if (tableTwoCtr > 18)
                {
                    if (tableTwoCtr % 2 == 1)
                    {
                        labelArrayTwo[tableTwoChk].Text = element.Trim();
                    }
                    else
                    {
                        textboxArrayTwo[tableTwoChk].Text = element.Trim();
                        tableTwoChk++;
                    }
                }
                if (tableTwoChk == 7)
                {
                    break;
                }
            }


            int tableThreeCtr = 0;
            int tableThreeChk = 0;


            foreach (var tableThree in HTMLTableList)
            {
                string element = tableThree.Cell_Text.ToString().Replace("&uuml;", "ü").Replace("&nbsp;", string.Empty).Replace("&ouml;", "ö");
                tableThreeCtr++;
                if (tableThreeCtr > 30)
                {
                    if (tableThreeCtr % 2 == 1)
                    {
                        labelArrayThree[tableThreeChk].Text = element.Trim();
                    }
                    else
                    {
                        textboxArrayThree[tableThreeChk].Text = element.Trim();
                        tableThreeChk++;
                    }
                }
                if (tableThreeChk == 3)
                {
                    break;
                }
            }


            int tableFiveChk = 0;
            int tableFiveCtr = 0;


            foreach (var tableFive in HTMLTableList)
            {
                string element = tableFive.Cell_Text.ToString().Replace("&uuml;", "ü").Replace("&nbsp;", string.Empty).Replace("&ouml;", "ö");
                tableFiveCtr++;
                if (tableFiveCtr > 36)
                {

                    int uzunluk = element.Trim().Length;

                    if (tableFiveCtr < 38)
                    {

                        labelArrayFour[tableFiveChk].Text = element.Trim();
                        tableFiveChk++;

                    }
                    else if (tableFiveCtr % 2 == 0)
                    {

                        labelArrayFour[tableFiveChk].Text = element.Trim();
                    }
                    else
                    {
                        if (uzunluk > 0)
                        {
                            checkboxArray[tableFiveChk - 1].Checked = true;
                        }
                        tableFiveChk++;
                    }
                }
                if (tableFiveChk == 6)
                {
                    break;
                }
            }






           

            

        }

        private void Import_Load(object sender, EventArgs e)
        {
            LanguageComboBox.SelectedIndex = 0;
        }
    }
}
