using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15.Training_PatientManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // .1. Connection
            //4가지 값 기억
            // 1.1 server, db, user id, pw
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=kcesoft.co.kr,1227;Database=test;User ID=test01;password=12341234;";
            con.Open();

            // .2. Command (,) 하면 뜸!!!
            //string query = "Insert Into Patient(ChartNo, PatientName, IDNum, Gender) values('60', '하하하', 12334242, 'F')";
            string query = "Insert Into Patient(ChartNo, PatientName, IDNum, Gender) values(@ChartNo, @PatientName, @IDNum, @Gender)";
            SqlCommand comm = new SqlCommand(query, con);

            //변수parameter 를 선언 -> 선언한 것을 정의 -> 값을 집어넣는 방식 -> Param을 쓰는 이유는, 외부 해킹을 차단하려면 Param 방식을 이용해야함. web이 아니나 기본적으로 이런 방식으로! 

            // 2.1 Parameter 정의
            comm.Parameters.Add("@ChartNo", SqlDbType.VarChar);
            comm.Parameters.Add("@PatientName", SqlDbType.VarChar);
            comm.Parameters.Add("@IDNum", SqlDbType.VarChar);
            comm.Parameters.Add("@Gender", SqlDbType.VarChar);

            // 2.2 Parmeter 에 데이터 등록
            comm.Parameters["@ChartNo"].Value = "63";
            comm.Parameters["@PatientName"].Value = "홍큐캬2";
            comm.Parameters["@IDNum"].Value = 1292939;
            comm.Parameters["@Gender"].Value = "F";

            // .3. Execute
            comm.ExecuteNonQuery();
            // .4. Close
            con.Close();

            label1.Text = "데이터 입력이 성공했습니다. ";
        }

        // 실습 2. 환자 관리 insert & update
        // insert
        private void button2_Click(object sender, EventArgs e)
        {
            // .1. Connection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=kcesoft.co.kr,1227;database=test;user id=test01;password=12341234;";
            //con.ConnectionString = "Server=;database=;user id=;password=;";

            // .2. Connection 에 대한 DB Open
            con.Open();
            
            // .3. Query 
            string query = "Insert Into Patient(ChartNo, PatientName, IDNum, ZipCode, Address, Gender)";
            query = query + $" values ('{textChartNo.Text}', '{textName.Text}', '{textIDNumber.Text}', " +
                $"'{textZipCode.Text}', '{textAddress.Text}', '{textGender.Text}')";
            //앞에서 붙여서 values 앞에 무조건 한칸 띄워야함.  !!!!!!!!!~!~!~!~!~!~!~!~ 
            //매개변수 앞엔 달러처리!

            // .4. Command
            SqlCommand comm = new SqlCommand(query, con);
            // .5. Execute
            comm.ExecuteNonQuery();
            // .6. CLOSE
            con.Close();
            //아무 에러 안뜨면 등록됨.
            MessageBox.Show("환자가 등록되었습니다! :D");
        }

        //update
        private void button3_Click(object sender, EventArgs e)
        {
            // .1. Connection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=kcesoft.co.kr,1227;database=test;user id=test01;password=12341234;";
            //con.ConnectionString = "Server=;database=;user id=;password=;";

            // .2. Connection 에 대한 DB Open
            con.Open();

            // .3. Query 날림 -- update는 여기만 수정!!!
            string query = $"Update Patient Set PatientName = '{textName.Text}', IDNum='{textIDNumber.Text}', " +
                $"ZipCode='{textZipCode.Text}', Address='{textAddress.Text}' where ChartNo='{textChartNo.Text}'";
            
            //앞에서 붙여서 values 앞에 무조건 한칸 띄워야함.  !!!!!!!!!~!~!~!~!~!~!~!~

            // .4. Command
            SqlCommand comm = new SqlCommand(query, con);
            // .5. Execute
            comm.ExecuteNonQuery();
            // .6. CLOSE
            con.Close();
            //아무 에러 안뜨면 등록됨.
            MessageBox.Show("환자가 수정되었습니다! :3");
        }
    }
}
