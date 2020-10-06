using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Main program és b-je");
            int a = 10;
            int b = 20;
            Console.WriteLine(a + b);
            calc(ref a, b);
            Console.WriteLine("függvény eljárás után");
            b = calc(ref a, b);
            Console.WriteLine(a + b);
            Console.ReadLine();
            
        }
        static int calc(ref int a, int b)
        {
            Console.WriteLine("Eljárás és b-je");
            Console.WriteLine(a + b);
            a = 100;
            Console.WriteLine("Eljárájban a változik és kiíratom");
            Console.WriteLine(a + b);
            return b + 50;

        }
    }
}
