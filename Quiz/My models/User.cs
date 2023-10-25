using Quiz.My_exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.My_models
{
    public class User
    {
        private static int _id;
        public string Name { get; set; }
        public string Surname { get; set; }
        private string userName;
        private string password;
        public string UserName 
        { get { return userName; }
            set
            {
                if (value = "^[a - zA - Z0 - 9] + ([.]?[a - zA - Z0 - 9] +) *$" )
                {
                    Console.WriteLine(value);
                }
               
            }
        } 
        public string Password
        {
            get { return password; }
            set
            {
                if (value= "^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$")
                {
                    Console.WriteLine(value);
                }
                else
                {
                    throw new InvalidPasswordException();
                }
            }
        }



        public User(int id, string name, string surname, string userName, string password)
        {
            _id++;
            id = _id;
            Name = name;
            Surname = surname;
            UserName = userName;
            Password = password;
        }


    }
}
