using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {
        //Calc
        static void Main(string[] args)
        {
            Console.Write("Welcome to Jay's Calculator!");

            System.Threading.Thread.Sleep(1000);
                Console.Clear();
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            System.Threading.Thread.Sleep(1000);
                Console.Clear();

            Console.WriteLine(num1 + num2);
            System.Threading.Thread.Sleep(500);

            Console.WriteLine("Thank You for using Jay's Calc :)");


            Console.ReadLine();

        }
    }
}
