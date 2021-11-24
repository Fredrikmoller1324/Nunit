using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzLab1a.Exceptions
{
    public class ZeroNotAllowedException : Exception
    {
        public ZeroNotAllowedException(string message) : base(message)
        {

        }
    }
}
