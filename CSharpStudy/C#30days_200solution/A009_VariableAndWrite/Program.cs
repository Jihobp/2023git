using System;

namespace A009_VariableAndWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1 = 100;
            double v2 = 1.1234;

            //Console.WriteLine(v1,v2); //에러 발생 -> 두 변수를 출력하는 Console,WriteLine() 메소드 정의가 없기 때문.

            Console.WriteLine(v1.ToString() + ", " + v2.ToString());    //두 개 변수를 ToString() 문자열로 바꾸어 + 연산자로 연결하여 출력. 문자열 하나를 출력하는 것.
            Console.WriteLine("v1 = " + v1 + ", v2 = " + v2);           //문자열과 숫자를 + 연산자로 연결하면 문자열이 됨. 문자열 하나를 출력하는 것.
            Console.WriteLine("v1 = {0}, v2 = {1}", v1, v2);            //형식 format 문자열을 사용 가능.
            Console.WriteLine($"v1 = {v1}, v2 = {v2}");                 //형식문자열 앞에 $를 쓰면, {} 안에 변수명을 직접 쓸 수 있음.
        }
    }
}
