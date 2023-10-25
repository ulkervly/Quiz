using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.My_exceptions
{
    public class InvalidPasswordException:Exception
    {
        public InvalidPasswordException()
        {

        }
        public InvalidPasswordException(string message):base(message)
        {
            Console.WriteLine($"Username ve ya Password yanlishdir ");
        }
    }
}
