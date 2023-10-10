using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _15.Training_PatientManagement
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //비연결지향 방법
            // db-da-ds-form

            // .1. Connection 생성
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=kcesoft.co.kr,1227;Database=test;User id=test01;Password=12341234;";

            // .1.1 자동 오픈 : 자동으로 처리되는 것.
            con.Open();

            // .2. DataAdapter 생성
            SqlDataAdapter adapter = new SqlDataAdapter();

            // .3. 쿼리 작성
            string query = "select * from Patient";

            // .4. Select Command 만들기 -> 통해 data 가져옴.
            adapter.SelectCommand = new SqlCommand(query, con); // adapter에 selectcommand 안에
            //SqlCommand comm = new SqlCommand(쿼리, 커넥션객체);

            // .5. Data Set 만들기.
            // dataSet에다가 데이터를 넘겨줘야함= 메모리. (fill 메소드)
            DataSet ds = new DataSet();

            // .6. Data Adapter에서 가져온 내용을 Data Set에 채우기.
            adapter.Fill(ds);   //Fill 메서드는 테이블 스키마(구조)와 데이터를 가져온다. (테이블 이름은 동일함)
                                //Patient 라는 dt가 만들어진다.

            // .7. 자동 종료
            con.Close();

            // .8. 가져온 데이터를 화면에 보여주기.
            dataGridView1.DataSource = ds.Tables[0].DefaultView; //data set 테이블의 0번에 있는 디폴트 뷰
            //DataGridView 데이터를 가져와서 엑셀의 시트처럼 만들어주는 표. DB를 grid라고 함.

            // 비연결지향 3. Data Set 으로  작업하기!!
            //다시 돌려주기.db - da - ds(메모리)
            DataTable dt = ds.Tables[0];    //Patinet 테이블  -> ds에 있는 0번쨰 테이블을 dt에 넣는다.
           
            lblCount.Text = dt.Columns.Count.ToString(); //column 갯수 카운트
            lblRow.Text = dt.Rows.Count.ToString();   //row  갯수 카운트

            //컬럼이름 알아내기 -> list view에
            for (int i = 0; i < dt.Columns.Count; i++)
            {   //DataColumn collection 에서 하나하나 읽어들임.
                string columnName = dt.Columns[i].ColumnName;  //dt의 컬럼의 i번쨰의 컬럼네임을 columnName에 넣고,
                listBox1.Items.Add(columnName);                //listbox에 표시함.
            }

            

            //테이블에 있는 행 컬렉션의 자료를 가져오기,.
            DataRowCollection drc = dt.Rows;       //dt -> collection[0~9] rows 에 넣음. 

            //한 행씩 읽으면서 특정한 열의 Data 가져오깅 -> row를 한줄씩 읽으며 이름만 가졈옴.
            foreach (DataRow item in drc)       //DataRow = 한줄 
            {
                //Debuggin 점찍고 F11 로 하나씩 가져오는걸 볼 수 있다.
                string name = item["PatientName"].ToString();   //Item에 환자이름을 가져와 name (지역)변수에 넣음
                //string inNum = item["IdNum"].ToString();
                listBox2.Items.Add(Name);
            }

            foreach (DataRow dr in drc)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    Console.Write("{0,15}", dr[i]);
                    Console.WriteLine();
                    listBox3.Items.Add(dr[i]);//notdr
                }
            }
        }
    }
}