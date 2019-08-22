using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            // stack follow lifo
            Stack newStack = new Stack();
            // push function used add value
            newStack.Push("stack number 1");
            newStack.Push("stack number 2");
            newStack.Push("stack number 3");
            // count total value of stack element
            Console.WriteLine(newStack.Count);

            foreach (object x in newStack)
            {
                Console.WriteLine("This is " + x);
            }
            Console.ReadLine();
{}
        }
    }
}
