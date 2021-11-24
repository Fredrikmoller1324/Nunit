using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzLab1a.Exceptions
{
    public class NegativeNumberNotAllowedException : Exception
    {
        public NegativeNumberNotAllowedException(string message) : base(message)
        {

        }
    }
}
