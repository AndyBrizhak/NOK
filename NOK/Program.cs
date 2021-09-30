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
            
            string str = Console.ReadLine();
            var div = str.FirstOrDefault(CharExtension.IsNoDigit);
            var divs = new char[1];
            divs[0] = div;
            var strList = str.Split(divs,2);
            int n;
            ulong l;
            bool resParsToInt = int.TryParse(strList[0], out n);
            
            bool resParseToUlong = ulong.TryParse(strList[1], out l);

            ulong a = (ulong)n;
            ulong b = l;
            
            var gcd = GetGCD(a, b);
            var lcm = a*b/(ulong) gcd;

            Console.WriteLine($"\n NOK = {lcm}");
            //Console.WriteLine($"\n div  {div}");
            
            Console.ReadKey();
        }

       
        private static ulong GetGCD(ulong a, ulong b)
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

    public static class CharExtension
    {
        public static bool IsNoDigit(this char ch)
        {
            if (!Char.IsDigit(ch))
            {
                return true;
            }

            return false;
        }
    }

    

 

}
