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
using System.Reflection;

namespace SyllabusEditor
{

    public partial class Import : Form
    {
        //This code piece can calculate evaluation systems total number and weighting values but it does not work with every courses because of html codes are not proper.
        //So, we ignored it.

        //public int textBoxTotalCalc(string type)
        //{

        //    var textBoxesToSum = new[] { textBox47, textBox48, textBox49, textBox50, textBox51, textBox52, textBox53, textBox54, textBox55, textBox56, textBox57 };

        //    int summation = 0;
        //    if (type == "number")
        //    {
        //      textBoxesToSum = new[] { textBox47, textBox48, textBox49, textBox50, textBox51, textBox52, textBox53, textBox54, textBox55, textBox56, textBox57 };
        //    }
        //    else if (type == "weighting") {

        //      textBoxesToSum = new[] { textBox59, textBox60, textBox61, textBox62, textBox63, textBox64, textBox65, textBox66, textBox67, textBox68, textBox69};

        //    }

        //    foreach (var textbBoxVal in textBoxesToSum) {
        //        if (textbBoxVal.Text.Length > 0)
        //        {
        //            summation += int.Parse(textbBoxVal.Text);
        //        }
        //    }

        //    return summation;

        //}



        public Import()
        {
            InitializeComponent();
        }

        private void ImportSubmit_Click(object sender, EventArgs e)
        {
            String lectureCodeFaculty = LectureCodeFaculty.Text;
            String lectureCodeNumber = LectureCodeNumber.Text;
            String languageOfCourse = LanguageComboBox.SelectedItem.ToString();

            if (LanguageComboBox.SelectedIndex == 0)
            {
                languageOfCourse = "en";
            }
            else
            {
                languageOfCourse = "tr";
            }





            var url = "https://ce.ieu.edu.tr/" + languageOfCourse + "/syllabus/type/read/id/" + lectureCodeFaculty + "+" + lectureCodeNumber;
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





            var labelArray = new[] { label1, label2, label3, label4, label5, label6, label7 };
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
                    labelArray[tableoneLChk - 1].Text = element.Trim();
                }
                tableOneLCtr++;
                tableoneLChk++;
                if (tableoneLChk == 9)
                    break;
            }


            int tableOneTCtr = 0;
            int tableOneTChk = 0;
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


            int tableSixCtr = 0;
            int tableSixTest = 1;
            int tableSixChk = 0;
            int tableSixChkSec = 0;
            int tableSixTestSec = 0;
            int tableSixTestThird = 0;
            int tableSixChkThird = 0;

            var inputArray = new[] { label24, label25, label26, label27, label28, label29, label30, label31, label32, label33, label34, label35, label36, label37, label38, label39, label40 };
            var inputTextArray = new[] { textBox15, textBox16, textBox17, textBox18, textBox19, textBox20, textBox21, textBox22, textBox23, textBox24, textBox25, textBox26, textBox27, textBox28, textBox29, textBox30 };
            var inputTextArraySec = new[] { textBox31, textBox32, textBox33, textBox34, textBox35, textBox36, textBox37, textBox38, textBox39, textBox40, textBox41, textBox42, textBox43, textBox44, textBox45, textBox46 };


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
                        if (tableSixTestThird == 0)
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




            int tableEightCtr = 0;
            int tableEightTest = 0;
            int tableEightTestSec = 0;
            int tableEightChk = 0;
            int tableEightChkSec = 0;
            int tableEightChkThird = 0;
            int tableEightTestThird = 0;


            var labelArrayTableEight = new[] { label45, label46, label47, label48, label49, label50, label51, label52, label53, label54, label55, label56, label57 };
            var textboxArrayTableEight = new[] { textBox47, textBox48, textBox49, textBox50, textBox51, textBox52, textBox53, textBox54, textBox55, textBox56, textBox57, textBox58 };
            var textboxArrayTableEightSec = new[] { textBox59, textBox60, textBox61, textBox62, textBox63, textBox64, textBox65, textBox66, textBox67, textBox68, textBox69, textBox70 };

            foreach (var tableEight in HTMLTableList)
            {

                string element = tableEight.Cell_Text.ToString().Replace("&uuml;", "ü").Replace("&nbsp;", string.Empty).Replace("&ouml;", "ö");
                tableEightCtr++;

                if (tableEightCtr > 102)
                {
                    if (tableEightTest == 0)
                    {
                        labelArrayTableEight[tableEightChk].Text = element.Trim();
                        tableEightTest++;
                        tableEightChk++;
                        continue;
                    }
                    if (tableEightTest == 1)
                    {
                        if (tableEightTestSec == 0)
                        {
                            label58.Text = element.Trim();
                            tableEightTestSec++;
                            tableEightTest++;
                            continue;
                        }
                        textboxArrayTableEight[tableEightChkSec].Text = element.Trim();
                        tableEightChkSec++;
                        tableEightTest++;
                        continue;
                    }
                    if (tableEightTest == 2)
                    {
                        if (tableEightTestThird == 0)
                        {
                            label59.Text = element.Trim();
                            tableEightTestThird++;
                            tableEightTest = 0;
                            continue;
                        }
                        textboxArrayTableEightSec[tableEightChkThird].Text = element.Trim();
                        tableEightChkThird++;
                        tableEightTest = 0;
                    }
                }
                if (tableEightCtr == 141)
                    break;



            }

            //textBox70.Text = textBoxTotalCalc("weighting").ToString();
            //textBox58.Text = textBoxTotalCalc("number").ToString();

        }

        private void Import_Load(object sender, EventArgs e)
        {
            LanguageComboBox.SelectedIndex = 0;
            WindowState = FormWindowState.Maximized;
            textBox58.Enabled = false;
            textBox70.Enabled = false;
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

        private void ExportTxtButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (Stream save = File.Open(saveFileDialog.FileName, FileMode.OpenOrCreate))
                using (StreamWriter streamWriter = new StreamWriter(save))
                {
                    String languageOfCourse = LanguageComboBox.SelectedItem.ToString();
                    if (LanguageComboBox.SelectedIndex == 0)
                    {
                        languageOfCourse = "en";
                        streamWriter.Write("Course Name: " + textBox1.Text + "\n" + "Code: " + textBox2.Text + "\n" + "Semester: " + textBox3.Text
                        + "\n" + "Theory(hour/week): " + textBox4.Text + "\n" + "Application/Lab(hour/week): " + textBox5.Text + "\n" + "Local Credits: " + textBox6.Text + "\n" + "ECTS: " + textBox7.Text + "\n"
                        + "\n" + "Prerequisites: " + textBox8.Text + "\n" + "Course Language: " + textBox9.Text + "\n" + "Course Type: " + textBox10.Text + "\n" + "Course Level: " + textBox11.Text + "\n" + "Course Coordinator: " + textBox12.Text
                        + "\n" + "Course Lecturer(s): " + textBox13.Text + "\n" + "Assistant(s): " + textBox14.Text);
                    }
                    else
                    {
                        languageOfCourse = "tr";
                        streamWriter.Write("Dersin adı: " + textBox1.Text + "\n" + "Dersin Kodu: " + textBox2.Text + "\n" + "Dersin Yarı Yılı: " + textBox3.Text
                        + "\n" + "Teori (saat/hafta): " + textBox4.Text + "\n" + "Uygulama/Lab (saat/hafta):" + textBox5.Text + "\n" + "Yerel kredi: " + textBox6.Text + "\n" + "AKTS: " + textBox7.Text + "\n"
                        + "\n" + "Ön-Koşul(lar): " + textBox8.Text + "\n" + "Dersin Dili: " + textBox9.Text + "\n" + "Dersin Türü: " + textBox10.Text + "\n" + "Dersin Düzeyi: " + textBox11.Text + "\n" + "Dersin Koordinatörü: " + textBox12.Text
                        + "\n" + "Öğretim Eleman(lar)'ı :" + textBox13.Text + "\n" + "Yardımcı(ları): " + textBox14.Text);
                    }


                }
            }
        }

        private void ExportHtmlButton_Click(object sender, EventArgs e)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            const string trSyllabusHTML = "SyllabusEditor.Files.trDefaultSyllabus.html";
            const string enSyllabusHTML = "SyllabusEditor.Files.enDefaultSyllabus.html";

            string courseNameWord = "";
            string courseCodeWord = "";
            string courseSemesterWord = "";
            string courseAppHoursWord = "";
            string courseWeeklyHourWord = "";
            string courseIEUCredit = "";
            string courseECTSCredit = "";
            string coursePrereq = "";


            String languageOfCourse = LanguageComboBox.SelectedItem.ToString();
            if (LanguageComboBox.SelectedIndex == 0)
            {
                languageOfCourse = "en";
                using (Stream stream = asm.GetManifestResourceStream(enSyllabusHTML))
                {

                    using (StreamReader reader = new StreamReader(stream))
                    {
                        MainHTMLTxtBox.Text = reader.ReadToEnd();
                    }
                }
                var document2 = new HtmlAgilityPack.HtmlDocument();
                document2.LoadHtml(MainHTMLTxtBox.Text);

                var words = document2.DocumentNode?.SelectNodes("//*[@id='course_name']")?.Select(x => x.InnerText);
                courseNameWord += words != null ? string.Join(" ", words) : String.Empty;
                defaultTxtBox.Text = courseNameWord.Trim();
                string html = MainHTMLTxtBox.Text;
                string yHtml = "";
                yHtml = html.Replace(defaultTxtBox.Text, textBox1.Text);
                MainHTMLTxtBox.Text = yHtml;

                words = document2.DocumentNode?.SelectNodes("//*[@id='course_code']")?.Select(x => x.InnerText);
                courseCodeWord += words != null ? string.Join(" ", words) : String.Empty;
                defaultTxtBox.Text = courseCodeWord.Trim();
                yHtml = yHtml.Replace(defaultTxtBox.Text, textBox2.Text);
                MainHTMLTxtBox.Text = yHtml;

                words = document2.DocumentNode?.SelectNodes("//*[@id='semester']")?.Select(x => x.InnerText);
                courseSemesterWord += words != null ? string.Join(" ", words) : String.Empty;
                defaultTxtBox.Text = courseSemesterWord.Trim();
                yHtml = yHtml.Replace(defaultTxtBox.Text, textBox3.Text);
                MainHTMLTxtBox.Text = yHtml;

                words = document2.DocumentNode?.SelectNodes("//*[@id='weekly_hours']")?.Select(x => x.InnerText);
                courseWeeklyHourWord += words != null ? string.Join(" ", words) : String.Empty;
                defaultTxtBox.Text = courseWeeklyHourWord.Trim();
                yHtml = yHtml.Replace(defaultTxtBox.Text, textBox4.Text);
                MainHTMLTxtBox.Text = yHtml;

                words = document2.DocumentNode?.SelectNodes("//*[@id='app_hours']")?.Select(x => x.InnerText);
                courseAppHoursWord += words != null ? string.Join(" ", words) : String.Empty;
                defaultTxtBox.Text = courseAppHoursWord.Trim();
                yHtml = yHtml.Replace(defaultTxtBox.Text, textBox5.Text);
                MainHTMLTxtBox.Text = yHtml;

                words = document2.DocumentNode?.SelectNodes("//*[@id='ieu_credit']")?.Select(x => x.InnerText);
                courseIEUCredit += words != null ? string.Join(" ", words) : String.Empty;
                defaultTxtBox.Text = courseIEUCredit.Trim();
                yHtml = yHtml.Replace(defaultTxtBox.Text, textBox6.Text);
                MainHTMLTxtBox.Text = yHtml;

                words = document2.DocumentNode?.SelectNodes("//*[@id='ects_credit']")?.Select(x => x.InnerText);
                courseECTSCredit += words != null ? string.Join(" ", words) : String.Empty;
                defaultTxtBox.Text = courseECTSCredit.Trim();
                yHtml = yHtml.Replace(defaultTxtBox.Text, textBox7.Text);
                MainHTMLTxtBox.Text = yHtml;

                words = document2.DocumentNode?.SelectNodes("//*[@id='pre_requisites']")?.Select(x => x.InnerText);
                coursePrereq += words != null ? string.Join(" ", words) : String.Empty;
                defaultTxtBox.Text = coursePrereq.Trim();
                yHtml = yHtml.Replace(defaultTxtBox.Text, textBox8.Text);
                MainHTMLTxtBox.Text = yHtml;

                string courseType = "";
                words = document2.DocumentNode?.SelectNodes("//*[@id='course_type']")?.Select(x => x.InnerText);
                courseType += words != null ? string.Join(" ", words) : String.Empty;
                defaultTxtBox.Text = courseType.Trim();
                yHtml = yHtml.Replace(defaultTxtBox.Text, textBox10.Text);
                MainHTMLTxtBox.Text = yHtml;

                string courseLevel = "";
                words = document2.DocumentNode?.SelectNodes("//*[@id='course_level']")?.Select(x => x.InnerText);
                courseLevel += words != null ? string.Join(" ", words) : String.Empty;
                defaultTxtBox.Text = courseLevel.Trim();
                yHtml = yHtml.Replace(defaultTxtBox.Text, textBox11.Text);
                MainHTMLTxtBox.Text = yHtml;

                string coordinatorList = "";
                words = document2.DocumentNode?.SelectNodes("//*[@id='coordinator_list']")?.Select(x => x.InnerText);
                coordinatorList += words != null ? string.Join(" ", words) : String.Empty;
                defaultTxtBox.Text = coordinatorList.Trim();
                yHtml = yHtml.Replace(defaultTxtBox.Text, textBox12.Text);
                MainHTMLTxtBox.Text = yHtml;

                string lecturerList = "";
                words = document2.DocumentNode?.SelectNodes("//*[@id='lecturer_list']")?.Select(x => x.InnerText);
                lecturerList += words != null ? string.Join(" ", words) : String.Empty;
                defaultTxtBox.Text = lecturerList.Trim();
                yHtml = yHtml.Replace(defaultTxtBox.Text, textBox13.Text);
                MainHTMLTxtBox.Text = yHtml;

                string yardimciList = "";
                words = document2.DocumentNode?.SelectNodes("//*[@id='yardimci_list']")?.Select(x => x.InnerText);
                yardimciList += words != null ? string.Join(" ", words) : String.Empty;
                defaultTxtBox.Text = yardimciList.Trim();
                yHtml = yHtml.Replace(defaultTxtBox.Text, textBox14.Text);
                MainHTMLTxtBox.Text = yHtml;

                string dersAmac = "";
                words = document2.DocumentNode?.SelectNodes("//*[@id='dersAmac']")?.Select(x => x.InnerText);
                dersAmac += words != null ? string.Join(" ", words) : String.Empty;
                defaultTxtBox.Text = dersAmac.Trim();
                yHtml = yHtml.Replace(defaultTxtBox.Text, richTextBox1.Text);
                MainHTMLTxtBox.Text = yHtml;

                string outcome = "";
                words = document2.DocumentNode?.SelectNodes("//*[@id='outcome']")?.Select(x => x.InnerText);
                outcome += words != null ? string.Join(" ", words) : String.Empty;
                defaultTxtBox.Text = outcome.Trim();
                yHtml = yHtml.Replace(defaultTxtBox.Text, richTextBox2.Text);
                MainHTMLTxtBox.Text = yHtml;

                string dersTanım = "";
                words = document2.DocumentNode?.SelectNodes("//*[@id='dersTanım']")?.Select(x => x.InnerText);
                dersTanım += words != null ? string.Join(" ", words) : String.Empty;
                defaultTxtBox.Text = dersTanım.Trim();
                yHtml = yHtml.Replace(defaultTxtBox.Text, richTextBox3.Text);
                MainHTMLTxtBox.Text = yHtml;

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (Stream save = File.Open(saveFileDialog.FileName, FileMode.OpenOrCreate))
                    using (StreamWriter streamWriter = new StreamWriter(save))
                    {
                        streamWriter.Write(MainHTMLTxtBox.Text);
                    }
                }
            }
            else
            {
                languageOfCourse = "tr";
                using (Stream stream = asm.GetManifestResourceStream(trSyllabusHTML))
                {

                    using (StreamReader reader = new StreamReader(stream))
                    {
                        MainHTMLTxtBox.Text = reader.ReadToEnd();
                    }
                }
                var document2 = new HtmlAgilityPack.HtmlDocument();
                document2.LoadHtml(MainHTMLTxtBox.Text);

                var words = document2.DocumentNode?.SelectNodes("//*[@id='course_name']")?.Select(x => x.InnerText);
                courseNameWord += words != null ? string.Join(" ", words) : String.Empty;
                defaultTxtBox.Text = courseNameWord.Trim();
                string html = MainHTMLTxtBox.Text;
                string yHtml = "";
                yHtml = html.Replace(defaultTxtBox.Text, textBox1.Text);
                MainHTMLTxtBox.Text = yHtml;

                words = document2.DocumentNode?.SelectNodes("//*[@id='course_code']")?.Select(x => x.InnerText);
                courseCodeWord += words != null ? string.Join(" ", words) : String.Empty;
                defaultTxtBox.Text = courseCodeWord.Trim();
                yHtml = yHtml.Replace(defaultTxtBox.Text, textBox2.Text);
                MainHTMLTxtBox.Text = yHtml;

                words = document2.DocumentNode?.SelectNodes("//*[@id='semester']")?.Select(x => x.InnerText);
                courseSemesterWord += words != null ? string.Join(" ", words) : String.Empty;
                defaultTxtBox.Text = courseSemesterWord.Trim();
                yHtml = yHtml.Replace(defaultTxtBox.Text, textBox3.Text);
                MainHTMLTxtBox.Text = yHtml;

                words = document2.DocumentNode?.SelectNodes("//*[@id='weekly_hours']")?.Select(x => x.InnerText);
                courseWeeklyHourWord += words != null ? string.Join(" ", words) : String.Empty;
                defaultTxtBox.Text = courseWeeklyHourWord.Trim();
                yHtml = yHtml.Replace(defaultTxtBox.Text, textBox4.Text);
                MainHTMLTxtBox.Text = yHtml;

                words = document2.DocumentNode?.SelectNodes("//*[@id='app_hours']")?.Select(x => x.InnerText);
                courseAppHoursWord += words != null ? string.Join(" ", words) : String.Empty;
                defaultTxtBox.Text = courseAppHoursWord.Trim();
                yHtml = yHtml.Replace(defaultTxtBox.Text, textBox5.Text);
                MainHTMLTxtBox.Text = yHtml;

                words = document2.DocumentNode?.SelectNodes("//*[@id='ieu_credit']")?.Select(x => x.InnerText);
                courseIEUCredit += words != null ? string.Join(" ", words) : String.Empty;
                defaultTxtBox.Text = courseIEUCredit.Trim();
                yHtml = yHtml.Replace(defaultTxtBox.Text, textBox6.Text);
                MainHTMLTxtBox.Text = yHtml;

                words = document2.DocumentNode?.SelectNodes("//*[@id='ects_credit']")?.Select(x => x.InnerText);
                courseECTSCredit += words != null ? string.Join(" ", words) : String.Empty;
                defaultTxtBox.Text = courseECTSCredit.Trim();
                yHtml = yHtml.Replace(defaultTxtBox.Text, textBox7.Text);
                MainHTMLTxtBox.Text = yHtml;

                words = document2.DocumentNode?.SelectNodes("//*[@id='pre_requisites']")?.Select(x => x.InnerText);
                coursePrereq += words != null ? string.Join(" ", words) : String.Empty;
                defaultTxtBox.Text = coursePrereq.Trim();
                yHtml = yHtml.Replace(defaultTxtBox.Text, textBox8.Text);
                MainHTMLTxtBox.Text = yHtml;

                string courseType = "";
                words = document2.DocumentNode?.SelectNodes("//*[@id='course_type']")?.Select(x => x.InnerText);
                courseType += words != null ? string.Join(" ", words) : String.Empty;
                defaultTxtBox.Text = courseType.Trim();
                yHtml = yHtml.Replace(defaultTxtBox.Text, textBox10.Text);
                MainHTMLTxtBox.Text = yHtml;

                string courseLevel = "";
                words = document2.DocumentNode?.SelectNodes("//*[@id='course_level']")?.Select(x => x.InnerText);
                courseLevel += words != null ? string.Join(" ", words) : String.Empty;
                defaultTxtBox.Text = courseLevel.Trim();
                yHtml = yHtml.Replace(defaultTxtBox.Text, textBox11.Text);
                MainHTMLTxtBox.Text = yHtml;

                string coordinatorList = "";
                words = document2.DocumentNode?.SelectNodes("//*[@id='coordinator_list']")?.Select(x => x.InnerText);
                coordinatorList += words != null ? string.Join(" ", words) : String.Empty;
                defaultTxtBox.Text = coordinatorList.Trim();
                yHtml = yHtml.Replace(defaultTxtBox.Text, textBox12.Text);
                MainHTMLTxtBox.Text = yHtml;

                string lecturerList = "";
                words = document2.DocumentNode?.SelectNodes("//*[@id='lecturer_list']")?.Select(x => x.InnerText);
                lecturerList += words != null ? string.Join(" ", words) : String.Empty;
                defaultTxtBox.Text = lecturerList.Trim();
                yHtml = yHtml.Replace(defaultTxtBox.Text, textBox13.Text);
                MainHTMLTxtBox.Text = yHtml;

                string yardimciList = "";
                words = document2.DocumentNode?.SelectNodes("//*[@id='yardimci_list']")?.Select(x => x.InnerText);
                yardimciList += words != null ? string.Join(" ", words) : String.Empty;
                defaultTxtBox.Text = yardimciList.Trim();
                yHtml = yHtml.Replace(defaultTxtBox.Text, textBox14.Text);
                MainHTMLTxtBox.Text = yHtml;

                string dersAmac = "";
                words = document2.DocumentNode?.SelectNodes("//*[@id='dersAmac']")?.Select(x => x.InnerText);
                dersAmac += words != null ? string.Join(" ", words) : String.Empty;
                defaultTxtBox.Text = dersAmac.Trim();
                yHtml = yHtml.Replace(defaultTxtBox.Text, richTextBox1.Text);
                MainHTMLTxtBox.Text = yHtml;

                string outcome = "";
                words = document2.DocumentNode?.SelectNodes("//*[@id='outcome']")?.Select(x => x.InnerText);
                outcome += words != null ? string.Join(" ", words) : String.Empty;
                defaultTxtBox.Text = outcome.Trim();
                yHtml = yHtml.Replace(defaultTxtBox.Text, richTextBox2.Text);
                MainHTMLTxtBox.Text = yHtml;

                string dersTanım = "";
                words = document2.DocumentNode?.SelectNodes("//*[@id='dersTanım']")?.Select(x => x.InnerText);
                dersTanım += words != null ? string.Join(" ", words) : String.Empty;
                defaultTxtBox.Text = dersTanım.Trim();
                yHtml = yHtml.Replace(defaultTxtBox.Text, richTextBox3.Text);
                MainHTMLTxtBox.Text = yHtml;

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (Stream save = File.Open(saveFileDialog.FileName, FileMode.OpenOrCreate))
                    using (StreamWriter streamWriter = new StreamWriter(save))
                    {
                        streamWriter.Write(MainHTMLTxtBox.Text);
                    }
                }
            }
        }

        private void defaultTxtBox_TextChanged(object sender, EventArgs e)
        {

        }


        //This code piece can calculate evaluation systems total number and weighting values but it does not work with every courses because of html codes are not proper.
        //So, we ignored it.
        private void textBox47_TextChanged(object sender, EventArgs e)
        {
            //textBox58.Text = textBoxTotalCalc("number").ToString();
        }

        private void textBox48_TextChanged(object sender, EventArgs e)
        {
            //textBox58.Text = textBoxTotalCalc("number").ToString();
        }

        private void textBox49_TextChanged(object sender, EventArgs e)
        {
            //textBox58.Text = textBoxTotalCalc("number").ToString();
        }

        private void textBox56_TextChanged(object sender, EventArgs e)
        {
            //textBox58.Text = textBoxTotalCalc("number").ToString();
        }

        private void textBox55_TextChanged(object sender, EventArgs e)
        {
            //textBox58.Text = textBoxTotalCalc("number").ToString();

        }

        private void textBox54_TextChanged(object sender, EventArgs e)
        {
            //textBox58.Text = textBoxTotalCalc("number").ToString();
        }

        private void textBox53_TextChanged(object sender, EventArgs e)
        {
            //textBox58.Text = textBoxTotalCalc("number").ToString();
        }

        private void textBox52_TextChanged(object sender, EventArgs e)
        {
            //textBox58.Text = textBoxTotalCalc("number").ToString();
        }

        private void textBox51_TextChanged(object sender, EventArgs e)
        {
            //textBox58.Text = textBoxTotalCalc("number").ToString();
        }

        private void textBox50_TextChanged(object sender, EventArgs e)
        {
            //textBox58.Text = textBoxTotalCalc("number").ToString();
        }

        private void textBox57_TextChanged(object sender, EventArgs e)
        {
            //textBox58.Text = textBoxTotalCalc("number").ToString();

        }

        private void textBox63_TextChanged(object sender, EventArgs e)
        {
            //textBox70.Text = textBoxTotalCalc("weighting").ToString();
        }

        private void textBox68_TextChanged(object sender, EventArgs e)
        {
            //textBox70.Text = textBoxTotalCalc("weighting").ToString();
        }

        private void textBox67_TextChanged(object sender, EventArgs e)
        {
            //textBox70.Text = textBoxTotalCalc("weighting").ToString();
        }

        private void textBox66_TextChanged(object sender, EventArgs e)
        {
            //textBox70.Text = textBoxTotalCalc("weighting").ToString();

        }

        private void textBox65_TextChanged(object sender, EventArgs e)
        {
            //textBox70.Text = textBoxTotalCalc("weighting").ToString();
        }

        private void textBox64_TextChanged(object sender, EventArgs e)
        {
            //textBox70.Text = textBoxTotalCalc("weighting").ToString();
        }

        private void textBox69_TextChanged(object sender, EventArgs e)
        {
            //textBox70.Text = textBoxTotalCalc("weighting").ToString();
        }

        private void textBox62_TextChanged(object sender, EventArgs e)
        {
            //textBox70.Text = textBoxTotalCalc("weighting").ToString();
        }

        private void textBox61_TextChanged(object sender, EventArgs e)
        {
            //textBox70.Text = textBoxTotalCalc("weighting").ToString();
        }

        private void textBox60_TextChanged(object sender, EventArgs e)
        {
            //textBox70.Text = textBoxTotalCalc("weighting").ToString();
        }

        private void textBox59_TextChanged(object sender, EventArgs e)
        {
            //textBox70.Text = textBoxTotalCalc("weighting").ToString();
        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
