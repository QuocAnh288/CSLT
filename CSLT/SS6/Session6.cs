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

namespace CSLT.CSDL.SS6
{
    internal class Session6
    {
        static int Max(int a, int b, int c)
        {
            int max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            return max;
        }
        static int FindMax(int first, params int[] arr)
        {
            
            int max = first;

            
            foreach (int num in arr)
            {
                
                {
                    max = num;
                }
            }

            return max;
        }
        static long factorial(int n)
        {
            if (n < 0) return -1;
            long result = 1;
            for(int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        
        static bool IsPrime(int n)
        { if (n < 2) return false;
        for(int i = 2; i <= n/2; i++)
            {
                if(n % i == 0)
                {
                    return false;
                }
            }    
            return true;
        }
        static void PrintFirstNPrimeNum(int n)
        {
            int count = 0;
            int number = 2;
            while(count < n)
            {
                if (IsPrime(number))
                {
                    Console.Write(number + " ") ;
                    count++;
                }
                number++;
                
            }
        }
        static void PrintLowPrimeNum(int n)
        {
            {
                
                for (int i = 2; i < n; i++)
                {
                    if (IsPrime(i))
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine();
            }

        }

        static void Main6(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8; 

            Console.WriteLine($"Nhập số nguyên dương:");
            int n = int.Parse(Console.ReadLine());
            PrintFirstNPrimeNum(n);
            
        }
    }
}