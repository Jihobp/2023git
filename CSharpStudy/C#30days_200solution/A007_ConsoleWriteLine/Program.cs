using System;

namespace A007_ConsoleWriteLine
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            char c = 'A';
            decimal d = 1.234m;     //m은 decimal 형의 접미사
            double e = 1.12343433;  //double 이 float보다 효율 좋다.
            float f = 1.12324245f;  //f는 float 형의 접미사. 
            int i = 1234;
            string s = "Heloo";

            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(i);
            Console.WriteLine(s);
        }
    }
}
