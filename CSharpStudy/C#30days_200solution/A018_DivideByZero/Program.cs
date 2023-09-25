using System;

namespace A018_DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 0;

            try
            {
                Console.WriteLine(x / y);       //나누기 연산
            }
            catch (Exception e) //Exception class안 지역변수 Local Variable 'e'
            {

                Console.WriteLine(e.Message); //string Exception.Message{get;}  ; exception  class안 proterties 속성 출력
            }
            //catch문은 예외 발생시 실행됨. 여기선 Exception 클래스의 Message 속성-properties 출력하게 함.
            //"0으로 나누려했습니다" 라고 출력.== Attempted to divide by zero.
            //try ~catch 문은 예외 처리 하고 다음 문장으로 진행.


            //Console.WriteLine(10.0 / y); //실수를 -으로 나누기 때문에 예외가 아닌 무한 출력.
            //Console.WriteLine(x / y);    //x/y 할 때 y 값이 0이어서 0으로 나눔 예외 발생,
        }
    }
}
