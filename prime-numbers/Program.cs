using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            int a, b;
            Console.WriteLine("\n");
            Console.WriteLine("Enter maximum numbers");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("=========");

            for (a = 2; a < x; a++)
            {
                Boolean c = true;
                for (b = 2; b < a; b++)
                {
                    if (a % b == 0)
                    {
                        c = false;
                        break;
                    }
                }
                if (c)
                {
                    count++;
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Result");
            Console.WriteLine(count - 1);
            Console.WriteLine("=========");
        }
    }
}
