using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleApp
{
    public class Human1 : People
    {
        public override void CountsUpTo(int countsUpTo)
        {
            Console.WriteLine($"Ребенок начинает считать до: {countsUpTo}");
            base.CountsUpTo(countsUpTo);
        }
    }
}
