using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Platform.Questions
{
    internal class Question
    {

        public string Questions { get; set; }
        public Dictionary<int, string> Answers { get; set; }

        public int Answers2 { get; set; }

        public Category Category { get; set; }

        public Question(string questions, Dictionary<int,string> answer, int answer2, Category category)
        {
            Questions = questions;
            Answers = answer;
            Answers2 = answer2;
            this.Category = category;
        }

    }
}
