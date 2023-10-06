using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //어떤 자료를 사용하맂 결정

namespace WindowsFormsApp1 //일종의 폴더
{
    //f5
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 2.1.1 데이터 타입 :  메모리를 생성하기 위한 도구.
        // 데이터 타입은 메모리의 크기size와 형태type을 지정하는 도구이다.
        //  EVENT
        private void button1_Click(object sender, EventArgs e)
        {
            //데이터타입 변수명;
            //데이터 타입 변수명;
            //MessageBox.Show("안녕하세요.");
            int a; //a라는 변수 선언 == a라는 변수를 메모리에 생성시켜라,
            a = 10; //a에 10이라는 정수형 숫자를 할당, 넣어라.
                    //ab = 10.3; // 암시적으로 'double' 형식을 'int' 형식으로 변환할 수 없다.
                    //명시적 변환이 있습니다.
                    //캐스트가 있는지 확인하세요.
                    //10.3 ->  data type : double
                    //정수 :  1과 2 사이에 숫자는 없어요.
                    //실수 :  1과 2 사이에 무한대의 숫자가 존재.
                    // 정수 <  실수 (실수가 크다)
                    // re. 큰거 에다 작은걸 넣으면 에러가 뜬다.
                    // 명시 :  직접 선언하는 것,
            a = (int)10.3;   //결과는 10, 정수 밑은 다 짤린다.
                             //cast -> data type을 변환한다. (형변환)
                             //객체지향언어 (c++, c#, java 등) 형변환이 엄격하다.
                             //            -변수 선언
                             //- a = 10; 오른쪽에 있는 값을 왼쪽에 넣어준다 = 할당
                             //- 캐스트 : data type을 변환한다. (형변환)
                             //명시적 형변환 : 명시적 형을 선언했다.
                             //암시적 형변환: 큰거에서 작은거로 들어갈 때는 자동으로 형변환 된다.
            double b;  //data type 선언
            b = 10; //b = 10.0;


            //변수 :  변하는 수 : b
            //상수 :  변하지 않는 수 : 10

            int d = 20;
            a = d; // d에 있는 20이 a로 할당
            a = (int)b;  // 암시적 형변환, 명시적 형변환
                         //암시적 형변환은 큰곳에 작은것을 할당(암시적 형변환)
                         //실수 1~2사이에는 아주 많은 데이터가 존재를 하고 있다.
                         //1.1 1.11 1.111 아주 많은 데이터가 있다.
                         //정수 1~3사이엔 딱 하나의 데이터가.
                         //2라는 정수값 한개만 존재를 함
            b = a; //a=10l b=10.0; 할당

            string x;
            x = "안녕하세요"; // 문자형 상수 : 안녕하세요
            MessageBox.Show(a.ToString()); //출력
        }



        //2.2.2 Value 타입의 종류
        private void button2_Click(object sender, EventArgs e)
        {
            //버튼2를 클릭한 경우 동작을 한다.

            //value type 정의
            //built - in value type

            int a;              //정수형 데이터 타입
            double b = 20.3;    //실수형 데이터 타입

            bool c = true;      //논리형(불) 데이터 타입

            char x = 'a';       //한 글자를 기억하는 데이터 타입

            string y = "안녕하세요"; //여러문자를 기억하는 데이터 타입 (double quatation?)


            person 홍길동;
            홍길동.num = 1;
            홍길동.age = 10;
            홍길동.weight = 60.6;                //double 8byte : 실수
            홍길동.height = (float)180.3;        //float 4byte : 실수
            홍길동.height = 180.3F;              //float 4byte : 실수


            //user define value type  = heap, ref
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //함수 설명

            //국어, 영어, 수학 입력을 하면 총점
            int 총점 = GetTotal(100, 80, 90);
            MessageBox.Show(총점.ToString());  //총점은 무조건 문자로 바꿔야함. ToString

        }

        //총점을 구하는 함수 = o.o 에선 함수가아닌 method 라고 함.
        private int GetTotal(int kor, int eng, int mat)
        {
            int sum = kor + eng + mat;
            return sum; //need return
        }


        //2.4.1 제어문
        private void button4_Click(object sender, EventArgs e)
        {
            //선택문 selection statement
            int a = 10;
            int b = 10;

            if (a != b)     //같다라는 부등호는 ==, 다르다 !=
            {
                //참이면 이곳을 실행
                MessageBox.Show("다르다");
            }
            else
            {
                //거짓이면 이곳을 실행
                MessageBox.Show("같다");
            }
        }


        //선택문 (Selection Statement)  : 프로그램 내에서 주어진 조건에 따라 실행여부를 결정하는 제어문

        //범위 조건값 = if문
        private void button5_Click(object sender, EventArgs e)
        {
            int age = 10;

            if (age < 10)
            {
                MessageBox.Show("유아");
            }
            else if (age < 20)   //10보다 크고 20보다 작은 경우
            {
                MessageBox.Show("청소년");
            }
            else if (age < 30)   //20보다 크거나 같고  30보다 작은 경우
            {
                MessageBox.Show("청년");
            }
            else
            {
                MessageBox.Show("성인");
            }
        }

        //단일 비교값 = switch-case 문(Selection Statement)
        private void button6_Click(object sender, EventArgs e)
        {
            int num;
            num = 9;
            switch(num)
            {
                case 1 :
                    MessageBox.Show("일");
                    break;
                case 2 :
                    MessageBox.Show("이");
                    break;
                case 3 :
                    MessageBox.Show("삼");
                    break;
                default:    //if 문장의 else 와 동일한 내용
                    MessageBox.Show("모르겠다.");
                    break;
            }
        }


        //반복문 Iteration Statement. for, while. - 특정 조건이 만족할 때까지 계속해서 반복하는 제어문
        //for 문을 이용한 반복문 - 초기화, 조건식 , 스텝 (한계-범위에 따라 정해진 횟수만큼!)
        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                //i가 0에서 2까지 총 3번을 반복한다.
                for (int j = 0; j < 2; j++)
                {
                    //j가 0에서 1까지 총 2번 반복 -> 1에서 2번, 2에서 2번, 3에서 3 번
                    MessageBox.Show(i.ToString()+" : " +j.ToString());      //total 6번
                }
            }
        }

        //while 문을 이용한 반복문 - 조건을 만족할때까지 (특정 조건에 의해서만!)
        private void button8_Click(object sender, EventArgs e)
        {
            int a = 0;
            while (a<10)    //a는 0부터 9까지 반복
            {
                MessageBox.Show(a.ToString());
                a = a + 1;
            }
        }

        //분기문 Jump Statement; break;continue;- 조건문이나 반복문 등에서 특정한 지점으로 제어권을 이동시키는 분기 명령문
        //break
        private void button9_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                MessageBox.Show(i.ToString());
                //중간에 반복문 밖으로 빠져 나올때 사용하는 문장
                //break

                if (i == 3) //3이 될때 벗어남!
                {
                    break;
                }
            }
        }

        //continue
        private void button10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if(i % 2==0)    //짝수 i를 2로 나누었을 때 나머지가 0이라면 짝수
                {
                    continue;
                }
                MessageBox.Show(i.ToString());
            }
        }


        //2강 실습 1 계산을 원하는 코딩을 작성
        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            //이벤트 메소드   //우클릭 -> 디자이너보기 (shift f7)
            

            //Data Type 변수, 형변환
            //받은 돈 변수에 할당 (textBox1.Text=> 문자열) 5454, 50 등 다 문자임. (형변환 해야함)
            //문자를 숫자로 바꾸어주는 형변환 해야함.
            int a = Convert.ToInt32(textBox1.Text);  //암시적으로 string 형식을 int 형으로 변환할 수 없다는 오류가 뜸.
            int b = Convert.ToInt32(textBox2.Text); //물건값 문자를 숫자로 형변환, b에 할당.

            //거스름돈을 구하는 과정
            int c = a - b;

            textBox3.Text = c.ToString();   //textBox3.Text 값을 할당한 후 화면에 나타나는 코딩         
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Top t = new Top();
            t.a = 100;
            t.b = 200;
            int c1 = t.GetData();
            MessageBox.Show(c1.ToString());
        }
    } //class 클래스의 마지막 부호

    public class Top
    {
        public int a;
        public int b;
        //--여기까지 변수로 구성되어진 클래스 : 8바이트짜리 메모리 지도


        public int GetData()
        {
            return a + b;
        }
        //--변수에 함수도 추가되어진 클래스. 함수는 메모리 지도에 포함되지 않는다. 메로리 지도로 만든 메모리를 사용할 특권이 있다.
    }

    //2.2.3 struct -> 클래스 마지막 부호 바깥에 선언해야함
    struct person   //20 byte의 크기, Person 구조체는 20 byte짜리 데이터 타입, 형태는 int+int+double+float
    {
        //public 선언!!
        public int num;    //번호 4byte
        public int age;    //나이 4byte
        public double weight;  //몸무게 8byte
        public float height;   //키 4byte
    }
}
