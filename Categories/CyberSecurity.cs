using Exam_Platform.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Platform.Categories
{
    internal class CyberSecurity
    {

         public  List<Question> CyberQuestions { get; set; } = new List<Question>();

        public CyberSecurity(Question question)
        {
            CyberQuestions.Add(question);
        }
        public void Add(Question question)
        { 
           CyberQuestions.Add((Question)question);
        
        }
    }
}
