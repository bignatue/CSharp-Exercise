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

        private static void Main(string[] args)
        {
            Basket f1 = new Basket()
            {
                TotalFuit = 500,
                Value = 5.3,
                FruitName = "Mango"
            };
            Basket f2 = new Basket()
            {
                TotalFuit = 550,
                Value = 2,
                FruitName = "Guava"
            };
            Basket f3 = new Basket()
            {
                TotalFuit = 1000,
                Value = 1.5,
                FruitName = "Banana"
            };

            // creating stack
            Stack<Basket> fruits = new Stack<Basket>();
            // using Push() method.
            fruits.Push(f1);
            fruits.Push(f2);
            fruits.Push(f3);

            // using Pop() method.
            Basket b1 = fruits.Pop();
            Double totalValue1 = b1.TotalFuit * b1.Value;
            Console.WriteLine(b1.FruitName + " has " + b1.TotalFuit + " total pieces in the basket and cost of $" + b1.Value + " each with total value of $" + totalValue1);
            Basket b2 = fruits.Pop();
            Double totalValue2 = b2.TotalFuit * b2.Value;
            Console.WriteLine(b2.FruitName + " has " + b2.TotalFuit + " total pieces in the basket and cost of $" + b2.Value + " each with total value of $" + totalValue2);
            Basket b3 = fruits.Pop();
            Double totalValue3 = b3.TotalFuit * b3.Value;
            Console.WriteLine(b3.FruitName + " has " + b3.TotalFuit + " total pieces in the basket and cost of $" + b3.Value + " each with total value of $" + totalValue3);
            Console.WriteLine("===========================================");
            Console.WriteLine();

            // using foreach loop to use Count() method..
            fruits.Push(f1);
            fruits.Push(f2);
            fruits.Push(f3);
            foreach (Basket basket in fruits)
            {
                Console.WriteLine(basket.FruitName + " - " + basket.TotalFuit + " and " + fruits.Count + " stack left.");
            }
            Console.WriteLine("===========================================");
            Console.WriteLine();

            // using Peak() method to retrieve the top item without removing.
            Basket peek1 = fruits.Peek();
            Console.WriteLine(peek1.FruitName + " - " + peek1.TotalFuit);
            Console.WriteLine("===========================================");
            Console.WriteLine();

            // checking existing item by using Contain() method.
            if (fruits.Contains(f1))
            {
                Console.WriteLine("Yes we do have " + b1.TotalFuit + " " + b1.FruitName + " available");
            }
            else
            {
                Console.WriteLine("Sorry we don't have " + b1.FruitName);
            }
            Console.WriteLine("===========================================");
            Console.WriteLine();
        }
    }
}

public class Basket
{
    public int TotalFuit {get; set; }
    public string FruitName { get; set; }
    public Double Value { get; set; }
    public static Double totalValue1 { get; private set; }
    public static Double totalValue2 { get; private set; }
    public static Double totalValue3 { get; private set; }

}   
