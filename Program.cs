using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human1 human1 = new Human1()
            { 
                name = "Cаша", 
                age = 10, 
                countsUpTo = 10
            };
            human1.Name();
            human1.Age();
            human1.CountsUpTo(human1.countsUpTo);
            Console.ReadKey();

        }
    }
}
