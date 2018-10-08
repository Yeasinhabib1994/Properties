using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            //var person = new Person();
            //person.Birthdate = new DateTime(1994, 4, 1);

            var person = new Person(new DateTime(1994, 4, 1));
            Console.WriteLine("Birthdate: " + person.Birthdate);
            Console.WriteLine("Age: " + person.Age);
        }
    }

    public class Person
    {
        //public DateTime Birthdate { get; set; }

        public DateTime Birthdate { get; private set; }

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }


        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }

        }
    }
}
