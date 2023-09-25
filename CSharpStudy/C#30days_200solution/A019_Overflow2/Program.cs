using System;

namespace A019_Overflow2
{
    class Program
    {
        static void Main(string[] args)
        {
            //y = int.MaxValue + 10; // 이 문장은 컴파일할 때 에러가 나옴. ->  이미 상수 값이 정수의 범위를 넘어선 것을 알 수 있기 때문에 컴파일할 때 에러 발생.
            int x = int.MaxValue, y = 0;
            
            checked //checked 키워드를 사용하면 오버플로 예외를 발생. checked 사용하지 않으면 디폴트로 unchecked 상태가 되어 결과의 가장 중요한 비트(MSB)가 무시되고 실행 계속됨.
            {
                try  //try~ catch 문을 예외가 발생하면 어떤 예외인지 출력. 오버플로가 발생했다는 메세지 출력.
                {
                    y = x + 10;
                }
                catch (Exception e) //Exception class안 지역변수 Local Variable 'e'
                {
                    Console.WriteLine(e.Message);  //산술 연산을 인해 오버플로가 발생했습니다.   //string Exception.Message{get;}  exception  class안 proterties 속성 출력
                }             
            }
            Console.WriteLine("Int.MaxVlaue + 10 = {0}", y); //오버플로가 발생한 변수의 값은 0.
        }
    }
}
