using System;
using System.IO;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            var myPath = "c:\\users\\developer\\desktop\\myFile.txt";
            if (!File.Exists(myPath))
            {
                File.Create(myPath);
            }
            var myReader = new StreamReader(myPath);
            var content = string.Empty;
            while (!myReader.EndOfStream)
            {
                content = myReader.ReadLine();
                Console.WriteLine(content);
            }
            myReader.Close();
            Console.WriteLine("enter text you want to save to your file");
            var myInput = Console.ReadLine();
            var myWriter = new StreamWriter(myPath);
            myWriter.Write(myInput + "\n");
            myWriter.Close();

        }
    }

}
