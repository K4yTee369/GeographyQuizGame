using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Quizcoursework
{
    public partial class QuizForm : Form
    {
        private List<Question> quizQuestions;
        private int currentIndex = 0;
        private int score = 0;
        private Stopwatch quizTimer = new Stopwatch();


        public QuizForm(List<Question> questions)
        {
            InitializeComponent();
            quizQuestions = questions ?? new List<Question>();

            quizTimer.Start(); // Start before ShowQuestion

            timer1.Interval = 1000; // 1 second
            timer1.Tick += timer1_Tick;
            timer1.Start();

            ShowQuestion(); // After the timer starts
        }
        private void ShowQuestion()
        {
            if (currentIndex >= quizQuestions.Count)
            {
                quizTimer.Stop();
                TimeSpan timeTaken = quizTimer.Elapsed;

                MessageBox.Show($"Quiz complete! Your score: {score}/{quizQuestions.Count}\nTime taken: {timeTaken:mm\\:ss}",
                    "Quiz Finished");
                this.Close();
                return;
            }

            var q = quizQuestions[currentIndex];
            lblQuestion.Text = q.Text;

            grpMCQ.Visible = false;
            grpTF.Visible = false;
            grpOpen.Visible = false;

            rbMCQ1.Checked = rbMCQ2.Checked = rbMCQ3.Checked = rbMCQ4.Checked = false;
            rbTrue.Checked = rbFalse.Checked = false;
            txtOpenAnswer.Text = "";

            if (q is MCQQuestion mcq)
            {
                grpMCQ.Visible = true;
                
                rbMCQ1.Text = mcq.Options[0];
                rbMCQ2.Text = mcq.Options[1];
                rbMCQ3.Text = mcq.Options[2];
                rbMCQ4.Text = mcq.Options[3];

                rbMCQ1.Checked = rbMCQ2.Checked = rbMCQ3.Checked = rbMCQ4.Checked = false;
            }
            else if (q is TFQuestion)
            {
                grpTF.Visible = true;

                rbTrue.Checked = rbFalse.Checked = false;
            }
            else if (q is OpenQuestion)
            {
                grpOpen.Visible = true;
                txtOpenAnswer.Visible = true;

                txtOpenAnswer.Text = "";
            }
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            var q = quizQuestions[currentIndex];

            if (q is MCQQuestion mcq)
            {
                int selected = rbMCQ1.Checked ? 0 :
                               rbMCQ2.Checked ? 1 :
                               rbMCQ3.Checked ? 2 :
                               rbMCQ4.Checked ? 3 : -1;

                if (selected == mcq.CorrectIndex)
                    score++;
            }
            else if (q is TFQuestion tf)
            {
                if (rbTrue.Checked == tf.IsTrue)
                    score++;
            }
            else if (q is OpenQuestion open)
            {
                string answer = txtOpenAnswer.Text.Trim();

                if (open.ValidAnswers.Any(a =>
                    string.Equals(a.Trim(), answer, StringComparison.OrdinalIgnoreCase)))
                {
                    score++;
                }
            }

            currentIndex++;
            ShowQuestion();
        }


        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

        private void txtOpenAnswers_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbOption4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void grpOpen_Enter(object sender, EventArgs e)
        {

        }

        private void grpMCQ_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = quizTimer.Elapsed.ToString(@"mm\:ss");
        }

    }
}
