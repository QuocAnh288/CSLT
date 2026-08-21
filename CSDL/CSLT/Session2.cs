using System;
using System.ComponentModel.Design;
using System.Runtime.Intrinsics.X86;
namespace CSLT
{
    class TAY
    {
        static void Main11111(string[] args)
        {
            // a + b
            int a = 100;
            int b = 200;
            Console.WriteLine($"{a} + {b} = {a + b}");

            // Swap the values of a and c
            int c = 10;
            Console.WriteLine($"Before swap: a = {a}, c = {c}");
            int temp = a;
            a = c; c = temp;
            Console.WriteLine($"After swap: a = {a}, c = {c}");

            // e * d
            float d = 5.5f;
            float e = 10.031f;
            Console.WriteLine($"{d} * {e} = {d * e}");

            // convert feet to meters
            double feet = 20;
            const double feetToMeters = 0.3048;
            double meters = feet * feetToMeters;
            Console.WriteLine($"{feet} feet = {meters} meters");

            // convert Celsius to Fahrenheit
            double celsius = 37;
            double fahrenheit = (celsius * 9.0 / 5.0) + 32;
            Console.WriteLine($"{celsius} Celsius = {fahrenheit} Fahrenheit");

            // to find the size of data types
            Console.WriteLine($"size of int = {sizeof(int)} bytes");
            Console.WriteLine($"size of double = {sizeof(double)} bytes");
            Console.WriteLine($"size of float = {sizeof(float)} bytes");
            Console.WriteLine($"size of char = {sizeof(char)} bytes");

            // Print ASCII values of characters
            Console.WriteLine($"ASCII value of 'c' = {(int)'c'}");

            // Calculate the area of a circle
            double r = 5;
            const double pi = 3.14;
            double area = pi * r * r;
            Console.WriteLine($"Area of circle with radius = {area}");

            // Calculate the area of a square
            double side = 4;
            Console.WriteLine($"Area of square = {side * side}");

            // convert days to years, weeks, and days
            int days = 2001;
            int years = days / 365;
            int remainingDays = days % 365;
            int weeks = remainingDays / 7;
            remainingDays = remainingDays % 7;
            Console.WriteLine($"{days} days = {years} years, {weeks} weeks, {remainingDays} days");
        }
    }
}
