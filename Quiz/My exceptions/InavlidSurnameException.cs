using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.My_exceptions
{
    public class InavlidSurnameException:Exception
    {
        public InavlidSurnameException()
        {

        }
        public InavlidSurnameException(string message):base (message)
        {
            Console.WriteLine($"Surname duzgun daxil edilmeyib");
        }
    }
}
