using System;

namespace A004_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("이름을 입력하세요: ");
            string name = Console.ReadLine();       //string 변수 name을 선언하고 콘솔에서 입력받은 문자열을 name 변수에 할당합니다. Console, ReadLine()은 콘솔에 입력되는 값을 무조건 stirng으로 반환
            Console.Write("나이를 입력하세요: ");
            int age = int.Parse(Console.ReadLine()); //int형 변수 age를 선언, 입력받은 문자열을 정수로 바꾸어 할당.
            Console.Write("키를 입력하세요(cm): ");
            float height = float.Parse(Console.ReadLine());

            Console.Write("나이는 ");
            Console.Write(age);
            Console.Write("세, 키는 ");
            Console.Write(height);
            Console.WriteLine("cm 이군요! ");

        }
    }
}
