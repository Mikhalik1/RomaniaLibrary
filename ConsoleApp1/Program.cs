using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int god = 1095;
            god = god % 100;
            Console.WriteLine(god);
            Console.ReadLine();
        }
    }
}
