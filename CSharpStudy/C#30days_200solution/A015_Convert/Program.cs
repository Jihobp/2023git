using System;

namespace A015_Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;                       //int x, y 선언

            Console.Write("첫번째 숫자를 입력하세요: "); //첫번째 숫자 입력 안내 출력
            x = Convert.ToInt32(Console.ReadLine());    //Console.ReadLine() 으로 값을 받아서 Int32형으로 변환하여 x 에 할당.
            Console.Write("두번째 숫자를 입력하세요: ");
            y = Convert.ToInt32(Console.ReadLine());    //Console.ReadLine() 으로 값을 받아서 Int32형으로 변환하여 y 에 할당.
            Console.WriteLine("{0} + {1} + {2}", x, y, x+y); //x+y 더해서 출력

            //2진수, 8진수, 10진수, 16진수로 출력하기.
            short value = short.MaxValue; // Int16.MaxValue     : short value 를 선언하고, MaxVlaue 할당. shorts는 Int16과 같은 자료형.
            Console.WriteLine("\n2진수, 8진수, 10진수, 16진수로 출력하기. "); // 콘솔에 출력
            //
            int baseNum = 2;             //int baseNum 은 진수. (2진수로 정함)
            string s = Convert.ToString(value, baseNum);    //Convert,ToString(value, baseNum)를 사용하여, value 값을 2진 문자열로 변환하여 s에 할당.
            int i = Convert.ToInt32(s, baseNum);            //Convert.ToInt32(s, baseNum)을 사용하여 2진 문자열을 저장하고 있는 s의 값을 Int32형으로 변환. baseNum parameter-매개변수가 문자열을 몇 진수로 해석할지 알려줌.
            Console.WriteLine("i = {0}, {1,2}진수 = {2,16}", i, baseNum, s); //i, baseNum, s를 지정된 형식으로 출력 : {0}은 i, {1,2}는 baseNum을 2자리로, {2,16}은 데이터 s를 16자리에 출력. 출력이 정렬디ㅗ게 형식에 자릿수 사용.

            baseNum = 8;                //8진수로 정함
            s = Convert.ToString(value, baseNum);
            i = Convert.ToInt32(s, baseNum);
            Console.WriteLine("i = {0}, {1,2}진수 = {2,16}", i, baseNum, s);

            baseNum = 10; ;                //10진수로 정함
            s = Convert.ToString(value, baseNum);
            i = Convert.ToInt32(s, baseNum);
            Console.WriteLine("i = {0}, {1,2}진수 = {2,16}", i, baseNum, s);

            baseNum = 16; ;                //16진수로 정함 fixed in hexadecimal: Convert.ToString 메서드를 사용하여 숫자 값을 16진수 표현으로 변환한 다음 Convert.ToInt32를 사용하여 다시 정수로 변환
            s = Convert.ToString(value, baseNum); //변환할 값(value)과 변환 기준(baseNum, 16진수의 경우 16)의 두 가지 인수를 사용해서 Convert.ToString 메서드를 사용
            i = Convert.ToInt32(s, baseNum);      //onvert.ToInt32 메서드를 사용하여 16진수 문자열 s를 다시 정수로 변환. 이 메서드는 변환할 문자열(s)과 변환 기준(baseNum, 16진수의 경우 16)이라는 동일한 두 인수를 사용
            Console.WriteLine("i = {0}, {1,2}진수 = {2,16}", i, baseNum, s);
            /*결과
             첫번째 숫자를 입력하세요: 121
            두번째 숫자를 입력하세요: 456
            121 + 456 + 577

            2진수, 8진수, 10진수, 16진수로 출력하기.
            i = 32767,  2진수 =  111111111111111
            i = 32767,  8진수 =            77777
            i = 32767, 10진수 =            32767
            i = 32767, 16진수 =             7fff
            */
        }
    }
}
