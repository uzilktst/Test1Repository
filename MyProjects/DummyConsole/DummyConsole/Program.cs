using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan sp1 = TimeSpan.FromDays(10);
            TimeSpan sp2 = TimeSpan.FromDays(40);
            TimeSpan sp3 = TimeSpan.FromDays(100);
            TimeSpan sp4 = TimeSpan.FromDays(500);


            int test = sp1.Days;
            test = sp2.Days;
            test = sp3.Days;
            test = sp4.Days;

            // This is a change 1

            // This is change 2

            // This is change 3  - also added spaces in the above lines

        }
    }
}
