using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace Quizcoursework
{
    public partial class QuestionEditorForm : Form
    {
        private List<Question> questions = new List<Question>();
        public QuestionEditorForm()
        {
            InitializeComponent();
            LoadFromTextFile();
        }
        private void RefreshList()
        {
            lstQuestions.Items.Clear();
            foreach (var q in questions)
            {
                if (q == null) continue;
                lstQuestions.Items.Add(q.Text); // Display question text
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lstQuestions.SelectedIndex;
            if (index >= 0)
            {
                questions.RemoveAt(index);
                RefreshList();
            }
            SaveToTextFile();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            QuestionForm form = new QuestionForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                questions.Add(form.Result); // Result is a Question object
                RefreshList();
            }
            SaveToTextFile();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = lstQuestions.SelectedIndex;
            if (index >= 0)
            {
                QuestionForm form = new QuestionForm(questions[index]);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    questions[index] = form.Result;
                    RefreshList();
                }
            }
            SaveToTextFile();

        }

        private void lstQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public string filePath = Path.Combine(Application.StartupPath, "questions.txt");

        public void LoadFromTextFile()
        {
            questions.Clear();
            if (!File.Exists(filePath)) return;

            string[] lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length < 2) continue;

                string type = parts[0];
                string text = parts[1];

                if (type == "MCQ" && parts.Length == 7)
                {
                    string[] options = parts.Skip(2).Take(4).ToArray();
                    int correctIndex = int.Parse(parts[6]);
                    questions.Add(new MCQQuestion { Text = text, Options = options, CorrectIndex = correctIndex });
                }
                else if (type == "True/False" && parts.Length == 3)
                {
                    bool isTrue = bool.Parse(parts[2]);
                    questions.Add(new TFQuestion { Text = text, IsTrue = isTrue });
                }
                else if (type == "Open" && parts.Length == 3)
                {
                    string[] answers = parts[2].Split(',').Select(a => a.Trim()).ToArray();
                    questions.Add(new OpenQuestion { Text = text, ValidAnswers = answers });
                }
            }

            RefreshList();
        }

        public void SaveToTextFile()
        {
            var lines = new List<string>();
            foreach (var q in questions)
            {
                if (q is MCQQuestion mcq)
                {
                    lines.Add($"MCQ|{mcq.Text}|{mcq.Options[0]}|{mcq.Options[1]}|{mcq.Options[2]}|{mcq.Options[3]}|{mcq.CorrectIndex}");
                }
                else if (q is TFQuestion tf)
                {
                    lines.Add($"True/False|{tf.Text}|{tf.IsTrue}");
                }
                else if (q is OpenQuestion open)
                {
                    string joinedAnswers = string.Join(",", open.ValidAnswers);
                    lines.Add($"Open|{open.Text}|{joinedAnswers}");
                }
            }

            File.WriteAllLines(filePath, lines);
        }
        public static List<Question> LoadQuestionsFromFile(string filePath)
        {
            var questions = new List<Question>();

            if (!File.Exists(filePath)) return questions;

            string[] lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length < 2) continue;

                string type = parts[0];
                string text = parts[1];

                if (type == "MCQ" && parts.Length == 7)
                {
                    string[] options = parts.Skip(2).Take(4).ToArray();
                    int correctIndex = int.Parse(parts[6]);
                    questions.Add(new MCQQuestion { Text = text, Options = options, CorrectIndex = correctIndex });
                }
                else if (type == "True/False" && parts.Length == 3)
                {
                    bool isTrue = bool.Parse(parts[2]);
                    questions.Add(new TFQuestion { Text = text, IsTrue = isTrue });
                }
                else if (type == "Open" && parts.Length == 3)
                {
                    string[] answers = parts[2].Split(',').Select(a => a.Trim()).ToArray();
                    questions.Add(new OpenQuestion { Text = text, ValidAnswers = answers });
                }
            }

            return questions;
        }


        private void QuestionEditorForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }
    }
}
