using System;

namespace Labb1BCleanCode
{
    class Program
    {
        static void Main(string[] args)
        {
            FileOperations textReader = new FileOperations();

            string filepath = textReader.GetFilePath("indata.txt");
        

            var textFromfile = textReader.ReadFromFile(filepath);

            Console.WriteLine(textFromfile);

            Console.WriteLine("----------");

            Console.WriteLine(textFromfile.ReverseString());
        }
    }
}
