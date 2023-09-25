using System;

namespace A012_FloatDoubleDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            float flt = 1F / 3;     // float 변수 flt를 선언하고, 1F/3을 계산하여 저장. 1F는 float 1 을 의미.
            double dbl = 10 / 3;    //double 변수 dbl를 선언하고, 1D/3을 계산하여 저장. 1D는 double 1을 의미.
            decimal dcm = 1M / 3;   //decimal 변수 dcm를 선언하고, 1M/3을 계산하여 저장. 1M은 decimal 1을 의미.

            Console.WriteLine("float : {0}\ndouble : {1}\ndecimal : {2}", flt, dbl, dcm);   // 세 변수의 값 출력. float<double<decimal 순으로 정밀도가 높음.
            Console.WriteLine("float : {0} bytes\ndouble : {1} bytes\ndecimal : {2} bytes", sizeof(float), sizeof(double), sizeof(decimal));
            Console.WriteLine("float : {0}~{1}", float.MinValue, float.MaxValue);   //sizeof() 메소드-크기를 byte 단위로 리턴-를 사용하여, float,double, decimal 의 크기 출력. 
            Console.WriteLine("double : {0}~{1}", double.MinValue, double.MaxValue);
            Console.WriteLine("decimal : {0}~{1}", decimal.MinValue, decimal.MaxValue); //최소값 최대값 출력.

            /*결과
             *  float : 0.33333334
                double : 3
                decimal : 0.3333333333333333333333333333
                float : 4 bytes
                double : 8 bytes
                decimal : 16 bytes
                float : -3.4028235E+38~3.4028235E+38
                double : -1.7976931348623157E+308~1.7976931348623157E+308
                decimal : -79228162514264337593543950335~79228162514264337593543950335
             */
        }
    }
}
