using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace _8_pliki_1
{
    class Program
    {
        static void Main(string[] args)
        {

            DirectoryInfo wsbDir = new DirectoryInfo(".");

            Console.WriteLine(wsbDir.FullName);

            //DirectoryInfo studentDir = new DirectoryInfo("C:\\Users\\Student\\Desktop");
            DirectoryInfo studentDir = new DirectoryInfo(@"C:\Users\Student\Desktop");
            
            Console.WriteLine(studentDir.FullName);
            Console.WriteLine(studentDir.Name);
            Console.WriteLine(studentDir.Parent);
            Console.WriteLine(studentDir.Attributes);
            Console.WriteLine(studentDir.CreationTime);

            DirectoryInfo dataDir = new DirectoryInfo(@"C:\Users\Student\C#Files");

            string[] customers =
            {
                "Agnieszka Nowak",
                "Anna Nowak",
                "Tomasz Kowalski",
            };

            Directory.CreateDirectory("\\Users\\student\\C#Files");

            string path = @"C:\Users\student\C#Files";

            //string textFilePath = @"C:\Users\student\C#Files\testFile1.txt";

            //File.WriteAllLines(textFilePath, customers);

            try
            {
                if (Directory.Exists(path))
                {
                    Console.WriteLine("\nKatalog istnieje");
                }
                else
                {
                    Directory.CreateDirectory("\\Users\\student\\C#Files");
                    string textFilePath = @"C:\Users\student\c#Files\testFile1.txt";
                    File.WriteAllLines(textFilePath, customers);

                    Console.WriteLine("\nUtworzono katalog: {0}", Directory.GetCreationTime(path));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}",e.ToString());
            }

            DirectoryInfo myDataDir = new DirectoryInfo(@path);
            Console.WriteLine();

            FileInfo[] txtFiles = myDataDir.GetFiles("*.txt", SearchOption.AllDirectories);

            Console.WriteLine("Ilość plików tekstowych: {0}",txtFiles.Length);

            Console.WriteLine("Pliki tekstowe:");

            foreach (FileInfo file in txtFiles)
            {
                Console.Write("Nazwa: {0}", file.Name);
                Console.WriteLine(", rozmiar: {0}", file.Length);
            }


            //----------------------------------------
            Console.WriteLine();
            if (Directory.Exists(path))
            {
                Console.WriteLine("Czy chcesz usunąć katalog z plikami? 1-true, 0-false ");
                string delete = Console.ReadLine();
                if (delete == "1")
                {
                    Directory.Delete(path,true);
                    
                    if(Directory.Exists(path))
                    {
                        Console.WriteLine("Katalog został usunięty!");
                    }
                }
                else
                {
                    Console.WriteLine("Nie usunąłeś katalogu!");
                }
            }




            Console.ReadKey();
        }
    }
}
