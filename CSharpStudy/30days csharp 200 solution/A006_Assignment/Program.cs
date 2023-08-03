using System;

namespace A006_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;              //int 변수 i 와 double 변수 x 선언
            double x;
            
            i = 5;              //변수 i 에 정수 5 할당, x에 실수 할당
            x = 3.141592;
            Console.WriteLine("i = " + i + ", x = " + x);   //콘솔에 i, x 값 출력. 
            //Console.WriteLine() 메소드는 매개변서로 문자열을 + 연산자로 합쳐서 출력. 
            //변수 i와 변수 x는 문자열이 아니지만 문자열과 + 연산자로 연결되면 자동으로 문자열로 변환되어 합쳐짐.

            x = i;          //암시적 형변환           -> double 변수 x에 int 변수 i의 값을 할당. int는 4byte(32bit), double 은 8byte(64bit) 값 손실없이 암시적으로 변환하여 할당 가능
            i = (int)x;     //캐스트가 필요함          -> int 변수 i에 double 변수 x의 값 할당. 더큰 자료형을 더 작은 자료형으로 변환하기 때문에,
                            // (int) x로 형변환을 하여 할당함. 이것을 (cast)라고 함.
            Console.WriteLine("i = " + i + ", x = " + x);

            //문자열을 + 연산자로 합쳐서 출력
        }
    }
}
