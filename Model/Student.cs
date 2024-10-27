using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Platform.Model
{
    public class Student
    {
        private static int _lastId = 0;
        public string UserName { get; set; }
        public int Password { get; set; }

        public Category Category { get; set; }

        public int ID { get; private set; }

        public Student(string username, Category category)
        {
            UserName = username;
            Random random1 = new Random();
            Password = random1.Next(1000, 10000);
            Category = category;
            ID = ++ _lastId;
        }


    }
}
