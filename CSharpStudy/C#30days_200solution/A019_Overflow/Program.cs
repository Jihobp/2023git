using System;

namespace A019_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            //OverFlow 예외 처리
            Console.WriteLine("int.MaxValue = {0}", int.MaxValue); //int.MaxValue 출력. 는 부호를 갖는 32 비트 정수가 표현할 수 있는 최대값으로  2,147,483,647.
            int x = int.MaxValue, y = 0;
            y = x + 10;                                            //int.MaxValue에 10을 더한 값을 y에 할당. int의 최대값보다 더 큰 값이므로 오버플로우 발생. 하지만 출력은 오버플로우 메시지 없이 엉뚱한 값인 -2147483639 
            Console.WriteLine("int.MaxValue + 10 = {0}", y);

     
            /*결과
            //int.MaxValue = 2147483647
            //int.MaxValue + 10 = -2147483639
             * int.MaxValue(2147483647) 음수가 되는 ㅇ유는, 맨 앞자리가 부호고 1이라서 음수임.
             */
        }
    }
}
