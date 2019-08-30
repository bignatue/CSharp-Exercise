using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumeration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ALL DIRECTORY & FILES");
            Console.WriteLine("=============================================");
            AllFiles();

            Console.Read();
        }
        public static void AllFiles()
        {
            string z = @"C:\Users\bigna\OneDrive\Documents";
            var f = Directory.GetFiles(z, "*.*", SearchOption.AllDirectories);
            foreach (string y in f)
            {
                Console.WriteLine(y);
            }
        }
    }
}
