using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace non_primitive
{
    public class Person
    {
        public string FirstName="";
        public string LastName="";

        public void Introduce()
        {
            Console.WriteLine("My Name is " + FirstName + " " + LastName);
        }
    }
}