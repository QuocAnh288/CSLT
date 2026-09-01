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
            //ex1();
            //ex2();
            //ex3();
            //ex4();
            //ex5();
            //ptbt2();
            state();


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
            Console.WriteLine("Nhập số phút");
            double minute = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số giây");
            double second = double.Parse(Console.ReadLine());
            double totalhour = hour + minute / 60 + second / 3600;
            Console.WriteLine($"Kilometers per hour:{km / totalhour:N2}km/h");
            Console.WriteLine($"Miles per hour:{km * 0.621371 / totalhour:N2}miles/h");


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
        static void ptbt2()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Phương trình có vô số nghiệm");
                    }
                    else
                    {
                        Console.WriteLine("Phương trình vô nghiệm");
                    }
                }
                else
                {
                    Console.WriteLine($"x = {-c / b}");
                }
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("Phương trình vô nghiệm");
                }
                else if (delta == 0)
                {
                    Console.WriteLine($"x1 = x2 = {-b / 2 * a}");
                }
                else
                {
                    Console.WriteLine($"x1 = {(-b + Math.Sqrt(delta)) / 2 * a}");
                    Console.WriteLine($"x1 = {(-b - Math.Sqrt(delta)) / 2 * a}");
                }
            }
        }
        static void state()
        {



            {


                // ==================== BÀI 1: Check Even or Odd ====================
                Console.WriteLine("--- EXERCISE 1: Check Even or Odd ---");
                Console.Write("Input an integer: ");
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine($"{num} is an even integer.\n");
                }
                else
                {
                    Console.WriteLine($"{num} is an odd integer.\n");
                }

                // ==================== BÀI 2: Largest of Three Numbers ====================
                Console.WriteLine("--- EXERCISE 2: Largest of Three Numbers ---");
                Console.Write("Input the 1st number: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Input the 2nd number: ");
                int num2 = int.Parse(Console.ReadLine());

                Console.Write("Input the 3rd number: ");
                int num3 = int.Parse(Console.ReadLine());

                if (num1 >= num2 && num1 >= num3)
                {
                    Console.WriteLine($"The 1st number ({num1}) is the greatest.\n");
                }
                else if (num2 >= num1 && num2 >= num3)
                {
                    Console.WriteLine($"The 2nd number ({num2}) is the greatest.\n");
                }
                else
                {
                    Console.WriteLine($"The 3rd number ({num3}) is the greatest.\n");
                }

                // ==================== BÀI 3: Triangle Type ====================
                Console.WriteLine("--- EXERCISE 3: Check Triangle Type ---");
                Console.Write("Input side 1: ");
                int side1 = int.Parse(Console.ReadLine());

                Console.Write("Input side 2: ");
                int side2 = int.Parse(Console.ReadLine());

                Console.Write("Input side 3: ");
                int side3 = int.Parse(Console.ReadLine());

                if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
                {
                    if (side1 == side2 && side2 == side3)
                    {
                        Console.WriteLine("This is an Equilateral triangle.\n");
                    }
                    else if (side1 == side2 || side1 == side3 || side2 == side3)
                    {
                        Console.WriteLine("This is an Isosceles triangle.\n");
                    }
                    else
                    {
                        Console.WriteLine("This is a Scalene triangle.\n");
                    }
                }
                else
                {
                    Console.WriteLine("These side lengths do not form a valid triangle.\n");
                }

                // ==================== BÀI 4: Coordinate Quadrant ====================
                Console.WriteLine("--- EXERCISE 4: Determine Coordinate Quadrant ---");
                Console.Write("Input the value for X coordinate: ");
                int co1 = int.Parse(Console.ReadLine());

                Console.Write("Input the value for Y coordinate: ");
                int co2 = int.Parse(Console.ReadLine());

                if (co1 > 0 && co2 > 0)
                {
                    Console.WriteLine($"The coordinate point ({co1},{co2}) lies in the First quadrant.\n");
                }
                else if (co1 < 0 && co2 > 0)
                {
                    Console.WriteLine($"The coordinate point ({co1},{co2}) lies in the Second quadrant.\n");
                }
                else if (co1 < 0 && co2 < 0)
                {
                    Console.WriteLine($"The coordinate point ({co1},{co2}) lies in the Third quadrant.\n");
                }
                else if (co1 > 0 && co2 < 0)
                {
                    Console.WriteLine($"The coordinate point ({co1},{co2}) lies in the Fourth quadrant.\n");
                }
                else if (co1 == 0 && co2 == 0)
                {
                    Console.WriteLine($"The coordinate point ({co1},{co2}) lies at the origin.\n");
                }
                else if (co1 == 0)
                {
                    Console.WriteLine($"The coordinate point ({co1},{co2}) lies on the Y axis.\n");
                }
                else
                {
                    Console.WriteLine($"The coordinate point ({co1},{co2}) lies on the X axis.\n");
                }
            }
        }
    }

}
    
