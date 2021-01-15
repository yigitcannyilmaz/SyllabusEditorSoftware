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
                tableOneTCtr++;

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


            int tableSixCtr = 0;
            int tableSixTest = 1;
            int tableSixChk = 0;
            int tableSixChkSec = 0;
            int tableSixTestSec = 0;
            int tableSixTestThird = 0;
            int tableSixChkThird = 0;
          
            var inputArray = new[] { label24, label25, label26, label27, label28, label29, label30, label31, label32, label33, label34, label35, label36, label37, label38, label39, label40 };
            var inputTextArray = new[] { textBox15, textBox16, textBox17, textBox18, textBox19, textBox20, textBox21, textBox22, textBox23, textBox24, textBox25, textBox26, textBox27, textBox28, textBox29, textBox30 };
            var inputTextArraySec = new[] {  textBox31, textBox32, textBox33, textBox34, textBox35, textBox36, textBox37, textBox38, textBox39, textBox40, textBox41, textBox42, textBox43, textBox44, textBox45, textBox46 };
            
            
            foreach (var tableSix in HTMLTableList)
            {

                string element = tableSix.Cell_Text.ToString().Replace("&uuml;", "ü").Replace("&nbsp;", string.Empty).Replace("&ouml;", "ö");
                tableSixCtr++;

                if (tableSixCtr >= 48)
                {
                    if (tableSixTest == 1)
                    {
                        inputArray[tableSixChk].Text = element.Trim();
                        tableSixTest++;
                        tableSixChk++;
                        continue;
                    }
                    if (tableSixTest == 2)
                    {
                        if (tableSixTestSec == 0)
                        {
                            label41.Text = element.Trim();
                            tableSixTestSec++;
                            tableSixTest++;
                            continue;
                        }
                        inputTextArray[tableSixChkSec].Text = element.Trim();
                        tableSixChkSec++;
                        tableSixTest++;
                        continue;
                    }
                    if (tableSixTest == 3)
                    {
                        if (tableSixTestThird== 0)
                        {
                            label42.Text = element.Trim();
                            tableSixTestThird++;
                            tableSixTest = 1;
                            continue;
                        }
                        inputTextArraySec[tableSixChkThird].Text = element.Trim();
                        tableSixChkThird++;
                        tableSixTest = 1;
                    }
                }
                if (tableSixCtr == 98)
                    break;
            }


            var newlabelList = new[] { label43, label44 };
            var newtextList = new[] { richTextBox4, richTextBox5 };

            int tableSevenChk = 0;
            int tableSevenCtr = 0;

            foreach (var newtable in HTMLTableList)
            {
                string element = newtable.Cell_Text.ToString().Replace("&uuml;", "ü").Replace("&nbsp;", string.Empty).Replace("&ouml;", "ö");
                tableSevenCtr++;
                if (tableSevenCtr > 98)
                {

                    if (tableSevenCtr % 2 == 1)
                    { 
                        newlabelList[tableSevenChk].Text = element.Trim();
                    }
                    else
                    {
                        newtextList[tableSevenChk].Text = element.Trim();
                        tableSevenChk++;
                    }
                    if (tableSevenChk > 1)
                    {
                        break;
                    }
                }
            }










        }







        private void Import_Load(object sender, EventArgs e)
        {
            LanguageComboBox.SelectedIndex = 0;
            WindowState = FormWindowState.Maximized;
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
