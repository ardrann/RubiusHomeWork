using System;
using System.IO;
using System.IO.Compression;

namespace Lesson11
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            // распаковка указанного архива
            string archivePath = "C:\\Users\\atanooniel\\Desktop\\Images.zip";
            string extractPath = Path.Combine(Directory.GetCurrentDirectory(), "extracted");

            if (!Directory.Exists(extractPath))
            {
                Directory.CreateDirectory(extractPath);
            }

            ZipFile.ExtractToDirectory(archivePath, extractPath);

            Console.WriteLine("Архив успешно распакован в папку: " + extractPath);

            // записываем информацию в текстовый файл
            var infoFilePath = Path.Combine(Directory.GetCurrentDirectory(), "infoFile.csv");

            using var fileStream = new FileStream(infoFilePath, FileMode.Create);
            using var streamWriter = new StreamWriter(fileStream);

            string[] files = Directory.GetFiles(extractPath);
            string[] folders = Directory.GetDirectories(extractPath);

            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                DateTime lastModified = fileInfo.LastWriteTime;
                string newString = "Файл\t" + Path.GetFileName(file) + "\t" + lastModified + "\n";

                streamWriter.WriteLine(newString);
            }
            foreach (string folder in folders)
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(folder);
                DateTime lastModified = directoryInfo.LastWriteTime;
                string newString = "Папка\t" + Path.GetFileName(folder) + "\t" + lastModified + "\n";

                streamWriter.WriteLine(newString);
            }

            // удаление папки с распакованными файлами
            if (Directory.Exists(extractPath))
            {
                try
                {
                    Directory.Delete(extractPath, true);
                    Console.WriteLine("Папка удалена.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Папка не существует.");
            }

            // запись пути к csv
            var infoTxtFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Lesson12Homework.txt");

            using var fileStream1 = new FileStream(infoTxtFilePath, FileMode.Create);
            using var streamWriter1 = new StreamWriter(fileStream1);

            streamWriter1.WriteLine(infoFilePath);
            Console.WriteLine(infoFilePath);
        }
    }
}