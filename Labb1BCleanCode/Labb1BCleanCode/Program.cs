using System;

namespace Labb1BCleanCode
{
    class Program
    {
        static void Main(string[] args)
        {
            StringOperations textReader = new StringOperations();

            string filepath = textReader.GetFilePath();

            var textFromfile = textReader.ReadFromTxtFile(filepath);

            Console.WriteLine(textFromfile);

            Console.WriteLine("----------");

            Console.WriteLine(textReader.ReverseString(textFromfile));
        }
    }
}
