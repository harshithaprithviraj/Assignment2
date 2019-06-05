using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle();
        }

        private static void Triangle()
        {
            try
            {
                int triSelection;
                while (true) {
                        Console.WriteLine("1 = Enter the dimensions of triangle");
                        Console.WriteLine("2 = Exit");
                        Console.Write("Choose a menu item to begin: ");
                        triSelection = int.Parse(Console.ReadLine());

                    if (triSelection == 2)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\n");
                        Console.Write("Enter First Number: ");
                        int firstNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Second Number: ");
                        int secondNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Third Number: ");
                        int thirdNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\n\n");
                        string result = TriangleSolver.Analyze(firstNumber, secondNumber, thirdNumber);
                        Console.WriteLine(result);
                        Console.WriteLine("\n");
                        Triangle();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please Retry.");
                Triangle();
            }
        }
    }
} 