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
    public partial class FileNewForm : Form
    {
        public FileNewForm()
        {
            InitializeComponent();
        }

        private void FileNewForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string courseName = "", code = "", semester = "", theory = "", lab = "", localCredits = "", ECTS = "";
            string prerequisites = "", cLanguage = "", cType = "", cLevel = "", cCoordinator = "", cLecturer = "", asistant = "";
            string cObjectives = "", lOutcomes = "", cDescription = "", cCategory = "";
            string week1Sub = "", week2Sub = "", week3Sub = "", week4Sub = "", week5Sub = "", week6Sub = "", week7Sub = "", week8Sub = "", week9Sub = "", 
                   week10Sub = "", week11Sub = "", week12Sub = "", week13Sub = "", week14Sub = "", week15Sub = "", week16Sub = "";
            string week1RM = "", week2RM = "", week3RM = "", week4RM = "", week5RM = "", week6RM = "", week7RM = "", week8RM = "", week9RM = "", week10RM = "",
                   week11RM = "", week12RM = "", week13RM = "", week14RM = "", week15RM = "", week16RM = "";
            string cNotes = "", materials = "";
            string pNumber = "", lNumber = "", fNumber = "", qNumber = "", hNumber = "", juryNumber = "", projectNumber = "", sNumber = "", oNumber = "", mNumber = "", finalNumber = "", totalNumber = "";
            string pweigthing = "", lweigthing = "", fweigthing = "", qweigthing = "", hweigthing = "", juryweigthing = "", projectweigthing = "", sweigthing = "", oweigthing = "", mweigthing = "", finalweigthing = "", totalweigthing = "";
            string pLO1 = "", lLO1 = "", fLO1 = "", qLO1 = "", hLO1 = "", juryLO1 = "", projectLO1 = "", sLO1 = "", oLO1 = "", mLO1 = "", finalLO1 = "", totalLO1 = "";
            string pLO2 = "", lLO2 = "", fLO2 = "", qLO2 = "", hLO2 = "", juryLO2 = "", projectLO2 = "", sLO2 = "", oLO2 = "", mLO2 = "", finalLO2 = "", totalLO2 = "";
            string pLO3 = "", lLO3 = "", fLO3 = "", qLO3 = "", hLO3 = "", juryLO3 = "", projectLO3 = "", sLO3 = "", oLO3 = "", mLO3 = "", finalLO3 = "", totalLO3 = "";
            string pLO4 = "", lLO4 = "", fLO4 = "", qLO4 = "", hLO4 = "", juryLO4 = "", projectLO4 = "", sLO4 = "", oLO4 = "", mLO4 = "", finalLO4 = "", totalLO4 = "";
            string pLO5 = "", lLO5 = "", fLO5 = "", qLO5 = "", hLO5 = "", juryLO5 = "", projectLO5 = "", sLO5 = "", oLO5 = "", mLO5 = "", finalLO5 = "", totalLO5 = "";
            string pLO6 = "", lLO6 = "", fLO6 = "", qLO6 = "", hLO6 = "", juryLO6 = "", projectLO6 = "", sLO6 = "", oLO6 = "", mLO6 = "", finalLO6 = "", totalLO6 = "";
            string pLO7 = "", lLO7 = "", fLO7 = "", qLO7 = "", hLO7 = "", juryLO7 = "", projectLO7 = "", sLO7 = "", oLO7 = "", mLO7 = "", finalLO7 = "", totalLO7 = "";
            string nfinalGrade = "", wfinalGrade = "", nendFinalGrade = "", wendFinalGrade = "", ntotalGrade = "", wtotalGrade = "";
            string ncourseHours = "", nlabHours = "", nstudyHours = "", nfWork = "", nquiz = "", nhomework = "", npresentation = "", nproject = "", nseminar = "", noralExam = "", nmidterm = "", nfinal = "", total = "";
            string dcourseHours = "", dlabHours = "", dstudyHours = "", dfWork = "", dquiz = "", dhomework = "", dpresentation = "", dproject = "", dseminar = "", doralExam = "", dmidterm = "", dfinal = "";
            string wcourseHours = "", wlabHours = "", wstudyHours = "", wfWork = "", wquiz = "", whomework = "", wpresentation = "", wproject = "", wseminar = "", woralExam = "", wmidterm = "", wfinal = "";
            string Compenticies1 = "", Compenticies2 = "", Compenticies3 = "", Compenticies4 = "", Compenticies5 = "", Compenticies6 = "", Compenticies7 = "", Compenticies8 = "", 
                   Compenticies9 = "", Compenticies10 = "", Compenticies11 = "", Compenticies12 = "", Compenticies13 = "";
            string LO1 = "", LO2 = "", LO3 = "", LO4 = "", LO5 = "", LO6 = "", LO7 = "", LO8 = "", LO9 = "", LO10 = "", LO11 = "", LO12 = "", LO13 = "";

            courseName = name_textBox.Text;
            code = code_textBox.Text;

            if (fall_checkBox.Checked == true)
                semester = semester + "/" + fall_checkBox.Text;

            if (spring_checkBox.Checked == true)
                semester = semester + "/" + spring_checkBox.Text;

            semester = semester.Substring(1);

            theory = theory_textBox.Text;
            lab = lab_textBox.Text;
            localCredits = textBox42.Text;
            ECTS = textBox43.Text;

            label3.Text = courseName;
            label5.Text = code;
            label7.Text = semester;
            label12.Text = theory;
            label13.Text = lab;
            label14.Text = localCredits;
            label15.Text = ECTS;

            prerequisites = textBox1.Text;
            cCoordinator = textBox2.Text;
            cLecturer = textBox3.Text;
            asistant = textBox4.Text;

            if (checkBox1.Checked == true)
                cLanguage = cLanguage + checkBox1.Text;
            if (checkBox2.Checked == true)
                cLanguage = cLanguage + checkBox2.Text;
            if (checkBox3.Checked == true)
                cLanguage = cLanguage + checkBox3.Text;

            if (checkBox4.Checked == true)
                cType = cType + checkBox4.Text;
            if (checkBox5.Checked == true)
                cType = cType + checkBox5.Text;

            if (checkBox6.Checked == true)
                cLevel = cLevel + checkBox6.Text;
            if (checkBox7.Checked == true)
                cLevel = cLevel + checkBox7.Text;
            if (checkBox8.Checked == true)
                cLevel = cLevel + checkBox8.Text;
            if (checkBox9.Checked == true)
                cLevel = cLevel + checkBox9.Text;

            label31.Text = prerequisites;
            label32.Text = cLanguage;
            label33.Text = cType;
            label34.Text = cLevel;
            label56.Text = cCoordinator;
            label57.Text = cLecturer;
            label58.Text = asistant;

            cObjectives = textBox5.Text;
            lOutcomes = textBox6.Text;
            cDescription = textBox7.Text;

            label41.Text = cObjectives;
            label42.Text = lOutcomes;
            label43.Text = cDescription;

            if (checkBox10.Checked == true)
                cCategory = cCategory + checkBox10.Text;
            if (checkBox11.Checked == true)
                cCategory = cCategory + checkBox11.Text;
            if (checkBox12.Checked == true)
                cCategory = cCategory + checkBox12.Text;
            if (checkBox13.Checked == true)
                cCategory = cCategory + checkBox13.Text;
            if (checkBox14.Checked == true)
                cCategory = cCategory + checkBox14.Text;

            label45.Text = cCategory;

            week1Sub = textBox8.Text;
            week2Sub = textBox9.Text;
            week3Sub = textBox10.Text;
            week4Sub = textBox11.Text;
            week5Sub = textBox12.Text;
            week6Sub = textBox13.Text;
            week7Sub = textBox14.Text;
            week8Sub = textBox15.Text;
            week9Sub = textBox16.Text;
            week10Sub = textBox17.Text;
            week11Sub = textBox18.Text;
            week12Sub = textBox19.Text;
            week13Sub = textBox20.Text;
            week14Sub = textBox21.Text;
            week15Sub = textBox22.Text;
            week16Sub = textBox23.Text;

            week1RM = textBox24.Text;
            week2RM = textBox25.Text;
            week3RM = textBox26.Text;
            week4RM = textBox27.Text;
            week5RM = textBox28.Text;
            week6RM = textBox29.Text;
            week7RM = textBox30.Text;
            week8RM = textBox31.Text;
            week9RM = textBox32.Text;
            week10RM = textBox33.Text;
            week11RM = textBox34.Text;
            week12RM = textBox35.Text;
            week13RM = textBox36.Text;
            week14RM = textBox37.Text;
            week15RM = textBox38.Text;
            week16RM = textBox39.Text;

            label70.Text = week1Sub;
            label71.Text = week2Sub;
            label72.Text = week3Sub;
            label73.Text = week4Sub;
            label74.Text = week5Sub;
            label75.Text = week6Sub;
            label76.Text = week7Sub;
            label77.Text = week8Sub;
            label78.Text = week9Sub;
            label79.Text = week10Sub;
            label80.Text = week11Sub;
            label81.Text = week12Sub;
            label82.Text = week13Sub;
            label83.Text = week14Sub;
            label84.Text = week15Sub;
            label85.Text = week16Sub;

            label86.Text = week1RM;
            label87.Text = week2RM;
            label88.Text = week3RM;
            label89.Text = week4RM;
            label90.Text = week5RM;
            label91.Text = week6RM;
            label92.Text = week7RM;
            label93.Text = week8RM;
            label94.Text = week9RM;
            label95.Text = week10RM;
            label96.Text = week11RM;
            label97.Text = week12RM;
            label98.Text = week13RM;
            label99.Text = week14RM;
            label100.Text = week15RM;
            label101.Text = week16RM;

            cNotes = textBox40.Text;
            materials = textBox41.Text;

            label124.Text = cNotes;
            label125.Text = materials;

            pNumber = textBox44.Text;
            lNumber = textBox45.Text;
            fNumber = textBox46.Text;
            qNumber = textBox47.Text;
            hNumber = textBox48.Text;
            juryNumber = textBox49.Text;
            projectNumber = textBox50.Text;
            sNumber = textBox51.Text;
            oNumber = textBox52.Text;
            mNumber = textBox53.Text;
            finalNumber = textBox54.Text;
            totalNumber = textBox143.Text;

            pweigthing = textBox55.Text;
            lweigthing = textBox56.Text;
            fweigthing = textBox57.Text;
            qweigthing = textBox58.Text;
            hweigthing = textBox59.Text;
            juryweigthing = textBox60.Text;
            projectweigthing = textBox61.Text;
            sweigthing = textBox62.Text;
            oweigthing = textBox63.Text;
            mweigthing = textBox64.Text;
            finalweigthing = textBox65.Text;
            totalweigthing = textBox144.Text;

            label182.Text = pNumber;
            label191.Text = lNumber;
            label200.Text = fNumber;
            label209.Text = qNumber;
            label218.Text = hNumber;
            label227.Text = juryNumber;
            label236.Text = projectNumber;
            label245.Text = sNumber;
            label254.Text = oNumber;
            label263.Text = mNumber;
            label272.Text = finalNumber;
            label281.Text = totalNumber;

            label183.Text = pweigthing;
            label192.Text = lweigthing;
            label201.Text = fweigthing;
            label210.Text = qweigthing;
            label219.Text = hweigthing;
            label228.Text = juryweigthing;
            label237.Text = projectweigthing;
            label246.Text = sweigthing;
            label255.Text = oweigthing;
            label264.Text = mweigthing;
            label273.Text = finalweigthing;
            label282.Text = totalweigthing;

            pLO1 = textBox66.Text;
            lLO1 = textBox73.Text;
            fLO1 = textBox80.Text;
            qLO1 = textBox87.Text;
            hLO1 = textBox94.Text;
            juryLO1 = textBox101.Text;
            projectLO1 = textBox108.Text;
            sLO1 = textBox115.Text;
            oLO1 = textBox122.Text;
            mLO1 = textBox129.Text;
            finalLO1 = textBox136.Text;
            totalLO1 = textBox145.Text;

            pLO2 = textBox67.Text;
            lLO2 = textBox74.Text;
            fLO2 = textBox81.Text;
            qLO2 = textBox88.Text;
            hLO2 = textBox95.Text;
            juryLO2 = textBox102.Text;
            projectLO2 = textBox109.Text;
            sLO2 = textBox116.Text;
            oLO2 = textBox123.Text;
            mLO2 = textBox130.Text;
            finalLO2 = textBox137.Text;
            totalLO2 = textBox146.Text;

            pLO3 = textBox68.Text;
            lLO3 = textBox75.Text;
            fLO3 = textBox82.Text;
            qLO3 = textBox89.Text;
            hLO3 = textBox96.Text;
            juryLO3 = textBox103.Text;
            projectLO3 = textBox110.Text;
            sLO3 = textBox117.Text;
            oLO3 = textBox124.Text;
            mLO3 = textBox131.Text;
            finalLO3 = textBox138.Text;
            totalLO3 = textBox147.Text;

            pLO4 = textBox69.Text;
            lLO4 = textBox76.Text;
            fLO4 = textBox83.Text;
            qLO4 = textBox90.Text;
            hLO4 = textBox97.Text;
            juryLO4 = textBox104.Text;
            projectLO4 = textBox111.Text;
            sLO4 = textBox118.Text;
            oLO4 = textBox125.Text;
            mLO4 = textBox132.Text;
            finalLO4 = textBox139.Text;
            totalLO4 = textBox148.Text;

            pLO5 = textBox70.Text;
            lLO5 = textBox77.Text;
            fLO5 = textBox84.Text;
            qLO5 = textBox91.Text;
            hLO5 = textBox98.Text;
            juryLO5 = textBox105.Text;
            projectLO5 = textBox112.Text;
            sLO5 = textBox119.Text;
            oLO5 = textBox126.Text;
            mLO5 = textBox133.Text;
            finalLO5 = textBox140.Text;
            totalLO5 = textBox149.Text;

            pLO6 = textBox71.Text;
            lLO6 = textBox78.Text;
            fLO6 = textBox85.Text;
            qLO6 = textBox92.Text;
            hLO6 = textBox99.Text;
            juryLO6 = textBox106.Text;
            projectLO6 = textBox113.Text;
            sLO6 = textBox120.Text;
            oLO6 = textBox127.Text;
            mLO6 = textBox134.Text;
            finalLO6 = textBox141.Text;
            totalLO6 = textBox150.Text;

            pLO7 = textBox72.Text;
            lLO7 = textBox79.Text;
            fLO7 = textBox86.Text;
            qLO7 = textBox93.Text;
            hLO7 = textBox100.Text;
            juryLO7 = textBox107.Text;
            projectLO7 = textBox114.Text;
            sLO7 = textBox121.Text;
            oLO7 = textBox128.Text;
            mLO7 = textBox135.Text;
            finalLO7 = textBox142.Text;
            totalLO7 = textBox151.Text;

            label184.Text = pLO1;
            label193.Text = lLO1;
            label202.Text = fLO1;
            label211.Text = qLO1;
            label220.Text = hLO1;
            label229.Text = juryLO1;
            label238.Text = projectLO1;
            label247.Text = sLO1;
            label256.Text = oLO1;
            label265.Text = mLO1;
            label274.Text = finalLO1;
            label283.Text = totalLO1;

            label185.Text = pLO2;
            label194.Text = lLO2;
            label203.Text = fLO2;
            label212.Text = qLO2;
            label221.Text = hLO2;
            label230.Text = juryLO2;
            label239.Text = projectLO2;
            label248.Text = sLO2;
            label257.Text = oLO2;
            label266.Text = mLO2;
            label275.Text = finalLO2;
            label284.Text = totalLO2;

            label186.Text = pLO3;
            label195.Text = lLO3;
            label204.Text = fLO3;
            label213.Text = qLO3;
            label222.Text = hLO3;
            label231.Text = juryLO3;
            label240.Text = projectLO3;
            label249.Text = sLO3;
            label258.Text = oLO3;
            label267.Text = mLO3;
            label276.Text = finalLO3;
            label285.Text = totalLO3;

            label187.Text = pLO4;
            label196.Text = lLO4;
            label205.Text = fLO4;
            label214.Text = qLO4;
            label223.Text = hLO4;
            label232.Text = juryLO4;
            label241.Text = projectLO4;
            label250.Text = sLO4;
            label259.Text = oLO4;
            label268.Text = mLO4;
            label277.Text = finalLO4;
            label286.Text = totalLO4;

            label188.Text = pLO5;
            label197.Text = lLO5;
            label206.Text = fLO5;
            label215.Text = qLO5;
            label224.Text = hLO5;
            label233.Text = juryLO5;
            label242.Text = projectLO5;
            label251.Text = sLO5;
            label260.Text = oLO5;
            label269.Text = mLO5;
            label278.Text = finalLO5;
            label287.Text = totalLO5;

            label189.Text = pLO6;
            label198.Text = lLO6;
            label207.Text = fLO6;
            label216.Text = qLO6;
            label225.Text = hLO6;
            label234.Text = juryLO6;
            label243.Text = projectLO6;
            label252.Text = sLO6;
            label261.Text = oLO6;
            label270.Text = mLO6;
            label279.Text = finalLO6;
            label288.Text = totalLO6;

            label190.Text = pLO7;
            label199.Text = lLO7;
            label208.Text = fLO7;
            label217.Text = qLO7;
            label226.Text = hLO7;
            label235.Text = juryLO7;
            label244.Text = projectLO7;
            label253.Text = sLO7;
            label262.Text = oLO7;
            label271.Text = mLO7;
            label280.Text = finalLO7;
            label289.Text = totalLO7;

            nfinalGrade = textBox152.Text;
            wfinalGrade = textBox153.Text;
            nendFinalGrade = textBox154.Text;
            wendFinalGrade = textBox155.Text;
            ntotalGrade = textBox156.Text;
            wtotalGrade = textBox157.Text;

            ncourseHours = textBox158.Text;
            nlabHours = textBox159.Text;
            nstudyHours = textBox160.Text;
            nfWork = textBox161.Text;
            nquiz = textBox162.Text;
            nhomework = textBox163.Text;
            npresentation = textBox164.Text;
            nproject = textBox165.Text;
            nseminar = textBox166.Text;
            noralExam = textBox167.Text;
            nmidterm = textBox168.Text;
            nfinal = textBox169.Text;

            dcourseHours = textBox170.Text;
            dlabHours = textBox171.Text;
            dstudyHours = textBox172.Text;
            dfWork = textBox173.Text;
            dquiz = textBox174.Text;
            dhomework = textBox175.Text;
            dpresentation = textBox176.Text;
            dproject = textBox177.Text;
            dseminar = textBox178.Text;
            doralExam = textBox179.Text;
            dmidterm = textBox180.Text;
            dfinal = textBox181.Text;

            wcourseHours = textBox182.Text;
            wlabHours = textBox183.Text;
            wstudyHours = textBox184.Text;
            wfWork = textBox185.Text;
            wquiz = textBox186.Text;
            whomework = textBox187.Text;
            wpresentation = textBox188.Text;
            wproject = textBox189.Text;
            wseminar = textBox190.Text;
            woralExam = textBox191.Text;
            wmidterm = textBox192.Text;
            wfinal = textBox193.Text;

            total = textBox194.Text;

            label314.Text = ncourseHours;
            label317.Text = nlabHours;
            label320.Text = nstudyHours;
            label323.Text = nfWork;
            label326.Text = nquiz;
            label329.Text = nhomework;
            label332.Text = npresentation;
            label335.Text = nproject;
            label338.Text = nseminar;
            label341.Text = noralExam;
            label344.Text = nmidterm;
            label347.Text = nfinal;

            label315.Text = dcourseHours;
            label318.Text = dlabHours;
            label321.Text = dstudyHours;
            label324.Text = dfWork;
            label327.Text = dquiz;
            label330.Text = dhomework;
            label333.Text = dpresentation;
            label336.Text = dproject;
            label339.Text = dseminar;
            label342.Text = doralExam;
            label345.Text = dmidterm;
            label348.Text = dfinal;

            label316.Text = wcourseHours;
            label319.Text = wlabHours;
            label322.Text = wstudyHours;
            label325.Text = wfWork;
            label328.Text = wquiz;
            label331.Text = whomework;
            label334.Text = wpresentation;
            label337.Text = wproject;
            label340.Text = wseminar;
            label343.Text = woralExam;
            label346.Text = wmidterm;
            label349.Text = wfinal;

            label350.Text = total;

            Compenticies1 = textBox208.Text;
            Compenticies2 = textBox209.Text;
            Compenticies3 = textBox210.Text;
            Compenticies4 = textBox211.Text;
            Compenticies5 = textBox212.Text;
            Compenticies6 = textBox213.Text;
            Compenticies7 = textBox214.Text;
            Compenticies8 = textBox215.Text;
            Compenticies9 = textBox216.Text;
            Compenticies10 = textBox217.Text;
            Compenticies11 = textBox218.Text;
            Compenticies12 = textBox219.Text;
            Compenticies13 = textBox220.Text;

            LO1 = textBox195.Text;
            LO2 = textBox196.Text;
            LO3 = textBox197.Text;
            LO4 = textBox198.Text;
            LO5 = textBox199.Text;
            LO6 = textBox200.Text;
            LO7 = textBox201.Text;
            LO8 = textBox202.Text;
            LO9 = textBox203.Text;
            LO10 = textBox204.Text;
            LO11 = textBox205.Text;
            LO12 = textBox206.Text;
            LO13 = textBox207.Text;

            label431.Text = Compenticies1;
            label433.Text = Compenticies2;
            label435.Text = Compenticies3;
            label437.Text = Compenticies4;
            label439.Text = Compenticies5;
            label441.Text = Compenticies6;
            label443.Text = Compenticies7;
            label445.Text = Compenticies8;
            label447.Text = Compenticies9;
            label449.Text = Compenticies10;
            label451.Text = Compenticies11;
            label453.Text = Compenticies12;
            label455.Text = Compenticies13;

            label432.Text = LO1;
            label434.Text = LO2;
            label436.Text = LO3;
            label438.Text = LO4;
            label440.Text = LO5;
            label442.Text = LO6;
            label444.Text = LO7;
            label446.Text = LO8;
            label448.Text = LO9;
            label450.Text = LO10;
            label452.Text = LO11;
            label454.Text = LO12;
            label456.Text = LO13;

        }

    }
}
