using System;

namespace Labb1BCleanCode
{
    class Program
    {
        static void Main(string[] args)
        {
            TextFileOperations textReader = new TextFileOperations();

            string filepath = textReader.GetFilepath("empty_mock_data.txt");

            var textFromfile = textReader.Read(filepath);

            Console.WriteLine(textFromfile);

            Console.WriteLine("----------");

            Console.WriteLine(textFromfile.ReverseString());
        }
    }
}
