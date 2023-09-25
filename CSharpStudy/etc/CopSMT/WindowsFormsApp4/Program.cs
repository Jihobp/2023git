using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.View;

namespace WindowsFormsApp4
{
    static class Program
    {
        /// <summary>
        ///  해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread] //?? 응용프로그램에 대한 COM 스레드 모델이 STA 단일 스레드아파트 임을 나타냄?  class.System의 !?
        static void Main() // 네임스페이스는 필드나 같은 메서드를 직접 포함할 수 없습니다. 
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //로그인 결과에 따라 메인진행 여부 결정
            Frm_RealLogin login = new Frm_RealLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Frm_Main());
            }
        }
    }
}
