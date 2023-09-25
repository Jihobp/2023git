using System;

namespace A015_ArithmeticOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("정수의 계산");//콘솔 출력
            Console.WriteLine(123 + 45);    //168
            Console.WriteLine(123 - 45);    //78
            Console.WriteLine(123 * 45);    //5535
            Console.WriteLine(123 / 45);    //2
            Console.WriteLine(123 % 45);    //33

            Console.WriteLine("\n실수의 계산");
            Console.WriteLine(123.45 + 67.89);  //191.34
            Console.WriteLine(123.45 - 67.89);  //55.56
            Console.WriteLine(123.45 * 67.89);  //8381.0205
            Console.WriteLine(123.45 / 67.89);  //1.81838267786125
            Console.WriteLine(123.45 % 67.89);  //55.56
        }
    }
}
