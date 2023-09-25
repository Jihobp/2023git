using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_LayoutControl_
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            string fileName = string.Format("{0}/{1}.xml", Application.StartupPath, this.Name);
            /*
            if (File.Exists(fileName))
                layoutControl.RestoreLayoutFromXml(filename);
            */
        }
        //private void btnSaveLayout(object sender, EventArgs e)
        //{

        //}
    }
}