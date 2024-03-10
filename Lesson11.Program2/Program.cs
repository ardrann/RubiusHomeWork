using System;
using System.IO;
using System.IO.Compression;
using static System.Net.Mime.MediaTypeNames;

namespace Lesson11.Program2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // считываем путь к csv
            var infoTxtFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Lesson12Homework.txt");

            using var fileStream = new FileStream(infoTxtFilePath, FileMode.Open);
            using var streamReader = new StreamReader(fileStream);

            var pathToCsv = streamReader.ReadLine();
            var formattedPathToCsv = @$"{pathToCsv}";
            Console.WriteLine(formattedPathToCsv);

            // открываем csv
            using var fileStream1 = new FileStream(formattedPathToCsv, FileMode.Open); // ошибка в этой строке
            using var streamReader1 = new StreamReader(fileStream1);

            var data = streamReader1.ReadToEnd();

            Console.WriteLine(data);

            // сортируем текст

            // удаляем текстовый файл
            if (File.Exists(infoTxtFilePath))
            {
                try
                {
                    File.Delete(infoTxtFilePath);
                    Console.WriteLine("Файл удален.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Файл не существует.");
            }
        }
    }
}