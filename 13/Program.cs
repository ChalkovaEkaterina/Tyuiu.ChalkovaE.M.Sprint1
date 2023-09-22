using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = a / 4;
            b *= b % 3;
            a -= b++ - 1;
            int x = a + b;

            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
