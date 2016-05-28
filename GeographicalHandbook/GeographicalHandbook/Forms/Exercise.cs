using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeographicalHandbook.Classes;
using System.Threading;

namespace GeographicalHandbook
{
    public partial class Exercise : Form
    {
        public Exercise(User curUser)
        {
            InitializeComponent();
            earth = new Earth();
            user = curUser;
            questionIndex = 0;
            radio = new List<Control>();
        }
        
        List<TerritoryObject> testData;
        private Earth earth;
        private int mark;
        private int questionIndex;
        List<Control> radio;
        User user;
        
        private void startBtn_Click(object sender, EventArgs e)
        {
            testData = Methods.GetCountries(numOfQuestion.Value * 2, earth);
            BuildQuestion();
            panel1.Visible = true;
            numOfQuestion.Visible = false;
            trackBarText.Visible = false;
        }
        private void BuildQuestion()
        {
            if (questionIndex <= (testData.Count - 1) / 2)
            {
                questionLabel.Text = string.Format("What is the capital of \n {0}", testData[questionIndex].Name);
                int i;
                int randomValue;
                bool[] selected = new bool[testData.Count];
                Random random = new Random();
                int correct = random.Next(radio.Count);
                radio[correct].Text = testData[questionIndex].Capital;
                selected[questionIndex] = true;
                for (i = 0; i < radio.Count; i++)
                {
                    do
                    {
                        randomValue = random.Next(testData.Count);
                    }
                    while (selected[randomValue]);
                    selected[randomValue] = true;
                    if (i != correct) radio[i].Text = testData[randomValue].Capital;
                }
            }
            else
            {
                if (user != null)
                {
                    user.AddMark(mark, testData.Count / 2);
                    Methods.UpdateUserData(user);
                }
                panel2.Visible = true;
                resultText.Text = string.Format("You get {0} points out of {1}", mark, (testData.Count / 2));
            }
        }
        private void Exercise_Load(object sender, EventArgs e)
        {
            MainForm form = (MainForm)this.Owner;
            earth = form.GetData;
            numOfQuestion.Maximum = earth.AllChildLength / 2;
            foreach (Control cur in panel1.Controls)
            {
                if (cur is RadioButton)
                {
                    radio.Add(cur);
                }
            }
        }
        private void answer_Click(object sender, EventArgs e)
        {
            foreach (RadioButton cur in radio)
            {
                if (cur.Checked)
                {
                    if (cur.Text == testData[questionIndex].Capital) 
                        mark++;
                    cur.Checked = false;
                    questionIndex++;
                    BuildQuestion();
                }
            }
        }
        private void numberOfQuestions_Scroll(object sender, EventArgs e)
        {
            trackBarText.Text = numOfQuestion.Value.ToString();
        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            testData.Clear();
            questionIndex = 0;
            mark = 0;
            panel1.Visible = false;
            panel2.Visible = false;
            numOfQuestion.Visible = true;
            trackBarText.Visible = true;
        }
        private void skipBtn_Click(object sender, EventArgs e)
        {
            questionIndex++;
            foreach (RadioButton cur in radio)
            {
                cur.Checked = false;
            }
            BuildQuestion();
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
    }
}
