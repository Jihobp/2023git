using System;

namespace A010_ConsoleFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Clear(); // 콘솔창의 모든 글자를 지움
            
            Console.WriteLine("Standard Numeric Format Specifiers");
            Console.WriteLine(
                "(C) Currency: ------{0:C}\n" +
                "(D} Decimal: -------{0:D}\n" +
                "(E) Scientific: ----{1:E}\n" +
                "(F) Fixed poit: ----{1:F}\n" +
                "(G) General: -------{0:G}\n" +
                "(N) Number: --------{0:N}\n" +
                "(P) Percent: -------{1:P}\n" +
                "(R) Round-trip: ----{1:R}\n" +
                "(X) Hexadecimal: ---{0:x}\n",
                -12345678, -1234.5678f);
            */
            //콘솔에 9가지 형식지정자를 사용하여 숫자 두개 출력함.
            //{ 0}은 콤마 뒤의 첫 번째 파라미터인 -12345678을, {1}은 두번째 파라미터인 -1234.5678울 의미함.
            // 13번째 줄의 {0:C}라는 포맷은 첫 번째 파라미터 -123454678을 토오하 형식인 "C" 형식지정자로 출력함.

            decimal value = 123456.789m;
            Console.WriteLine("잔액은 {0:C2}원 입니다.", value);
            Console.WriteLine("잔액은 {0,20:C2}원 입니다.", value);
            //{0}은 첫번째 파라미터인 value를 전체 20자리를 차지하고, 통화 형식으로 소수점 아래 두자리로 출력함. 
        }
    }
}
