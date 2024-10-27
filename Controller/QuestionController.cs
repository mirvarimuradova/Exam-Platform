using Exam_Platform.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Platform.Controller
{
    internal class QuestionController<T>
    {

        public List<Question> Questions { get; set; } = new List<Question>();
        public List<T> Answers { get; set; } = new List<T>();
        public List<T> Answers2 { get; set; } = new List<T>();

        public QuestionController(Question question)
        {
            
            Questions.Add(question);
        }
        public  void AddQuestion(Question question)
        {

        }


    }
}
