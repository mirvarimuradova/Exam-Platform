using Exam_Platform.Model;
using System;

public class AdminController
{

	public List<Admin> Admins { get; set; }
	public AdminController(Admin admin)
	{
		
       Admins = new List<Admin>();

		Admins.Add(admin);

		
	}
	public void AddAdmin(Admin admin)
	{
		Admins.Add(admin);
	}
	public bool CheckAdmin(string name, string password)
	{
        foreach (Admin admin in Admins)
        {
            if(admin.UserName == name && admin.Passsword == password)
			{
				return true;
			}
        }
		return false;
    }


	public void  GetAdmins()
	{
		foreach (Admin admin in Admins)
		{
			Console.WriteLine(admin.UserName);
		}
	}

	public void  AddStudents()
	{
        Console.WriteLine("Name: ");
		string name = Console.ReadLine()??"";

        Console.WriteLine("Password: ");
		string password = Console.ReadLine() ?? "";

        Console.WriteLine();

	}
	
}
