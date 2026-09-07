using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSLT.CSDL.SS5
{
    class Session5
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            {
                //ex1();
                //ex2();
                //ex3();
                //ex4();
                ex6();
                ex7();
                ex8();

            }
        }
        static void ex1()
        {
            Console.WriteLine("--- Câu 1: Check Triangle Type ---");
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
        }
        static void ex2()
        {
            Console.WriteLine("---Câu 2: Sum and Average of 10 numbers--- ");
            double sum = 0;
            double count = 10;
            for (int i = 0; i < count; i++)
            {
                if (double.TryParse(Console.ReadLine(), out double num))
                {
                    sum += num;
                }
                else
                {
                    Console.WriteLine("Nhập lại");
                }
            }
            double avarage = sum / count;
            Console.WriteLine($"Tổng = {sum}");
            Console.WriteLine($"Trung bình = {avarage}");
        }
        static void ex3()
        {

            Console.WriteLine("--- Câu 3: The multiplitation table of given number");
            Console.WriteLine("Nhập một số bất kì (Số nguyên):");
            int so = int.Parse(Console.ReadLine());
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{so} x {i} = {i * so}");
            }
        }
        static void ex4()
        {
            Console.Write("Enter number of rows: ");
            if (int.TryParse(Console.ReadLine(), out int rows) && rows > 0)
            {
                for (int i = 1; i <= rows; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }

            }
        }
        static void ex6()
        {
            double sum = 0;
            Console.WriteLine("Nhập số n (số nguyên):");
            if (int.TryParse(Console.ReadLine(), out int row) && row > 0) ;
            {
                for (int i = 1; i < (row + 1); i++) 
                {
                    if (i < row)
                    {
                        Console.Write($"1/{i} + ");
                    }
                    else
                    {
                        Console.Write($"1/{i}");
                    }
                    sum += 1.0 / i;
                    
                }
                Console.WriteLine($" = {sum} ");
            }
        }
        static void ex7()
        {
            Console.WriteLine("Nhập một số bất kì (Số Nguyên):");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
               
            }
        }
        static void ex8()
        {

        }
    }
}