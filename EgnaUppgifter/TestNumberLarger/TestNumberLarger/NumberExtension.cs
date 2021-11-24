using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNumberLarger
{
    public static class NumberExtension
    {
        public static bool NumberIsLargerThanTen(this int number)
        {
            return number > 10 ? true : false;
        }
    }
}
