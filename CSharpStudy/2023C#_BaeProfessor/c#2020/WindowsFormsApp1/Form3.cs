using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        //2-2. 실습3
        private void CalculBtn_Click(object sender, EventArgs e)
        {
            //1. 총 진료비 가져오기 (textBox1.Text에 있는 문자열 값을 숫자로 변환하기)
            int TotalPrice = Convert.ToInt32(textBox1.Text);
            //2.  본인부담금 계산하기

            //2.1 본인부담금은 총진료비 *0.5 50퍼
            //int MyPrice = (int) (TotalPrice * 0.0); //에러내용 정수 * 0.5(실수)= 실수 실수 5,000.0
            double MyPrice = (TotalPrice * 0.5);



            //3. 청구금액을 계산하기
            //3. 청구금액 = 총진료비 - 본인부담금
            double RequestPrice = TotalPrice - MyPrice;


            //4. 본인부담금 계산결과를 화면(textBox2.Text) 컨트롤 속성은 소문자로 식상
            //textBox2.Text = MyPrice.ToString();

            

            //컴마를 사용하여 숫자 표현"{0:0,0}"
            //string.formant("{0}", 123) 0번째 위치에 있는 값 123 -> 0번 위치로 가라.
            //    2*9=18
            //    string.Format("{0} * {1} = {2}", 2, 9,18)  -> 0-2, 1-9, 2번취이 18

            

            //textBox2.Text = string.Format("{0:#,0.000}", MyPrice);  // 0번위치에 있는: 0,0 숫자 세자리가 되면 콤마를 붙여랴 라는 뜻.

            //5. 청구금액을 화면에 출력
            //textBox3.Text = RequestPrice.ToString();
            textBox3.Text = string.Format("{0:#,#}", RequestPrice);

            //숫자를 오른쪽으로 정렬하기 "{0,8:}"
            //금애깅 10원 경우 "    10"
            //금액이 100원 경우 "  100"

            //금액이 0인 경우 공백으로 표현하기 "{0:#,#}"

            //소수점 표현하기 "{0,0:0,0,0}"

            //소수점이 있다면 소수점 3자리 표기 -> 만약 소수점이 없다면 소수점 표기를 안하기, 소수점 4자리까지 계산
            textBox2.Text = string.Format("{0:#,0.#}", MyPrice); 
        }
    }
}
