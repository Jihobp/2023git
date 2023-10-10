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

            //3. Query(Update Into Doctor_pjh)        
            string query = $"Update";

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
    }
}
