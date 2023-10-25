using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.My_exceptions
{
    public class BlogNotFoundException:Exception
    {
        public BlogNotFoundException()
        {

        }
        public BlogNotFoundException(string message):base(message)
        {
            Console.WriteLine($"Blog tapilmadi");
        }
    }
}
