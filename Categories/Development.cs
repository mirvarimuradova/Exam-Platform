using Exam_Platform.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Platform.Categories
{
    internal class Development
    {
        public  List<Question> DevelopmentQuestions { get; set; }

        public Development()
        {
            DevelopmentQuestions = new List<Question>();
        }
        public void Add(Question question, int trueanswerID)
        {
            DevelopmentQuestions.Add(question);
        }

    }
}
