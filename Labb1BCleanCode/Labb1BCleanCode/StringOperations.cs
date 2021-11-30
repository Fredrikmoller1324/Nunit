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
        public string ReverseString(IFileOperations stringToReverse)
        {
           return string.Join(" ", stringToReverse.Read().Split(' ').Select(x => new String(x.Reverse().ToArray())).ToArray());
        }
    }
}
