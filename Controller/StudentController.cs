using Exam_Platform;
using Exam_Platform.Model;
using System;

public class StudentController
{
    public List<Student> Students { get; set; } = new List<Student>();

    public StudentController()
    {
       
      
    }
    public void AddStudent(Student student)
    {

        Students.Add(student);
    }

    public bool CheckStudent(string username , int password)
    {
        foreach (Student std in Students)
        {

            if(std.UserName == username && std.Password == password)
            {
                return true;

            }


        }
        return false;
    }

    public void GetStudents()
    {
        foreach (Student student in Students)
        {

            Console.WriteLine(student.ID+" "+student.UserName  +"  " + student.Password  +"   " + student.Category);
        }
       
    }

    public void DeleteStudent(int id)
    {
        bool studentFound = false;

        for (int i = 0; i < Students.Count; i++)
        {
            if (Students[i].ID == id)
            {
                Students.RemoveAt(i);
                Console.WriteLine("Student deleted successfully.");
                studentFound = true;
                break;
            }
        }

        if (!studentFound)
        {
            Console.WriteLine("There is no student with this ID.");
        }
    }


    public void UpdateUserName(int id,string newvalue)
    {
        if (id <= Students.Count)
        {
            foreach (Student student in Students)
            {
                if (student.ID == id)
                {
                    student.UserName = newvalue;
                    Console.WriteLine(" Student succesfully updated!");
                }

            }
        }
        else
        {
            Console.WriteLine("id's format is not correct:");
        }
    }
    public void UpdateCategory(int id, Category newcategory)
    {
        if (id <= Students.Count)
        {
            foreach (Student student in Students)
            {
                if (student.ID == id)
                {
                    student.Category = newcategory;
                    Console.WriteLine(" Student succesfully updated!");
                }

            }
        }
        else
        {
            Console.WriteLine("id's format is not correct:");
        }
    }

}
