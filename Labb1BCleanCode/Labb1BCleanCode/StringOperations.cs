using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1BCleanCode
{
    public static class StringOperations
    {
        public static string ReverseString(this string stringToReverse)
        {
            var reversedWords = string.Join(" ", stringToReverse.Split(' ').Select(x => new String(x.Reverse().ToArray())).ToArray());

            return reversedWords;
        }
    }
}
