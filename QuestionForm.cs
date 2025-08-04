using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizcoursework
{
    public partial class QuestionForm : Form
    {
        public Question Result { get; private set; }
        public string[] Options { get; set; }
        public int CorrectIndex { get; set; }


        public QuestionForm()
        {
            InitializeComponent();
            grpMCQ.Visible = false;
            grpTF.Visible = false;
            grpOpen.Visible = false;
            cmbType.Items.Clear();
            cmbType.Items.AddRange(new string[] { "MCQ", "True/False", "Open" });
            cmbType.SelectedIndexChanged += cmbType_SelectedIndexChanged;
        }
        public QuestionForm(Question existingQuestion) : this()
        {
            txtQuestion.Text = existingQuestion.Text;

            if (existingQuestion is MCQQuestion mcq)
            {
                cmbType.SelectedItem = "MCQ";
                txtOption1.Text = mcq.Options[0];
                txtOption2.Text = mcq.Options[1];
                txtOption3.Text = mcq.Options[2];
                txtOption4.Text = mcq.Options[3];

                if (mcq.CorrectIndex >= 0 && mcq.CorrectIndex < 4)
                {
                    new[] { rbOption1, rbOption2, rbOption3, rbOption4 }[mcq.CorrectIndex].Checked = true;
                }
            }
            else if (existingQuestion is TFQuestion tf)
            {
                cmbType.SelectedItem = "True/False";
                rbTrue.Checked = tf.IsTrue;
                rbFalse.Checked = !tf.IsTrue;
            }
            else if (existingQuestion is OpenQuestion open)
            {
                cmbType.SelectedItem = "Open";
                txtOpenAnswers.Text = string.Join(", ", open.ValidAnswers);
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtQuestion_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cmbType.SelectedItem == null)
            {
                MessageBox.Show("Please select a question type.");
                return;
            }

            string type = cmbType.SelectedItem.ToString();
            string questionText = txtQuestion.Text.Trim();

            if (string.IsNullOrWhiteSpace(questionText))
            {
                MessageBox.Show("Please enter a question.");
                return;
            }

            if (type == "MCQ")
            {
                string[] options = new string[]
                {
                    txtOption1.Text.Trim(),
                    txtOption2.Text.Trim(),
                    txtOption3.Text.Trim(),
                    txtOption4.Text.Trim()
                };

                int correctIndex = rbOption1.Checked ? 0 :
                                   rbOption2.Checked ? 1 :
                                   rbOption3.Checked ? 2 :
                                   rbOption4.Checked ? 3 : -1;

                if (correctIndex == -1)
                {
                    MessageBox.Show("Please select the correct answer.");
                    return;
                }

                Result = new MCQQuestion
                {
                    Text = questionText,
                    Options = options,
                    CorrectIndex = correctIndex
                };
            }
            else if (type == "True/False")
            {
                bool? isTrue = rbTrue.Checked ? true :
                               rbFalse.Checked ? false : (bool?)null;

                if (isTrue == null)
                {
                    MessageBox.Show("Please select True or False.");
                    return;
                }

                Result = new TFQuestion
                {
                    Text = questionText,
                    IsTrue = isTrue.Value
                };
            }
            else if (type == "Open")
            {
                if (string.IsNullOrWhiteSpace(txtOpenAnswers.Text))
                {
                    MessageBox.Show("Please enter at least one valid answer.");
                    return;
                }

                string[] validAnswers = txtOpenAnswers.Text.Split(',')
                                        .Select(x => x.Trim())
                                        .Where(x => !string.IsNullOrWhiteSpace(x))
                                        .ToArray();

                Result = new OpenQuestion
                {
                    Text = questionText,
                    ValidAnswers = validAnswers
                };
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cmbType.SelectedItem?.ToString();

            grpMCQ.Visible = (selected == "MCQ");
            grpTF.Visible = (selected == "True/False");
            grpOpen.Visible = (selected == "Open");

        }
    }
}
