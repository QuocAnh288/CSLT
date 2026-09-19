using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        static bool ex11KiemTraTinhDoiXung(string s)
        {
            s = s.ToLower();
            char[] charArray = s.ToCharArray();
            char[] BeforeReverse = charArray;
            Array.Reverse(charArray);
            if (charArray.SequenceEqual(BeforeReverse))
            {
                return true;
            }
            return false;
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
        static string ex16XoaLapChuTrongTu(string s)
        {
            HashSet<char> DaXuatHien = new HashSet<char>();
            StringBuilder ChoVao = new StringBuilder();
            foreach(char c in s)
            {
                if (DaXuatHien.Add(c))
                {
                    ChoVao.Append(c);
                }
            }
            return ChoVao.ToString();
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
        static string ex18DecimalToBinary(int n)
        {
            if (n == 0) return "0";

            string ketQua = "";
            int so = Math.Abs(n);

            while (so > 0)
            {
                int du = so % 2;
                ketQua = du + ketQua;
                so /= 2;
            }

            return (n < 0) ? "-" + ketQua : ketQua;
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
            return dem;
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            string s = "bokhobanhmi";
            string t = ex16XoaLapChuTrongTu(s);
            Console.WriteLine(t);

        }
        
        
        

        
    }
    
}


