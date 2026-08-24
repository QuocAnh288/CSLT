using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.SS4
{
    class Session4
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            ex1();
            ex2();
            ex3();
            ex4();
            ex5();
        }
            static void ex1()
            {
                //Write a C# Sharp program that takes two numbers as input and performs an operation(+, -, *, x,/) on them and displays the result of thatoperation.
                double a = 100;
                double b = 200;
                Console.WriteLine($"{a} + {b} = {a + b}");
                Console.WriteLine($"{a} - {b} = {a - b}");
                Console.WriteLine($"{a} * {b} = {a * b}");
                Console.WriteLine($"{a} / {b} = {a / b}");
                Console.WriteLine($"{a} % {b} = {a % b}");
            }
            static void ex2()
            {
                Console.WriteLine("{0,-10} | {1,-20}", "y", "x = y^2 + 2y + 1");
                Console.WriteLine(new string('-', 33));
                for (int y = -5; y <= 5; y++)
                {
                    int x = (y * y) + (2 * y) + 1;
                    Console.WriteLine("{0,-10} | {1,-20}", y, x);
                }

                Console.ReadKey();
            }
            static void ex3()
        {
            Console.WriteLine("Nhập số km:");
            double km = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số giờ");
            double hour = double.Parse(Console.ReadLine());
            Console.WriteLine($"Kilometers per hour:{km / hour:N2}km/h");
            Console.WriteLine($"Miles per hour:{km * 0.621371 / hour:N2}miles/h");


        }
        static void ex4()
        {
            Console.WriteLine("Enter radius of the sphere:");
            double r = double.Parse(Console.ReadLine());
            double surfaceArea = 4 * Math.PI * r * r;
            double volume = (4 / 3) * Math.PI * r * r * r;
            Console.WriteLine($"Surface area of the sphere = {surfaceArea}");
            Console.WriteLine($"Volume of the sphere = {volume}");
        }
        static void ex5()
        
        {
            Console.Write("Enter a character: ");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine(); 

            if (char.IsDigit(input))
            {
                Console.WriteLine($"'{input}' is a digit.");
            }
            
            else if ("aeiouAEIOU".IndexOf(input) >= 0)
            {
                Console.WriteLine($"'{input}' is a vowel.");
            }
            
            else
            {
                Console.WriteLine($"'{input}' is another symbol.");
            }

            Console.ReadKey();
        }

        }
    }
