using Exam_Platform.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Platform.Categories
{
    internal class DataScience
    {

        public  List<Question> DataScienceQuestions { get; set; } = new List<Question>();

        public DataScience( Question question)
        {
            DataScienceQuestions.Add(question);
        }
        public void AddDataScience(Question question) 
        { 
          

            DataScienceQuestions.Add(question);
        }
    }
}
