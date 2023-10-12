using System;
using System.Data;
using System.Windows.Forms;

namespace _20.DaaSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // (1) DataSet, BindingSource, TableAdapter만 남기고 삭제

        //private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.patientBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.dataSet1);

        //}

        //Form 이 호출 됐을때 타는 이벤트.
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.PatientInsurance' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            //this.patientInsuranceTableAdapter.FillByList(this.dataSet1.PatientInsurance);
            // TODO: 이 코드는 데이터를 'dataSet1.Patient' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.patientTableAdapter.Fill(this.dataSet1.Patient); // 연결정보 x PatientInsurace 정보만 가져옴. -> 선택된 select 된 정보를 가져오고싶기 때문에
            //27 번쨰 줄 FillByList 로 바꿔준다. ()쿼리문~

            //Fill로 채우는데, this.데이터셋의 Patient 테이블에 채워라!
            //- 조건절을 안달았으므로 모든 데이터 호출 (
            //-fill 메소드를 호출하면 → select 명령어 Command 실행,
            //-DataSet1 의 Patient 테이블에 데이터가 채워진다!
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ComboBox에서 입력된 내용을 바인딩하기
            DataRowView drv = (DataRowView)patientBindingSource.Current;
            // ! Error : 암시적으로 'object' 형식을 'System.Data.DataRowView' 형식으로 변환할 수 없습니다. 명시적 변환이 있습니다. 캐스트가 있는지 확인하세요
            //데이터형 형변환 = cast  -> DataRowView 를 넣어줌.
            drv["Gender"] = cboGender.Text == "남자" ? "M" : "F";
            drv[3] = cboBirthdayType.Text == "음력" ? "1" : "";
            drv[16] = cboForeign.Text == "외국인" ? "Y" : "N";
            drv[17] = cboSns.Text == "예" ? "Y" : "N"; 

            //Dataset에 수정한 결과가 반영됨
            //저장되는 반영 조건은, 행이 바꼈을떄지만, ! 그냥 바로 저장되게 하고싶다.
            patientBindingSource.EndEdit();

            //데이터베이스에 저장하기
            patientTableAdapter.Update(dataSet1.Patient);   //데이터셋1에 있는 p테이블에 -> Dataset에 변경된 내용이 DB에 저장
            MessageBox.Show("저장완료:ㅇ");
            // 아직은 저장하고 다시 시작해야 작동됨!
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //신규 환자 등록 -> btn 클릭후 자동 초기화 및 데이터 입력 행 나옴
            patientBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //삭제 -> 현재 선택된 행의 데이터 삭제 (but, 메모리에서만[win.form]삭제되지 업데이트 및 반영 안했기 때문에 db엔 반영 xx)
            patientBindingSource.RemoveCurrent();

            // DB 에 저장 ( db -> (adapter(x)) -> dataset.xsd
            // da의 Update(); -> insert, update, delete
            patientTableAdapter.Update(dataSet1.Patient);   //업데이트 데이터 입력하고 저장 누르기.~
        }

        private void patientDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //DataGridView에서 현재 선택된 행row의 cell 값을 가져오는 코딩 ㅇㅅㅇ

            int rowIndex = patientDataGridView.CurrentRow.Index; //현재 선택된 행의 인덱스-배열의 위치 가져옴

            //현재 선택된 행의 5번 컬럼(성별) 가져오기
            string gender = patientDataGridView.Rows[rowIndex].Cells["colGender"].Value.ToString(); //5번째 위치의 값을 문자로 가져오면
            cboGender.Text = gender == "M" ? "남자" : "여자"; //단일문자
            //if (gender == "M") { cboGender.Text = "남자"; } else { cboGender.Text = "여자"; }

            //현재 선택된 행의 4번째 컬럼(생일 유형) 가져오기
            string birthdayType = patientDataGridView.Rows[rowIndex].Cells[3].Value.ToString();
            cboBirthdayType.Text = birthdayType == "1" ? "음력" : "양력";
            //if (birthdayType == "1") cboBirthdayType.Text = "음력"; else cboBirthdayType.Text = "양력";

            //현재 선택된 행의 17번째 컬럼(외국인 유형) 가져오기
            string foreignTypeYN = patientDataGridView.Rows[rowIndex].Cells[16].Value.ToString();
            //삼항연산자 - 단일값은 이렇게 간단히 코딩! 
            //cboForeign.Text = foreignTypeYN == "Y" ? 참: 거짓,
            cboForeign.Text = foreignTypeYN == "Y" ? "외국인" : "내국인";

            //현재 선택된 행의 18번째 컬럼(문자 전송 유무) 가져오기
            string snsYN = patientDataGridView.Rows[rowIndex].Cells[17].Value.ToString();
            cboSns.Text = snsYN == "Y" ? "예" : "아니오";

            //해당하는 차트번호를 구하기
            string chartNo = patientDataGridView.Rows[rowIndex].Cells["colChartNo"].Value.ToString();
            this.patientInsuranceTableAdapter.FillByList(this.dataSet1.PatientInsurance,chartNo); //string ChartNo를 안붙여서 에러.                                                                                         
            // ! Error : ~에서 필요한 정식 매개 변수 'ChartNo'에 해당하는 제공된 인수가 없습니다. 
            //, "인수"는 함수나 메서드에 전달되는 값으로, 함수 또는 메서드를 호출할 때 사용됩니다.
            //반면 "변수"는 프로그램에서 데이터를 저장하고 조작하는 데 사용되며, 값이 저장되는 메모리 위치를 나타냅니다.
            //인수는 변수에 전달되어 함수 또는 메서드에서 사용될 수 있습니다.

        }
    }
}