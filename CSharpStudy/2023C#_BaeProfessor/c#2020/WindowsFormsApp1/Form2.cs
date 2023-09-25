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
    //2.1 변수~ data type 할당, 형변환.
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //2.2강 실습2
        private void CalculBtn_Click(object sender, EventArgs e)
        {
            //금액을 계산하는 코딩

            int a = Convert.ToInt32(text단가.Text); //문자를 숫자로 암시적으로 형변환x
            int b = Convert.ToInt32(text수량.Text); //문자를 숫자로 명시적으로 형변환o
            int c = a * b; //금액 계산하기

            text금액.Text = c.ToString(); //숫자(정수형) -> 문자로 형변환.



            //2강 실습 2 온라인 쇼핑몰 물건값을 계산하는
            //상품명   단가 수량 금액 (직접 입력)
            //운동화   200    2    400
            //금액(계산) = 단가 * 수량

        }
    }
}
