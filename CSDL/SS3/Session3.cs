using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
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

            {//exercise1();
             //exercise2(); 
             //exercise3(); 
             //bt1();
             //bt2();
                bt3();
            }


            static void exercise1()
            {
                // Convert Celsius to Fahrenheit and Kelvin
                Console.WriteLine("Enter temperature in Celsius:");
                double c = double.Parse(Console.ReadLine());
                double fahrenheit = (c * 9 / 5) + 32;
                double kelvin = c + 273.15;

                Console.WriteLine($"{c} Celsius = {fahrenheit} Fahrenheit");
                Console.WriteLine($"{c} Celsius = {kelvin} Kelvin");
            }
            static void exercise2()
            {
                // surface and volume of a sphere
                Console.WriteLine("Enter radius of the sphere:");
                double r = double.Parse(Console.ReadLine());
                double surfaceArea = 4 * Math.PI * r * r;
                double volume = (4 / 3) * Math.PI * r * r * r;
                Console.WriteLine($"Surface area of the sphere = {surfaceArea}");
                Console.WriteLine($"Volume of the sphere = {volume}");
            }
            static void exercise3()
            {
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
            }
            static void bt1()
            {
                // Bài tập 1
                Console.WriteLine($"Nhập số điện cũ:");
                long SDC = long.Parse(Console.ReadLine());
                long SDM;

                do
                {
                    Console.WriteLine($"Nhập số điện mới:");
                    SDM = long.Parse(Console.ReadLine());

                    if (SDM >= SDC)
                        break;
                    else
                        Console.WriteLine($"Số điện mới phải lớn hơn số điện cũ!");
                } while (true);

                long Dien = SDM - SDC;
                Console.WriteLine($"Lượng điện tiêu thụ trong tháng: {Dien}");
                decimal TienDien = 0;
                if (Dien <= 50)
                {
                    TienDien = Dien * 1806;
                    Console.WriteLine($"Tiền điện chưa thuế:{TienDien} VND");
                }
                else if (Dien <= 100)
                {
                    TienDien = 50 * 1806 + (Dien - 50) * 1866;
                    Console.WriteLine($"Tiền điện chưa thuế: {TienDien} VND");
                }
                else if (Dien <= 200)
                {
                    TienDien = 50 * 1806 + 50 * 1866 + (Dien - 100) * 2167;
                    Console.WriteLine($"Tiền điện chưa thuế: {TienDien} VND");
                }
                else if (Dien <= 300)
                {
                    TienDien = 50 * 1806 + 50 * 1866 + 100 * 2167 + (Dien - 200) * 2729;
                    Console.WriteLine($"Tiền điện chưa thuế: {TienDien} VND");
                }
                else
                {
                    TienDien = 50 * 1806 + 50 * 1866 + 100 * 2167 + 100 * 2729 + (Dien - 300) * 3050;
                    Console.WriteLine($"Tiền điện chưa thuế: {TienDien} VND");
                }
                decimal vat = TienDien * 0.08m;

                Console.WriteLine($"Tiền VAT: {vat} VND");
                Console.WriteLine($"Tiền điện thanh toán : {TienDien + vat} VND");

            }
            static void bt2()
            {
                //bai tap 2
                Console.WriteLine("Nhập cân nặng:");
                double weight = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhập chiều cao:");
                double height = double.Parse(Console.ReadLine());
                double BMI = weight / (height * height);
                double Min = 18.5 * height * height;
                double Max = 22.9 * height * height;
                if (BMI < 18.5)
                {
                    Console.WriteLine("Thiếu cân");
                }
                else if (BMI < 23)
                {
                    Console.WriteLine("Bình thường (Lý tưởng)");
                }
                else if (BMI < 25)
                {
                    Console.WriteLine("Thừa cân.");
                }
                else
                {
                    Console.WriteLine("Béo phì");
                }
                Console.WriteLine(string.Format("Chỉ số BMI: {0:F2}", BMI));
                Console.WriteLine(string.Format("Dải cân nặng lí tưởng: {0:F2} - {1:F2}", Min, Max));

            }
            static void bt3()
            {
                Enum 
            }
        }
    }
}