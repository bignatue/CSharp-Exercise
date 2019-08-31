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
            string z = @"C:\Users\bigna\Downloads";
            var f = Directory.GetFiles(z, "*.*", SearchOption.AllDirectories);

            List<string> files = new List<string>(f);
            files.Sort();

            foreach (string y in files)
            {
                Console.WriteLine(y);
            }
        }
    }
}
