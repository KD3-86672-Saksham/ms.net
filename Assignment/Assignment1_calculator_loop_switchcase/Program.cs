using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 0;
            Console.Write("num1 = ", n1);


            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("num2 = ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int choice = 0;


            do
            {


                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtration");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("Enter Your Choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Addition = " + (num1 + num2) + "\n");
                        break;
                    case 2:
                        Console.WriteLine("Subtration" + (num1 - num2) + "\n");
                        break;
                    case 3:
                        Console.WriteLine("Multiplication = " + (num1 * num2) + "\n");
                        break;
                    case 4:
                        Console.WriteLine("Division = " + (num1 / num2) + "\n");
                        break;
                    default:
                        Console.WriteLine("Please Select Correct choice!!" + "\n");
                        break;
                }
            }
            while (choice != 0);
        }
    }
}
