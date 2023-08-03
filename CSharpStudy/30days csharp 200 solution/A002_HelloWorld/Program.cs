using System;

namespace A002_003_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello");
            Console.WriteLine("World!");    //줄바꿈
            Console.Write("이름을 입력하세요:   "); //콘솔에 출력, 줄바꿈 nono

            string name = Console.ReadLine(); //이름을 입력받음 //입력받은 문자열을 name 이라는 변수에 저장
            Console.Write("hi ");
            Console.Write(name);            //name의 변수값
            Console.WriteLine("님!");

        }
    }
}
