using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ZeroOrLessException : Exception
    {
        public ZeroOrLessException(string message): base("Input must be higher than 0.")
        {
        }
    }

        public class GreaterThan15Exception : Exception
    {
        public GreaterThan15Exception(string message): base("Input must be less than 15.")
        {
        }
    }
}
