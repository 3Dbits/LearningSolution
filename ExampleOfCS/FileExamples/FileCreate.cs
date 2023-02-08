using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfCS.FileExamples
{
    internal class FileCreate
    {
        private string FileDir = @"C:\";
        public string Folder { get; set; }
        public string FileName { get; set; }
        public string FileExt { get; set; }


        public void CreateDir()
        {


            string foldername = Path.Combine(FileDir, Folder);


            if (String.IsNullOrEmpty(foldername) || Directory.Exists(foldername))
            {
                Console.WriteLine("Folder already exists");
            }
            else
            {

                Directory.CreateDirectory(foldername);
                Console.WriteLine("Folder was created at path {0}", foldername);
            }
        }

        public void CreateFile()
        {
            var filePath = $@"{FileDir}{Folder}\{FileName}.{FileExt}";

            if (File.Exists(filePath))
            {
                Console.WriteLine("File Already exits");
            }
            else
            {
                using (FileStream fs = File.Create(filePath))
                {
                    Console.WriteLine("File created at path {0}", filePath);
                }
            }
        }

        public void WriteToAFile()
        {
            var path = "";

            while (!File.Exists(path))
            {
                Console.WriteLine("Choose a path to write");
                path = Console.ReadLine();

                if (!File.Exists(path))
                {
                    Console.WriteLine($"Path {path} does not exist !");
                }
            }


            using (StreamWriter stream = File.AppendText(path))
            {
                Console.WriteLine("Write into a file: ");
                stream.WriteLine(Console.ReadLine());
            }

        }


        public void ReadFromAFile()
        {
            Console.WriteLine("Enter a path of a file to read: ");
            var path = Console.ReadLine();

            using (StreamReader streamReader = File.OpenText(path))
            {
                string text = "";

                while ((text = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(text);
                }
            }
        }

    }
}