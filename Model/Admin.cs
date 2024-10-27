using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Platform.Model
{
    public  class Admin
    {
        public string UserName { get; set; }
        public string Passsword {  get; set; }


        public Admin(string name, string password)
        {
            UserName = name;
            Passsword = password;
        }

        public void CreateUser() { }
        public void SetQuestions() { }
        

    }
}
