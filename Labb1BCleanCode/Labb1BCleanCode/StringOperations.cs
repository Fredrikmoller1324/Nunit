using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1BCleanCode
{
    public class StringOperations
    {

        public string GetFilePath()
        {
            var path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "indata.txt");

            if (!File.Exists(path))
            {
                throw new FileNotFoundException("The file does not exist");
            }

            return path;
        }

        public string ReadFromTxtFile(string filepath)
        {
            string textAsString = File.ReadAllText(filepath);

            if (string.IsNullOrEmpty(textAsString))
            {
                throw new ArgumentException("File is Null or Empty");
            }

            string StringAsOneliner = textAsString.Replace(Environment.NewLine," ");

            return StringAsOneliner;
        }

        public string ReverseString(string stringToReverse)
        {
            var reversedWords = string.Join(" ", stringToReverse.Split(' ').Select(x => new String(x.Reverse().ToArray())).ToArray());

            return reversedWords;
        }
    }
}
