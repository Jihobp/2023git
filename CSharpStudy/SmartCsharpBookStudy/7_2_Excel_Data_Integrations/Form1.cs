using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using _7_2_Excel_Data_Integrations;
//using Excel = Microsoft.Office.Interop.Excel;


namespace _7_2_Excel_Data_Integrations
{
    public partial class Form1 : Form
    {
        private const int V = 1;

        public Form1()
        {
            InitializeComponent();

        }

        private void btnExcelLoad_Click(object sender, EventArgs e)
        {
            myListView.Items.Clear(); //items ;;컨트롤에 있는 모든 항목을 가져옴
            string str_filename;
            FileDialog fileDlg = new OpenFileDialog();
            fileDlg.Filter = "Excel file(*.xlsx) | *xlsx|Excel File 97~2003(*.xls)|*.xls|All Files(*.*)|*.*";
            fileDlg.RestoreDirectory = true; //복원 안되면 false 인데 기본값이 true
            if (fileDlg.ShowDialog() == DialogResult.Cancel) return;

            str_filename = fileDlg.FileName;
            //리스트뷰 내용을 모두 삭제하고, 불러올 엑셀파일 이름을 가져오는 코드. Filter 객체는 파일불러오기 화면에서 사용할 파일 종류를 설정할때 사용.
            Excel.Application xlsapp = null;
            Excel.Workbook xlsbook = null;
            Excel.Worksheet xlssheet = null;
            //실제엑셀파일을 불러오고, get_Item(1) 메소드를 사용하여 첫번째 워크시트를 가져옴

            try
            {

                xlsapp = new Excel.Application();
                xlsbook = xlsapp.Workbooks.Open(str_filename);
                xlssheet = xlsapp.Worksheets.get_Item(1) as Excel.Worksheet;
                Excel.Range xlsrange = xlssheet.UsedRange;
                object[,] data = xlsrange.Value;
                //선택된 워크시트에서 데이터가 존재하는 모든 영역을 데이터로 가져오는 코드. 최종 데이터는 data라는 2차원객체배열에 저장됨.
                int colSize = data.GetLength(1);
                for (int col = 1; col <= colSize; col++)
                { myListView.Columns.Add(data[1, col].ToString()); } //엑셀에서 가져온 데이터에서 첫줄을 이용하여, ListView의 열(Column)을 등록하는 코드이다. 엑셀데이터의 실제데이터는 인덱스 1부터 시작한다.
                string[] fields = new string[colSize];
                    for (int row = 2; row <= data.GetLength(0); row++)
                    {
                        for (int col = 1; col <= colSize; col++)
                        {
                            fields[col - 1] = data[row, col].ToString();
                            myListView.Items.Add(new ListViewItem(fields));
                        }
                        xlsbook.Close(true);
                        xlsapp.Quit();
                    }
                    //엑셀에서 가져온 데이터를 ListView에 행단위로 등록하는 콛,. 엑셀 데이터는 인덱스 1부터 시작되고, 행번호 1은 앞에서 열등록에 사용되었으믈 실제 데이터는 행번호 2부터 시작되어야 함!!!!
            }
            catch (Exception ex)
            {
                MessageBox.Show("엑셀 불러오기 오류 " +ex.ToString());
                xlsbook.Close(true);
                xlsapp.Quit();
                //throw;
            }
            finally
            {
                Marshal.ReleaseComObject(xlssheet); //marshal cls???
                Marshal.ReleaseComObject(xlsbook);
                Marshal.ReleaseComObject(xlsapp);
            } //파일 리소스를 사용하는 코드에선, try catch 문을 사용해야함.
              //그리고 파일과 연관된 객체는 사용 후에 해제하는 코드를 사용해야함.
        }

        private void btnExcelSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Excel 파일로 저장";
            sfd.Filter = "Excel file(*.xlsx)|*.xlsx|Excel File 97~2003" +
                ""
        }
    }
}
