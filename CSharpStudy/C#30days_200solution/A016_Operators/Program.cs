using System;

namespace A016_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(3 + 4 * 5);   //23
            Console.WriteLine((3 + 4) * 5); //35
            Console.WriteLine(3 * 4 / 5);   //2.x -> 정수/정수=정수
            Console.WriteLine(4 / 5 * 3);   //0

            int a = 10, b = 20, c;
            Console.WriteLine(c = a + b);      //30
        }
    }
}
