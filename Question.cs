using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizcoursework
{
    public abstract class Question
    {   
        public string Text { get; set; }
        public abstract bool CheckAnswer(string userAnswer);
    }
    public class MCQQuestion : Question
    {
        public string[] Options { get; set; }
        public int CorrectIndex { get; set; }
        public override bool CheckAnswer(string userAnswer)
        {
            return userAnswer == (CorrectIndex + 1).ToString();
        }
    }
    public class TFQuestion : Question
    {
        public bool IsTrue { get; set; }
        public override bool CheckAnswer(string userAnswer)
        {
            return userAnswer.ToLower() == IsTrue.ToString().ToLower();
        }
    }
    public class OpenQuestion : Question
    {
        public string[] ValidAnswers { get; set; }
        public override bool CheckAnswer(string userAnswer)
        {
            return ValidAnswers.Any(a => a.Equals(userAnswer, StringComparison.OrdinalIgnoreCase));
        }
    }
}
