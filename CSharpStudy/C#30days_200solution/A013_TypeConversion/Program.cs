using System;

namespace A013_TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 2147483647;        //int 변수 num을 선언하고 -할당
            long bigNum = num;           //암시적 형변환 : long 변수 bigNum을 선언하고 num 변수 값 할당. int 보다 long이 더 크므로 암시적 형변환이 가능.
            Console.WriteLine(bigNum);  //bigNum 값 출력. bigNum은 아미적 형변환으로 num 값과 똑같은 값을 가지고 있음. == 2147483647

            double x = 1234.5;          //double을 선언하고, 1234.5 할당
            int a;

            a = (int)x;                 //명시적 형변환 : int 변수 a에 double 변수 x의 값 할당. int보다 double이 더 크므로, (int)로 캐스팅하여 강제 형변환.
            Console.WriteLine(a);       //int 변수 a출력. 강제 형변환으로 소수점 아래 손실. ==1234

            //결과
            //2147483647
            //1234
        }
    }
}
