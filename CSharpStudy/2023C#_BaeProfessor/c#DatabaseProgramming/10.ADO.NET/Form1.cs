using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _10.ADO.NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //The following example uses multiple DataColumn objects to create a DataTable for .
        private void MakeTable()
        {
            //create a DataTable
            DataTable dt = new DataTable("product");

            //create a DataColumn and set various properties.
            DataColumn column = new DataColumn();
            column.DataType = System.Type.GetType("System.Decimal");
            column.AllowDBNull = false;
            column.Caption = "Price";
            column.ColumnName = "price_sc_etc";
            column.DefaultValue = 25;

            // add the column to the table.
            dt.Columns.Add(column);

            // add 10 rows and set values.
            DataRow row;

            for (int i = 0; i < 10; i++)
            {
                row = dt.NewRow();
                row["Price"] = i + 1;

                // be sure to add the new row to the
                // DataRowCollection
                dt.Rows.Add(row);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //// 1st Method
            //// 1. using sql 문을 쓰거나, 
            //// 2. SqlConnection  + ctrl .을 써야함 단어와 단어 사이는 대문자
            //SqlConnection conn = new SqlConnection(connString);
            //string connString = "Server=kcesoft.co.kr,1227;Database=test;User ID=test01;Password=12341234;";


            //// 2st Method
            // 0. DB  -->  1. 커넥션 --> 2. 커맨드 
            SqlConnection conn = new SqlConnection();
            //DB 커넥션(DB 연결 제일 처음과정) 과정을 거치러면 속성값을 줘야한다.
            //Connection 객체의 속성중에 ConnectionString 값을 설정
            conn.ConnectionString = "Server = kcesoft.co.kr,1227; Database = test; User ID = test01; Password = 12341234; ";

            

            conn.Open();

            label1.Text = "데이터베이스가 연결 되었습니다.";
            label2.Text = conn.Database;            //DB 이름
            label3.Text = conn.DataSource;          //DB 소스
            label4.Text = conn.ServerVersion;       //Sql 서버버전 
            label5.Text = conn.State.ToString();    //Open한 상태  
            label6.Text = conn.WorkstationId;       //접속 pc 

            conn.Close();
            label5.Text = conn.State.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // .1. Connection 설정
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server=kcesoft.co.kr,1227;Database=test;User id=test01;password=12341234;";

            // .2. DB 열기
            conn.Open();

            // .3. Command 생성
            //SqlCommand comm = new SqlCommand(명령(쿼리),연결객체)
            //여러가지 데이터 스타일이 나오는데, 여기에 comdText랑 connection 객체를 연결해줘야함.
            string query = "Insert into Patient(ChartNo, PatientName, IDNum, Gender) values('190', '홍캬캬', 393933, 'F' );"; //쿼리문을 문자로 만듬.
            SqlCommand comm = new SqlCommand(query, conn);

            // .4. 명령어 실행
            comm.ExecuteNonQuery(); //데이터베이스의 쿼리(Query) 중 Select 명령을 제외한 대부분의 명령을 처리할 수 있다. 반환값은 처리된 행의 개수이다.


            // .5. DB 종료
            conn.Close();

            MessageBox.Show("데이터가 저장되었습니다.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // .1. Connection 설정
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server=kcesoft.co.kr,1227;Database=test;User id=test01;password=12341234;";

            // .2. DB 열기
            conn.Open();

            // .3. Command 생성
            //SqlCommand comm = new SqlCommand(명령(쿼리),연결객체)
            //여러가지 데이터 스타일이 나오는데, 여기에 comdText랑 connection 객체를 연결해줘야함.
            string query = $"Insert into Patient(ChartNo, PatientName, IDNum, Gender) values('{textBox1.Text}', '{textBox2.Text}', {textBox3.Text}, '{textBox4.Text}')"; //'{변수}'
            SqlCommand comm = new SqlCommand(query, conn);

            // .4. 명령어 실행
            comm.ExecuteNonQuery();

            // .5. DB 종료
            conn.Close();

            MessageBox.Show("데이터가 저장되었습니다.");
        }
    }
}
