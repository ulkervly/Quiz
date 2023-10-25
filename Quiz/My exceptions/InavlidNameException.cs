using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.My_exceptions
{
    public class InavlidNameException:Exception
    {

        public InavlidNameException()
        {

        }
        public InavlidNameException(string message):base(message)
        {
            Console.WriteLine($"Ad yanlishdir");
        }
    }
}
