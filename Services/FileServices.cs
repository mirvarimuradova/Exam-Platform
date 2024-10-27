using System;
using System.IO;

namespace Exam_Platform.Services
{
    internal class FileServices
    {
        private string _directoryPath = @"C:\Users\user\Desktop\Exam Platform";
        public static string folderName = "/FileFolder/";
        private string _filePath;

    public FileServices(string fileName)
        {
            
            try
            {
                Directory.CreateDirectory(_directoryPath + folderName);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Qovluq yaratmaqda xəta: {ex.Message}");
            }

           
            _filePath = Path.Combine(_directoryPath, $"{fileName}.txt");

            if (!File.Exists(_directoryPath + folderName + fileName + ".txt"))
            {
                File.Create(_directoryPath + folderName + fileName + ".txt");
            }

        }

        public void WriteResult(string studentName, int score, int questionsCount)
        {
         
            string result = $"Student: {studentName}, Score: {score} / {questionsCount}";

            try
            {
              
                using (StreamWriter writer = new StreamWriter(_filePath, true))
                {
                    writer.WriteLine(result);
                }
                Console.WriteLine("Nəticə uğurla yadda saxlanıldı!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fayla yazma zamanı xəta: {ex.Message}");
            }
        }
    }
}
