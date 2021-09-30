using System;
using System.Linq;

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
            var strList = str.Split(divs, 2);
            ulong n;
            ulong l;
            bool resParsToInt = ulong.TryParse(strList[0], out n);

            bool resParseToUlong = ulong.TryParse(strList[1], out l);
      
            var gcd = GetGCD(n, l);
            var lcm = n * l /gcd;

            Console.WriteLine(lcm);

            Console.ReadKey();
        }


        private static ulong GetGCD(ulong n, ulong l)
        {
            if (n == 0)
            {
                return l;
            }

            if (l == 0)
            {
                return n;
            }

            return n > l ? GetGCD(n % l, l) : GetGCD(n, l % n);
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
