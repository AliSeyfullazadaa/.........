using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromCodeNov25_28
{
    internal class Student
    {
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                while (string.IsNullOrWhiteSpace(value))
                {
                    Console.Write("Name'i duzgun daxil et: ");
                    value = Console.ReadLine();
                }

                _name = value;



                ////if(!string.IsNullOrWhiteSpace(value))
                ////{
                ////    _name = value;
                ////}
                ////else
                ////{
                ////    while(string.IsNullOrWhiteSpace(value))
                ////    {
                ////        Console.Write("Nameyi duzgun daxil et : ");
                ////        value=Console.ReadLine();
                ////    }
                ////    _name=value;
                ////}
            }
        }
        /* defolt -> private */
        string _name;
        private string _surname;

        public string Surname
        {
            get
            {
                return _surname;
            }

            set
            {
                while (string.IsNullOrWhiteSpace(value))
                {
                    Console.Write("SurName'i duzgun daxil et: ");
                    value = Console.ReadLine();
                }

                _surname = value;

            }
        }



        public Student(string name, string surname)
        {
            Name = _name;
            Surname = _surname;
        }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }



    }
}
