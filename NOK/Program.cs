using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NOK
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Clear();
            //Console.WriteLine("Введите a и b:");
            //Console.Write(" a = ");
            //var a = Convert.ToInt64(Console.ReadLine());
            //Console.Write(" b = ");
            //var b = Convert.ToInt64(Console.ReadLine());

            string str = Console.ReadLine();
            var div = str.FirstOrDefault(char.IsLetter);
            var divs = new char[1];
            divs[0] = div;
            var strList = str.Split(divs);
            
            
            //var strList = str.Substring()
                
                
                
                //int[] intMatch = str.Where(Char.IsDigit).Select(x => int.Parse(x.ToString())).ToArray();
            //var a = intMatch[0];
            //var b = intMatch[1];

            //var gcd = GetGCD(a, b);
            //var lcm = a * b / gcd;

            //Console.WriteLine($"\nНОД равен {gcd}\nНОК равен {lcm}");
            Console.WriteLine($"\n div  {div}");
            Console.ReadKey();
        }

        
        
        
        

        private static long GetGCD(long a, long b)
        {
            if (a == 0)
            {
                return b;
            }

            if (b == 0)
            {
                return a;
            }

            return a > b ? GetGCD(a % b, b) : GetGCD(a, b % a);
        }


    }

 

}
