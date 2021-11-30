using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1BCleanCode
{
    public class TextFileOperations : IFileOperations
    {
        private string filePath;
        
        /// <summary>
        ///     Sets the path of the file
        /// </summary>
        /// <param name="fileName"> name of file</param>
        public void GetFilepath(string fileName)
        {
            var path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, $"{fileName}");

            if (!File.Exists(path)) throw new FileNotFoundException("The file does not exist");

            if (Path.GetExtension(path) != ".txt") throw new ArgumentException("File has to be of type txt");

            filePath = path;
        }

        /// <summary>
        ///     Returns data from txt file as a oneline string
        /// </summary>
        /// <param name="filepath"></param>
        public string Read()
        {
            string textAsString = File.ReadAllText(filePath);

            if (string.IsNullOrEmpty(textAsString)) throw new ArgumentException("File is Null or Empty");
            
            string StringAsOneliner = textAsString.Replace(Environment.NewLine, " ");

            return StringAsOneliner;
        }
    }
}
