using System;

namespace A011_FormatSpecifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0:N2}", 1234.5678); //출력: 1,234.57
            Console.WriteLine("{0:D8}", 1234);      //출력: 00001234
            Console.WriteLine("{0:F3}", 1234.56);   //1234.560
            Console.WriteLine("{0,8}", 1234);       //____1234
            Console.WriteLine("{0,-8}", 1234);      //1234____

            string s;
        }
    }
}
