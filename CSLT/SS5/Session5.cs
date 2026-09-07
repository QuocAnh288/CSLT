using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
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



            for ( int i = 1; i < 15; i++)
            {
                for (int j = 1; j < 10; j++) 
                {
                    Console.WriteLine($"\n{i}*{j} = {i*j}");
                }
            }
            
            string ka = "KAKAKA";
            foreach( char K in ka )
            {
                Console.WriteLine(K);
            }    
        }
    }
}