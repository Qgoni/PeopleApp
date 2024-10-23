using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleApp
{
    public class People
    {
        public int countsUpTo { get; set; }
        public int age { get; set; }
        public string name { get; set; }

        public virtual void CountsUpTo(int countsUpTo)
        {
            if (countsUpTo <= 0)
            {
                Console.WriteLine("Не буду считать");
            }
            else
            {
                for (int i = 1; i < countsUpTo + 1; i++)
                {
                    Console.Write($"{i} ");
                }
            }     
        }

        public void Name()
        {
           Console.WriteLine(name);
        }

        public void Age()
        {
            Console.WriteLine($"{age} лет");
        }
    }
}
