using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp28 //namespace : 일종의 폴더
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //2.1 데이터타입 변수명;
        private void button1_Click(object sender, EventArgs e)
        {           
            int a;  //a라는 변수를 선언
            a = 10; //a에 10이란느 정수형 숫자를 할당 : 할당은 오른쪽의 값이 왼쪽으로 넘어가는 것.

            //암시적으로 'double' 형식을 'int' 형식으로 변환할 수 없습니다.
            //명시적 변환이 있습니다. 
            //cast가 있는지 확인하세요.
            //10.3 이라는 data type :  double 
            //정수 : 1과 2사의의 숫자는 없다.
            //실수 : 1과 2사이에는 무한대의 숫자가 존재
            //a = 10.3; 


            //정수 < 실수

            //cast ->  data type 을 반환한다. (형변환)
            //객체지향언어(c++, c#, java 등) 는 형변환이 엄격하다.

            //명시적 형 선언
            a = (int)10.7; //10

            //암시적 형 변환
            //큰거에서 작은거로 들어갈 때는 자동으로 형변환
            double b;
            b = 10; //b =10.0;


            //변수는 변하는 수 : b
            //상수는 변하지 않는 수 : 10

            string x;
            x = "안녕하세용";    //문자형 상수 :  안녕하세용

            //따옴표 Quotation marks, 

            MessageBox.Show("HELLO");
            MessageBox.Show(a.ToString());
            MessageBox.Show(b.ToString());
        }

        //2.2 c#의 기본문법 : Value Type과 Reference Type
        private void button2_Click(object sender, EventArgs e)
        {
            //버튼 2를 클릭한 경우 동작을 한다. (event)

            //vaule type 정의

            int a = 10;         //정수형 데이터 타입
            double b = 20.3;    //실수형 데이터 타입

            bool c = true;      //논리형(불) 데이터 타입
            char x = 'a';       //한 글자를 기억하는 데이터 타입
            string y = "Hello????"; //여러문자를 기억하는 데이터 타입

            person 홍길동;
            홍길동.num = 1;
            홍길동.age = 10;
            홍길동.weight = 60.6;          //double 8b : 실수 : 실수의 기본은 double이라서 180.3하면 에러뜬다.
            홍길동.height = (float)180.3; //float 4b : 실수
            홍길동.height = 180.3F;       //float 4b : 실수
        }

        //2.3 함수
        private void button3_Click(object sender, EventArgs e)
        {
            //함수 설명

            //국어, 여엉, 수학 입력을 하면 총점
            int 총점 = GetTotal(100, 80, 90);
            MessageBox.Show(총점.ToString());
        }

        private int GetTotal(int kor, int eng, int math) //함수 = oo에선 함수라 하지않고 method !!
        {
            int sum = kor + eng + math;
            return sum;
        }

        //2.4 제어문 -> selection statement, iteraction statement, jump statement 
        private void button4_Click(object sender, EventArgs e)
        {
            int a = 10;
            int b = 20;

            if(a == b)  
            {
                //참이면 이곳을 실행
                MessageBox.Show("=");
            }
            else
            {
                //거짓이면 이곳을 실행
                MessageBox.Show("!=");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {   //다양한 조건절
            int age = 10;
            if (age < 10)
            {
                MessageBox.Show("baby");
            }
            else if (age < 20)
            {
                MessageBox.Show("child");
            }
            else if(age < 30)
            {
                MessageBox.Show("grown-up");
            }
            else
            {
                MessageBox.Show("Adult..");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int num;
            num = 9; //할당? 오른쪽의 값을 왼쪽에 넣어주는 것. 
            switch (num)
            {//open braces, colsed braces?  Square brackets, Curly braces
                case 1:
                    MessageBox.Show("일");
                    break;
                case 2:
                    MessageBox.Show("이");
                    break;
                case 3:
                    MessageBox.Show("삼");
                    break;
                default:                    //Like the else in an if statement
                    MessageBox.Show("I don't Know");
                    break;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {   //for > repeat, while > exit
            //for (int i = 0; i < 10; i++)
            //{
            //    //i가 0에서 9까지 총 10번 반복.
            //    MessageBox.Show(i.ToString());  
            //}

            for (int i = 0; i < 3; i++) //total 6
            {
                //i가 0에서 2까지 초 3번 반복
                for (int j = 0; j < 2; j++)
                {
                    //j가 0에서 1까지총 2번 반복.
                    MessageBox.Show(i.ToString()+" : " + j.ToString()); //Change to string because it's a number !
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int a = 0;
            while (a < 10)  //a는 0 부터 9까지 반복
            {
                MessageBox.Show(a.ToString());
                a = a + 1;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                MessageBox.Show(i.ToString());

                //중간에 반복문 밖으로 빠져나올때 사용하는 문장 : break : 하위로
                if (i == 3)
                {
                    break;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0) //Even num
                {
                    continue;   //Always count odd numbers
                }
                MessageBox.Show(i.ToString());
            }

            //돌아감 : continue : 상위로
        }

        private void button11_Click(object sender, EventArgs e)
        {
            학생 홍길동;              //클래스를 객체화 시키는 방법
            홍길동 = new 학생();     //new! 라는 조건이 heap을 생성
            홍길동.num = 10;
            홍길동.age = 20;
            홍길동.height = 190.2;

            학생 철수 = new 학생();   //클래스를 객체화 시키는 방법
            철수.num = 10;
            철수.age = 20;
            철수.height = 190.2;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            학생 철수 = new 학생(); //클래스를 객체화 시키기 ?!
            철수.height = 158;
            철수.weight = 52;

            string 결과 = 철수.비만도판단하기();

            MessageBox.Show(결과);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            학생 철수 = new 학생();
            철수.num = 10;

            //철수.name = "김철수";       //<- 여기서 직접 접근은 안되지만!
            철수.이름설정하기("뿌이");   //method를 통해 접근가능!
            string 이름 = 철수.이름가르쳐주기();   //return 값 저장! 철수/ 영희 각각
            MessageBox.Show(이름);
            string 이름2 = 철수.이름설정및가르쳐주기("뿌이");
            MessageBox.Show(이름2);
            //etc = "누구양?!!";   ???

            //why new 로 직접 쓰면 안되낭?
            /* s  이름 설정하기에 void를 string으로 바꾸고 return name; 을 추가하면 바로 name이 확인될 수 있
            그런데 아무래도 name = 이름으로 할당하는 과정과, 
            name값을 구별한 것은 name이라는 변수에 값을 할당하는 데 더욱 신중하기 위해서 인 것 같아요! 
            만약 한 함수에 해당 기능 다 집어 넣으면 name이라는 변수에 다른 이름이 할당 될 가능성이 있고
            또 실무자에게 들었을 때 잘짠 코드는 함수로만 이루어진 코드라고 들은 적도 있어요! 
            그만큼 데이터가 통제된 상태에서 결과값을 불러오기 위해 그러는 것 같아요
            */
        }

        private void button13_2_Click(object sender, EventArgs e)
        {
            TopSecret t = new TopSecret();  //클래스를 객체화 시키기!
            t.SetSecret(1000);              //private 멤버 변수에 값을 할당하는 함수 set  (TopSecret 클래스 객체의 SetSecret 함수를 쓰고 값 할당.
            int s = t.GetSecret();          //private 멤버 변수의 값을 얻어오는 함수 get
            MessageBox.Show(t.ToString());  //당연히 값이 get 하지 않았으니까! 
            MessageBox.Show(s.ToString());
            MessageBox.Show(t.GetSecret().ToString());
        }

        // 3.3.3 값타입과 참조타입의 비교 -> 값 타입
        private int add(int a, int b)
        {
            a = 100; b = 200;
            int 결과 = a + b;
            return 결과;
        }
        private void button14_Click(object sender, EventArgs e)
        {
            int a = 10, b = 20;     // 주소 값이 다르다~! 서울의 ab와 부산의 ab는 다르다. = > value 타입
            int 결과 = add(a,b);
            MessageBox.Show(결과.ToString()); //300임
        }


        //    3.3.3 값타입과 참조타입의 비교  -> 참조타입
    }//클래스의 마지막 부호 
    //udd :user define datatype 

    class 학생                  //16b //참조형 데이터 타입 
    {   //변수 x, 멤버필드O
        public int num;         //4b
        public int age;         //4b
        public double height;   //8b
        public double weight;

        //클래스의 capsulation 캡슐화 = 내부를 보호함 = 1. 접근제어!
        private string name;    //이름 //변수에 접근  //학생 클래스에서만 사용되게!
        string alias;           //별명  -> 접근제어를 안쓰면 기본적으로 private default!!!!!
        public string etc;
        
        //3.2.3 private에 접근하는 법 
        //외부에서 접근하도록 public 메소드 생성
        public void 이름설정하기(string 이름) //void는 결과 값을 알려주지는 않는다! 하지만 name이란 공간에 "이름"이라는 값을 연결해주는 역할까지 했고, 이를 바탕으로 이름바꾸기 메소드 에서는 name에 연결된 값을 return해주는 역할을 한다요!! 
        {
            if (이름 == "뿌이")
            {
                MessageBox.Show("뿌이쓰는 이름을 등록할 수 없습니다.");
            }
            name = 이름;
        }

        //학생의 이름을 얻기 위해서! -> 외부에서 알 수 있도록 메서드 생성    --->>>> Q. 직접적으로 접근하면 쉬운데 차단성을 제어하기 위해 따로  함수를 만들고, 그걸return 하는 함수도 만들구?? 
        public string 이름가르쳐주기()
        {
            return name;
        }

        public string 이름설정및가르쳐주기(string 이름)
        {
            if (이름 == "뿌이")
            {
                MessageBox.Show("쁘이는 이름을 등록할 수 없습니다.");
                return name; // 특정한 오류 상황을 나타내기 위해 null을 반환
            }
            else
            {
                name = 이름;
                return name;
            }          
        }

        public string 비만도판단하기() //Method
        {
            name = "김철수";           //private 멤버필드는 내부에서 사용가능
            etc = "누구양?!!";
            double 표준체중 = (height - 100) * 0.9;
            double 비만도 = weight / 표준체중;

            string 판정;
            if (비만도 < 0.9)
            {
                판정 = "저체중";
            }
            else if(비만도 < 1.1)
            {
                판정 = "정상";
            }
            else
            {
                판정 = "과체중";
            }
            return 판정;
        }       
    }

    public class TopSecret              //class 안에 데이터+함수 or 구조체 +함수
    {
        private int secret;             //private 멤버 변수 선언
        public void SetSecret(int x)    //private 에 접근하는 public 멤버 변수
        {
            x = 999;
            secret = x;
        }
        public int GetSecret()          //private 멤버의 값을 외부로 내보내기
        {
            return secret;              //private에 접근하는 public 멤버 함수
        }
    }
    struct person              //20b //값형 데이터 타입    //new! 안쓱 바로 씀.
    {
        public int num;        //4b
        public int age;        //4b
        public double weight;  //8b
        public float height;   //4b
    }
}
