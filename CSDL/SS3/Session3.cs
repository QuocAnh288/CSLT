using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSLT.SS3
{
    internal class Session3
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            // Convert Celsius to Fahrenheit and Kelvin
            Console.WriteLine("Enter temperature in Celsius:");
            double c = double.Parse(Console.ReadLine());
            double fahrenheit = (c * 9/5) + 32;
            double kelvin = c + 273.15;

            Console.WriteLine($"{c} Celsius = {fahrenheit} Fahrenheit");
            Console.WriteLine($"{c} Celsius = {kelvin} Kelvin");

            // surface and volume of a sphere
            Console.WriteLine("Enter radius of the sphere:");
            double r = double.Parse(Console.ReadLine());
            double surfaceArea = 4 * Math.PI * r * r;
            double volume = (4/3) * Math.PI * r * r * r;
            Console.WriteLine($"Surface area of the sphere = {surfaceArea}");
            Console.WriteLine($"Volume of the sphere = {volume}");

            // calculates the result of adding, subtracting, multiplying, and dividing two numbers
            Console.WriteLine("Enter a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.WriteLine($"{a} % {b} = {a % b}");

            // Bài tập 1 
            Console.WriteLine($"Nhập số điện cũ:");
            long SDC = long.Parse(Console.ReadLine());
            Console.WriteLine($"Nhập số điện mới:");
            long SDM = long.Parse(Console.ReadLine());
            
            bool check = SDM > SDC;
            if (!check)
            {
                Console.WriteLine($"Số điện mới phải lớn hơn số điện cũ");
                return;
            }
            long Dien = SDM - SDC;
            Console.WriteLine($"Lượng điện tiêu thụ trong tháng: {Dien}");
            if (Dien <= 50)
            {
                Console.WriteLine($"Tiền điện phải trả: {Dien * 1806}");
            }
            else if (Dien <= 100)
            {
                Console.WriteLine($"Tiền điện phải trả: {50 * 1806 + (Dien - 50) * 1866}");
            }
            else if (Dien <= 200)
            {
                Console.WriteLine($"Tiền điện phải trả: {50 * 1806 + 50 * 1866 + (Dien - 100) * 2167}");
            }
            else
            {
                Console.WriteLine($"Tiền điện phải trả: {50 * 1806 + 50 * 1866 + 100 * 2167 + (Dien - 200) * 2729}");
            }
            
        }
    }
}
