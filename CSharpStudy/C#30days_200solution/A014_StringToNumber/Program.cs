using System;

namespace A014_StringToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int value;

            Console.WriteLine("1. int로 변환할 문자열을 입력하세요: ");  //입력을 안내하는 문자열 출력
            input = Console.ReadLine();                                 // Console.ReadLine()으로 문자열을 입력받아 string input에 저장.
            bool result = Int32.TryParse(input, out value); // 해석 ?  ?  Int32.TryParse() 메소드로 input을 정수 value로 변환함.
                                                            // 변환이 성공하면 bool result는 true가 되고, 실패하면 false 가 됨.
            if(!result)                                     // bool result 값에 따라, 
                Console.WriteLine("'{0}'는 int로 변환될 수 없습니다.\n", input); //실패하면 "int로 변환될 수 없습니다 출력."
            else
                Console.WriteLine("int '{0}' 으로 변환되었습니다.\n", value);    //성공하면 value 값 출력.
            
            Console.Write("2. double로 변환할 문자열을 입력하세요: ");
            input = Console.ReadLine();
            try                             //try 입력후 tab tab-> try catch 문! 
            {                               //예외==error가 발생 하였을때, 처리하는 문장.
                double dbl = Double.Parse(input); //double.Parse() 메소드로 input을 double cvt로 변환하고 출력.
                double cvt = Convert.ToDouble(input);   //convert 클래스의 메소드들은 Parse()와 똑같이 동작함. 25번째 줄의 Double.Parse() 부분을 Convert.ToDouble()로 바꾸면 똑같이 동작하는 프로그램이됨. 
                Console.WriteLine("double '{0}'으로 변환되었습니다. \n", cvt);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message); //에러 발생시, 시스템에서 제공하는 error=exception 메세지 출력. 
            }

            // TryParse()는 리턴 값으로 true와 false를 주어 예외상황에 따른 처리가 가능하지만 Parse()는 에러가 나면 프로그램이 그대로 종료됨.
            // try 블럭에서 어떤 에러인지 정보를 제공하고 처리할 수 있도록 해줌

            /*결과
             * 1. int로 변환할 문자열을 입력하세요:
                123
                int '123' 으로 변환되었습니다.

                2. double로 변환할 문자열을 입력하세요: -1.23e5
                double '-123000'으로 변환되었습니다.

                1. int로 변환할 문자열을 입력하세요:
                123.45
                '123.45'는 int로 변환될 수 없습니다.

                2. double로 변환할 문자열을 입력하세요: -123.45d
                Input string was not in a correct format. : 입력 문자열의 형식이 잘못되었습니다.
             */
        }
    }
}

