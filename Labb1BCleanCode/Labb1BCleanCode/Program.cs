using System;

namespace Labb1BCleanCode
{
    class Program
    {
        static void Main(string[] args)
        {
            TextFileOperations textReader = new TextFileOperations();
            
            textReader.GetFilepath("indata.txt");

            var textFromfile = textReader.Read();

            Console.WriteLine(textFromfile);

            Console.WriteLine("----------");

            Console.WriteLine(new StringOperations().ReverseString(textReader));
        }
    }
}
