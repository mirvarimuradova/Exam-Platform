

using Exam_Platform;
using Exam_Platform.Categories;
using Exam_Platform.Controller;
using Exam_Platform.Model;
using Exam_Platform.Questions;
using Exam_Platform.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;

Dictionary<int, string> answer1 = new Dictionary<int, string>
        {
            { 1, "HTML-də form yaratmaq üçün <form> elementindən istifadə edirik və input ilə məlumatları yığırıq." },
            { 2, "Form yaratmaq üçün yalnız CSS istifadə olunur və məlumatları toplamaq üçün button elementindən istifadə edilir." },
            { 3, "Formları yaratmaq və məlumatları toplamaq üçün yalnız JavaScript-dən istifadə edirik." }
        };

Dictionary<int, string> answer2 = new Dictionary<int, string>
{
    { 1,"A container for storing data values"},
    {2,"A program that performs calculations" },
    {3,"A function that runs automatically" }
};

Dictionary<int,string> answer3 = new Dictionary<int, string>
{
    {1,"int myVariable;" },
    {2," let myVariable;"},
   {3, "declare myVariable;" }
};

Dictionary<int, string> answer4 = new Dictionary<int, string>
{
    {1,"String;" },
    {2,"Int;"},
   {3, "Char;" }
};

Dictionary<int, string> answer5 = new Dictionary<int, string>
{
    {1,"if-else;" },
    {2,"while;"},
    {3, "for;" }
};


Question question1 = new Question(
    "HTML-də formaları necə yaradırıq və form elementləri ilə məlumatları necə toplayırıq?",
      answer1,
       1,
       Category.Developer
       );

Question question2 = new Question(
     "What is a variable in programming?",
     answer2,
      1,
     Category.Developer
    );


Question question3 = new Question(
    " How do you declare a variable in JavaScript?",
    answer3,
    2,
    Category.Developer
    );

Question question4 = new Question(
    " Which data type would you use to store a single character?",
    answer4,
    3,
    Category.Developer
    );

Question question5 = new Question(
    " Which statement is used to check multiple conditions in C#?",
    answer5,
    1,
    Category.Developer
    );


Development DevController = new();
DevController.Add(question1, 1);
 DevController.Add(question2, 1);
DevController.Add(question3, 2);
DevController.Add(question4, 3);
DevController.Add(question5, 1);




Dictionary<int, string> dsAnswer1 = new Dictionary<int, string>
{
    {1, "Cleaning and transforming data to make it usable for analysis."},
    {2, "Using data to generate random predictions without patterns."},
    {3, "Saving data for future use without any changes."}
};

Dictionary<int, string> dsAnswer2 = new Dictionary<int, string>
{
    {1, "An advanced algorithm for linear regression."},
    {2, "A process for grouping similar data points."},
    {3, "A machine learning technique for supervised learning."}
};

Dictionary<int, string> dsAnswer3 = new Dictionary<int, string>
{
    {1, "A programming library for creating visualizations in R."},
    {2, "A Python library for data visualization and analysis."},
    {3, "A tool in Excel for generating charts."}
};

Dictionary<int, string> dsAnswer4 = new Dictionary<int, string>
{
    {1, "To prepare data and visualize results."},
    {2, "To create a storage system for large datasets."},
    {3, "To enhance computer graphics in Python."}
};

Dictionary<int, string> dsAnswer5 = new Dictionary<int, string>
{
    {1, "Mean, median, and standard deviation."},
    {2, "Only the mean of the data set."},
    {3, "Visual plots only, without calculations."}
};

Question dsQuestion1 = new Question(
    "What is data preprocessing?",
    dsAnswer1,
    1,
    Category.DataScience
);

Question dsQuestion2 = new Question(
    "What is clustering in data science?",
    dsAnswer2,
    2,
    Category.DataScience
);

Question dsQuestion3 = new Question(
    "What is Matplotlib used for?",
    dsAnswer3,
    2,
    Category.DataScience
);

Question dsQuestion4 = new Question(
    "Why is Python popular in data science?",
    dsAnswer4,
    1,
    Category.DataScience
);

Question dsQuestion5 = new Question(
    "Which metrics are commonly used to summarize data?",
    dsAnswer5,
    1,
    Category.DataScience
);

DataScience DScience = new DataScience(dsQuestion1);

DScience.AddDataScience(dsQuestion2);
DScience.AddDataScience(dsQuestion3);
DScience.AddDataScience(dsQuestion4);
DScience.AddDataScience(dsQuestion5);


Dictionary<int, string> csAnswer1 = new Dictionary<int, string>
{
    {1, "Malicious software designed to harm or exploit devices."},
    {2, "A type of legal software for security testing."},
    {3, "An advanced data backup tool."}
};

Dictionary<int, string> csAnswer2 = new Dictionary<int, string>
{
    {1, "A strong, unique password for every account."},
    {2, "Using the same password across all accounts for simplicity."},
    {3, "Storing passwords openly on a notepad file."}
};

Dictionary<int, string> csAnswer3 = new Dictionary<int, string>
{
    {1, "A method of data encryption to secure transmissions."},
    {2, "A type of database for storing sensitive information."},
    {3, "A social media protocol for secure sharing."}
};

Dictionary<int, string> csAnswer4 = new Dictionary<int, string>
{
    {1, "An attacker floods a network with excessive data."},
    {2, "An attack that reduces an IP address's value."},
    {3, "A strategy to minimize CPU usage."}
};

Dictionary<int, string> csAnswer5 = new Dictionary<int, string>
{
    {1, "Using a firewall to monitor and control network traffic."},
    {2, "Allowing all traffic to reduce security risks."},
    {3, "Using VPN only on private networks."}
};

Question csQuestion1 = new Question(
    "What is malware?",
    csAnswer1,
    1,
    Category.Cybersecurity
);

Question csQuestion2 = new Question(
    "What is a good password practice?",
    csAnswer2,
    1,
    Category.Cybersecurity
);

Question csQuestion3 = new Question(
    "What is HTTPS used for?",
    csAnswer3,
    1,
    Category.Cybersecurity
);

Question csQuestion4 = new Question(
    "What is a DDoS attack?",
    csAnswer4,
    1,
    Category.Cybersecurity
);

Question csQuestion5 = new Question(
    "How can network security be enhanced?",
    csAnswer5,
    1,
    Category.Cybersecurity
);

CyberSecurity CSecurity = new CyberSecurity(csQuestion1);
CSecurity.Add(csQuestion2);
CSecurity.Add(csQuestion3);
CSecurity.Add(csQuestion4);
CSecurity.Add(csQuestion5);



Admin admin1 = new Admin("Mirvari", "12345");


AdminController adminController = new AdminController(admin1);



Student student1 = new Student("RoyaAbbas", Category.Developer);
Student student2 = new Student("EsmaUddin", Category.DataScience);
Student student3 = new Student("ZahraMalik",Category.Cybersecurity);

StudentController scontroller = new StudentController();
scontroller.AddStudent(student1);
scontroller.AddStudent(student2);
scontroller.AddStudent(student3);

scontroller.GetStudents();
reSection:
Restart:
 
    Console.WriteLine("1.Admin\n" +
      "2.Student");

string section = Console.ReadLine()??"";

    if(section == "1")
    {
    // admin secilib

    ReAdmin:
    Console.Clear();
    Console.Write("please enter your adminname: ");
    string adminname = Console.ReadLine()??"";

    Console.Write("Password: ");
    string password = Console.ReadLine() ?? "";

    bool checkadmin = adminController.CheckAdmin(adminname, password);

    if (checkadmin)
    {
       
        ReMethod:
        Console.Clear() ;
        Console.WriteLine(
            "1.Show all Student\n" +
            "2.Add Student\n" +
            "3.Delete Student\n" +
            "4.Add Question\n" +
            "5.Update Student name\n" +
            "6.Update Student Category"
            );

        string methods = Console.ReadLine() ?? "";
        if (methods == "1")
        {
            int count = 1;
            foreach (Student student in scontroller.Students)
            {
                Console.WriteLine("\n" + count + ". " + student.UserName);
                Console.WriteLine("password: " + student.Password);
                count++;
            }
            Console.ReadLine(); 
            goto ReMethod;
        }
        else if (methods == "2")
        {
            reUsername:
            Console.Write("Username:");
            string username = Console.ReadLine()??"";

            Category ctg = new Category();
            Console.WriteLine("please choose the category of student: ");
            Console.WriteLine("1.Developer\n" +
                "2.Data Science \n" +
                "3.Cyber Security");

            var a = Console.ReadLine();
            int k;

            bool checkAnswerType = int.TryParse(a, out k);


            if (checkAnswerType && username !="")
            {
                int b = Convert.ToInt32(a);
                if (b == 1)
                {
                    ctg = Category.Developer;
                }
                else if (b == 2)
                {
                    ctg = Category.DataScience;
                }
                else if (b == 3)
                {
                    ctg = Category.Cybersecurity;
                }
            }
            else
            {
                Console.WriteLine(" Incorrect value format!");
                goto reUsername;
            }
            Console.WriteLine("Password automalicly generated.");

            Student newstudent = new Student(username, ctg);
            scontroller.AddStudent(newstudent);

        }
        else if (methods == "3")
        {
            scontroller.GetStudents();

            while (true)
            {
                Console.WriteLine("Enter the ID of the student you want to delete:");

                var input = Console.ReadLine();
                int studentId;

               
                if (int.TryParse(input, out studentId))
                {
                   
                    scontroller.DeleteStudent(studentId);
                    break; 
                }
                else
                {
                    Console.WriteLine("The type is not correct. Please enter a valid integer ID.");
                }
            }

        }
        else if (methods == "4")
        {
            Console.Write("Sualı daxil edin: ");
            string questionText = Console.ReadLine() ?? "";

            Dictionary<int, string> answers = new Dictionary<int, string>();
            for (int i = 1; i <= 3; i++)
            {
                Console.Write($"Cavab {i}-i daxil edin: ");
                string answerText = Console.ReadLine() ?? "";
                answers.Add(i, answerText);
            }

            Console.Write("Düzgün cavabın nömrəsini daxil edin (1, 2 və ya 3): ");
            int correctAnswer;
            while (!int.TryParse(Console.ReadLine(), out correctAnswer) || !answers.ContainsKey(correctAnswer))
            {
                Console.WriteLine("Düzgün cavabın nömrəsini 1, 2 və ya 3 kimi daxil edin.");
            }

            Console.WriteLine("Sualın kateqoriyasını seçin: ");
            Console.WriteLine("1. Developer\n2. Data Science\n3. Cyber Security");
            Category category;
            int categoryChoice;
            while (!int.TryParse(Console.ReadLine(), out categoryChoice) || categoryChoice < 1 || categoryChoice > 3)
            {
                Console.WriteLine("Kateqoriyanı düzgün nömrə ilə daxil edin.");
            }

            switch (categoryChoice)
            {
                case 1:
                    category = Category.Developer;

                    Question newQuestion1 = new Question(questionText, answers, correctAnswer, category);
                    DevController.Add(newQuestion1, categoryChoice);

                    break;
                case 2:
                    category = Category.DataScience;

                    Question newQuestion2 = new Question(questionText, answers, correctAnswer, category);

                    DataScience dataController = new DataScience(newQuestion2);

                    break;
                case 3:
                    category = Category.Cybersecurity;
                    Question newQuestion3 = new Question(questionText, answers, correctAnswer, category);
                    CyberSecurity cyberController = new CyberSecurity(newQuestion3);
                    break;
                default:
                    throw new ArgumentException("Düzgün kateqoriya seçilmədi.");
            }

        


            Console.WriteLine("Yeni sual əlavə edildi!");
            Console.ReadLine();
            goto ReMethod;
        }
        else if (methods == "5")
        {
            Console.WriteLine("Which student do you want to update");

             scontroller.GetStudents();
             reid:
            var a = Console.ReadLine();
            int k;

            bool checkAnswerType = int.TryParse(a, out k);
             string newvalue = Console.ReadLine()??"";

            if (checkAnswerType)
            {
                int b = Convert.ToInt32(a);
                scontroller.UpdateUserName(b, newvalue);
              
            }
            else
            {
                Console.WriteLine(" student  id is not true:");
                goto reid;
            }

        }
        else if (methods == "6")
        {
            Console.WriteLine("Which student do you want to update");

            scontroller.GetStudents();
          reidd:
            var a = Console.ReadLine();
            int k;

            bool checkAnswerType = int.TryParse(a, out k);
           


            if (checkAnswerType)
            {
                int b = Convert.ToInt32(a);

                Console.WriteLine("Sualın kateqoriyasını seçin: ");
                Console.WriteLine("1. Developer\n2. Data Science\n3. Cyber Security");
                Category category;
                int categoryChoice;
                while (!int.TryParse(Console.ReadLine(), out categoryChoice) || categoryChoice < 1 || categoryChoice > 3)
                {
                    Console.WriteLine("Kateqoriyanı düzgün nömrə ilə daxil edin.");
                }

                switch (categoryChoice)
                {
                    case 1:
                        category = Category.Developer;

                        scontroller.UpdateCategory(b, category);

                        break;
                    case 2:
                        category = Category.DataScience;

                        scontroller.UpdateCategory(b, category);

                        break;
                    case 3:
                        category = Category.Cybersecurity;
                        scontroller.UpdateCategory(b, category);
                        break;
                    default:
                        throw new ArgumentException("Düzgün kateqoriya seçilmədi.");
                }

               

            }
            else
            {
                Console.WriteLine(" student  id is not true:");
                goto reidd;
            }
        }
       
        else
        {
            Console.WriteLine("There is not such a method: ");
            goto ReMethod;
        }

        Console.ReadLine();
        goto Restart;
    }

    else {

        Console.WriteLine(" Name or password id not correct!");
        goto ReAdmin;
    }

}
    else if( section == "2")
{// student secilib


    ReStudent:
    Console.Clear();
    Console.Write("Please enter your username: ");
    string username = Console.ReadLine() ?? "";

    Console.Write("Password: ");
    int password =Convert.ToInt32( Console.ReadLine());

    bool checkstudent =  scontroller.CheckStudent(username, password);

    if (checkstudent)
    {
        Student currentStudent = scontroller.Students.FirstOrDefault(s => s.UserName == username && s.Password == password);

        if (currentStudent != null)
        {
            int countOfQuestions = 0;
            int result = 0;

            if (currentStudent.Category == Category.Developer)
            {
                Console.WriteLine("Developer Category Questions:");
                foreach (Question question in DevController.DevelopmentQuestions)
                {
                    countOfQuestions++;
                    Console.WriteLine(question.Questions);

                    foreach (var answer in question.Answers)
                    {
                        Console.WriteLine($"Answer {answer.Key}: {answer.Value}");
                    }

                    int userAnswer;
                    while (true)
                    {
                        Console.Write("Please enter your answer: ");
                        var input = Console.ReadLine();

                        if (int.TryParse(input, out userAnswer) && question.Answers.ContainsKey(userAnswer))
                        {
                            if (userAnswer == question.Answers2)
                            {
                                result++;
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("The format of the answer is not correct, please enter a valid answer.");
                        }
                    }
                }
            }
            else if (currentStudent.Category == Category.DataScience)
            {
                Console.WriteLine("Data Science Category Questions:");
                foreach (Question question in DScience.DataScienceQuestions)
                {
                    countOfQuestions++;
                    Console.WriteLine(question.Questions);

                    foreach (var answer in question.Answers)
                    {
                        Console.WriteLine($"Answer {answer.Key}: {answer.Value}");
                    }

                    int userAnswer;
                    while (true)
                    {
                        Console.Write("Please enter your answer: ");
                        var input = Console.ReadLine();

                        if (int.TryParse(input, out userAnswer) && question.Answers.ContainsKey(userAnswer))
                        {
                            if (userAnswer == question.Answers2)
                            {
                                result++;
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("The format of the answer is not correct, please enter a valid answer.");
                        }
                    }
                }
            }
            else if (currentStudent.Category == Category.Cybersecurity)
            {
                Console.WriteLine("Cybersecurity Category Questions:");
                foreach (Question question in CSecurity.CyberQuestions)
                {
                    countOfQuestions++;
                    Console.WriteLine(question.Questions);

                    foreach (var answer in question.Answers)
                    {
                        Console.WriteLine($"Answer {answer.Key}: {answer.Value}");
                    }

                    int userAnswer;
                    while (true)
                    {
                        Console.Write("Please enter your answer: ");
                        var input = Console.ReadLine();

                        if (int.TryParse(input, out userAnswer) && question.Answers.ContainsKey(userAnswer))
                        {
                            if (userAnswer == question.Answers2)
                            {
                                result++;
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("The format of the answer is not correct, please enter a valid answer.");
                        }
                    }
                }
            }

        
            FileServices fileservice = new FileServices("Results");
            fileservice.WriteResult(currentStudent.UserName, result, countOfQuestions);

            Console.WriteLine($"Your exam result: {result}/{countOfQuestions}");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Student not found or credentials incorrect.");
        }
    }


    else
    {
        Console.WriteLine("username or password is not correct!");
        goto ReStudent;
    }

}
    else
{
    Console.WriteLine(" Entered value is not true");
    goto reSection;
}

