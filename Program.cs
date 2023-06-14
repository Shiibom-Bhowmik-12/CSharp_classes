using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using non_primitive.Math;

namespace non_primitive
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1=new Person();
            p1.FirstName = "Shibom";
            p1.LastName = "Bhowmik";
            p1.Introduce();

            //Math class is seperated in another folder because it differs bussiness logic.
            //Whenever we are dealing with different logic we separate the classes in diffrent folders,
            //in different namespaces
            var calc = new Calculator();
            Console.WriteLine(calc.Add(10,30));
        }
    }
}