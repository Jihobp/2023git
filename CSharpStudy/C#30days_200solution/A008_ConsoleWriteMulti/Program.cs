using System;

namespace A008_ConsoleWriteMulti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10 이하의 소수 : {0}, {1}, {2}, {3}", 2, 3, 5, 7); // 10 이하의 소수 뒤에 {0}, {1}, {2}, {3}으로 콤마 뒤의 파라미터 지정. parameter매.변

            string primes;
            primes = String.Format("10 이하의 소수 : {0}, {1}, {2}, {3}", 2, 3, 5, 7); // String.Format() 메소드 = Console.WriteLine()과 같은 방법으로 문자열 만들 수 이음.
            Console.WriteLine(primes);
        }
    }
}
