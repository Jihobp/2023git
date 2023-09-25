using System;

namespace A005_stringprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "hello"; //string 변수 a에 "hemllo"문자열 할당
            string b = "h";

            b = b + "ello"; //두 ㅇ문자열 연걸 b=hello
            Console.WriteLine(a == b); //a==b 는 두 문자열 비교, 둘다 hello이므로 true
            Console.WriteLine("b = " + b); //b=hello 이니 출력

            int x = 10;
            string c = b + '!' + " " + x;   //string 변수 c에 string c의 값 hello+문자!+문자열"빈칸"+int x, string 에 다른 자료형의 값을 + 연산자로 연결하면 다른 자료형이 string으로 바뀌어 연결됨.
            Console.WriteLine("c = " + c);  //hello! 10
        }
    }
}
