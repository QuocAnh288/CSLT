using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Threading.Channels;

namespace CSLT.CSLT.SS6
{
    internal class Ex20
    {
        static int ex1Tong(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
            return a + b;
        }
        static bool ex2KiemTraChan(int n)
        {
            if (n % 2 == 0)
            {
                Console.Write($"{n} là số chẵn");
                return true;
            }

            Console.Write($"{n} là số lẻ");
            return false;
        }
        static void ex3Max(int a, int b, int c)
        {
            int max = Math.Max(Math.Max(a, b), c);

            Console.WriteLine($"Số lớn nhất trong ba số là{max}");
        }
        static void ex4TinhGiaiThua(int a)
        {
            long sum = 1;
            for (int i = 1; i <= a; i++)
            {
                sum *= i;
            }
            Console.WriteLine($"Giai thừa của{a} là {sum}");
        }
        static string ex5DaoNguocChuoi(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static bool ex6KiemtraSoNguyenTo(int a)
        {
            for (int i = 2; i <= a / 2; i++)
            {
                if (a % i == 0)
                {
                    Console.WriteLine("False");
                    return false;
                }
            }
            Console.WriteLine("True");
            return true;
        }
        static void ex7nthFibonacci(int n)
        {
            long t1 = 0;
            long t2 = 1;
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(t1 + " ");
                long sum = t1 + t2;
                t1 = t2;
                t2 = sum;

            }
            Console.WriteLine();

        }
        static int ex8DemNguyenAm(string s)
        {
            string NguyenAm = "aàáảãạăằắẳẵặâầấẩẫậeèéẻẽẹêềếểễệiìíỉĩịoòóỏõọôồốổỗộơờớởỡợuùúủũụưừứửữựyỳýỷỹỵ" +
                          "AÀÁẢÃẠĂẰẮẲẴẶÂẦẤẨẪẬEÈÉẺẼẸÊỀẾỂỄỆIÌÍỈĨỊOÒÓỎÕỌÔỒỐỔỖỘƠỜỚỞỠỢUÙÚỦŨỤƯỪỨỬỮỰYỲÝỶỸỴ";
            int dem = 0;
            foreach (char c in s)
            {
                if (NguyenAm.Contains(c))
                {
                    dem++;
                }
            }
            return dem;
        }
        static double ex9TinhLuyThua(double x, int y)
        {
            double lt = 1;
            for (int i = 1; i <= y; i++)
            {
                lt *= x;
            }
            return lt;
        }
        static double ex10TinhTrungBinhMang(int[] arr)
        {
            double tong = 0;
            foreach (char x in arr)
            {
                tong += x;
            }
            return tong / arr.Length;
        }
        static double ex12DoiTuDoCQuaDoF(double a)
        {
            double DoF = a * 1.8 + 32;
            return DoF;
        }
        static int ex13TimMinTrongMang(int[] arr)
        {
            Array.Sort(arr);
            int n = arr[0];
            return n;
        }
        static int ex14TinhTongCacChuSoTrongN(int n)
        {
            int tong = 0;
            while (n > 0)
            {
                tong += (n % 10);
                n /= 10;
            }
            return tong;
        }
        static int[] ex15SapXepMang(int[] arr)
        {
            Array.Sort(arr);
            return arr;
        }
        static int ex17TimUCLN(int a, int b)
        {

            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
        static bool ex19KiemTraNamNhuan(double year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
        static int ex20KiemTraSoChuTrongCau(string s)
        {
            int dem = 0;
            bool DangTrongTu = false;
            string space = " ";
            foreach (char c in s)
            {
                if (c != ' ')
                {
                    if (!DangTrongTu)
                    {
                        dem++;
                        DangTrongTu = true;
                    }

                }
                else
                {
                    DangTrongTu = false;
                }
            }
            return dem + 1;
        }
            static void Main(string[] args)
            {
                Console.InputEncoding = Encoding.UTF8;
                Console.OutputEncoding = Encoding.UTF8;
                //int[] arr = { 4,5,6,7 };
                //double TB = ex10TinhTrungBinhMang(arr);
                //Console.WriteLine(TB);
                //int[] arr = { 5, 8, 9, 6, 45, 4, 2, 5, 4, 3, 25, 4 };
                //int[] b = ex15SapXepMang(arr);
                //Console.WriteLine(string.Join(", ", b));
                //bool a = ex19KiemTraNamNhuan(2008);
                //Console.WriteLine(a);
                //int a = ex17TimUCLN(12,18);
                //Console.WriteLine(a);
                string b = "Hom nay o nha";
                int c = ex20KiemTraSoChuTrongCau(b);
                Console.WriteLine(c);


            }
        
    }
    
}


