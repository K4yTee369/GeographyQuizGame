using Quizcoursework;
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


namespace Quizcoursework
{
    public partial class MainMenuform : Form
    {
        public MainMenuform()
        {
            InitializeComponent();
        }

        private void MainMenuform_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "questions.txt");
            List<Question> questions = QuestionEditorForm.LoadQuestionsFromFile(filePath);

            if (questions.Count == 0)
            {
                MessageBox.Show("No questions found.");
                return;
            }

            QuizForm quiz = new QuizForm(questions); // ✅ Now works
            quiz.ShowDialog();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreateGame_Click(object sender, EventArgs e)
        {
            QuestionEditorForm editorForm = new QuestionEditorForm();
            editorForm.ShowDialog();
        }
    }
}
