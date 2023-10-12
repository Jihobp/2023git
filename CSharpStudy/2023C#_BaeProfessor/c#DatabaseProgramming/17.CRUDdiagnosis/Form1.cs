using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;        // ms sql 데이터베이스용 명령
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17.CRUDdiagnosis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 데이터베이스 등록 코딩

            //1. Connection,''
            SqlConnection 연결 = new SqlConnection();
            //어디에다 연결?
            연결.ConnectionString = "server=kcesoft.co.kr,1227;database=test;user id=test01;password=12341234;";

            //2. Open
            연결.Open();

            //3. Query(Insert Into Doctor_pjh)
            //string query = "Insert Into Doctor_pjh values ('00','00','00','00')";   //열값 지정안해서 full
            string query = $"Insert Into Doctor_pjh values ('{textID.Text}','{textName.Text}','{textLicense.Text}'," +
                $"'{textRemark.Text}')";

            //4. Command  --> debugging 중단점 찍기
            SqlCommand 명령어 = new SqlCommand(query, 연결);

            //5. Execute
            명령어.ExecuteNonQuery();

            //6. Close
            연결.Close();

            //7. 메세지 박스 표현하기
            MessageBox.Show("자료가 등룍되었습니당 :3");

            //text 컨트롤 아이디 바꾸기
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 데이터베이스 수정코딩

            //1. Connection,''
            SqlConnection 연결 = new SqlConnection();
            //어디에다 연결?
            연결.ConnectionString = "server=kcesoft.co.kr,1227;database=test;user id=test01;password=12341234;";

            //2. Open
            연결.Open();

            //3. Query(Update Into Doctor_pjh)   Update (tablename) set 열이름1=값1, ..., 열이름n = 값n Where ID=)      
            string query = $"Update Doctor_pjh Set Name ='{textName.Text}','{textID.Text}','{textLicense.Text}','{textRemark.Text}'";

            //4. Command  --> debugging 중단점 찍기
            SqlCommand 명령어 = new SqlCommand(query, 연결);

            //5. Execute
            명령어.ExecuteNonQuery();

            //6. Close
            연결.Close();

            //7. 메세지 박스 표현하기
            MessageBox.Show("자료가 수정되었습니당 :3");

            //text 컨트롤 아이디 바꾸기
        }

        private void button3_Click(object sender, EventArgs e)
        {

            // 데이터베이스 수정코딩

            //1. Connection,''
            SqlConnection 연결 = new SqlConnection();
            //어디에다 연결?
            연결.ConnectionString = "server=kcesoft.co.kr,1227;database=test;user id=test01;password=12341234;";

            //2. Open
            연결.Open();

            //3. Query(Delete 테이블명 where 조건절)    
            string query = $"Delete Doctor_pjh where ID ='{textID.Text}'";

            //4. Command  --> debugging 중단점 찍기
            SqlCommand 명령어 = new SqlCommand(query, 연결);

            //5. Execute
            명령어.ExecuteNonQuery();

            //6. Close
            연결.Close();

            //7. 메세지 박스 표현하기
            MessageBox.Show("자료가 삭제되었습니당 :3");

            //text 컨트롤 아이디 바꾸기
        }


        // 연결지향 데이터 조회하는법 - sql 데이터 리더로 받음. connection-command-SqlDataReader 
        private void button4_Click(object sender, EventArgs e)
        {
            //1. Connection,''
            SqlConnection 연결 = new SqlConnection();
            //어디에다 연결?
            연결.ConnectionString = "server=kcesoft.co.kr,1227;database=test;user id=test01;password=12341234;";

            //2. Open
            연결.Open();

            //3. Query(    -> 한 결과를 DataReader 로 받음
            string query = $"Select * from Doctor_pjh";

            //4. Command  --> debugging 중단점 찍기
            SqlCommand 명령어 = new SqlCommand(query, 연결);

            //5. Execute 실행한 후에 DataReader로 자료를 받기. 
            SqlDataReader 결과값 = 명령어.ExecuteReader();
            while (결과값.Read()) //한줄한줄씩 읽고 listbox 에 뿌려줌.
            {
                string title =$"{결과값["ID"]}\t {결과값["Name"]}\t {결과값["LicenseNo"]}";
                listBox1.Items.Add(title);
            }
            //6. Close
            연결.Close();

            //7. 메세지 박스 표현하기
            MessageBox.Show("자료가 조회되었습니당 :3");

            //select 한 결과는 반드시 sql DataReader로 들어간다. 
        }

        // 비연결지향 데이터 조회하는법 - Data Adapter 로 받음.!!!!!!!!!!connection-DataAdapter-DataSet
        // DAdapter <->   DSet
        // Fill()   <->   Update() 
        private void button5_Click(object sender, EventArgs e)
        {
            //1. Connection,''
            SqlConnection 연결 = new SqlConnection();
            //어디에다 연결?
            연결.ConnectionString = "server=kcesoft.co.kr,1227;database=test;user id=test01;password=12341234;";

            //2. Query(    -> 한 결과를 DataReader 로 받음
            string query = $"Select * from Doctor_pjh";

            //3. Command (x) -> DataAdapter
            SqlDataAdapter 어댑터 = new SqlDataAdapter();

            //데이터 어댑터는 4가지 command( select, update, delete, insert)
            어댑터.SelectCommand = new SqlCommand(query, 연결);

            //4. DataSet == 데이터 구조에서 'Table' 과 같다. 데이터셋에 닥터tb 가 들어감!!
            DataSet 데이터집합 = new DataSet(); //데이터집합안에 select * from ~이 들어가 있다.

            //6. DataAdapter -> DataSet 결과값을 저장
            어댑터.Fill(데이터집합);

            DataTable 테이블 = 데이터집합.Tables[0]; // 데이터집합 테이블즈의 0번째 값을 테이블에 넣고,(dataset!)
            DataRowCollection 결과값 = 테이블.Rows; // 테이블의 Rows 들을 결과값 안에 넣어줌.
            //ㄴ > collection 은 Row, column 들을 관리해주는 것!

            //7. 화면에 표시(한줄한줄)
            foreach (DataRow item in 결과값)
            {
                string title = $"{item["ID"]}\t {item["Name"]}\t {item["LicenseNo"]}"; //한줄에 해당하는 컬럼들을 넣는다.
                listBox2.Items.Add(title); //lb2의 items에 add 해라.타이틀들을!
            }

            //8. 메세지 박스 표현하기
            MessageBox.Show("자료가 조회되었습니당 :3");

            //select 한 결과는 반드시 sql DataReader로 들어간다. 
        }
    }
}
