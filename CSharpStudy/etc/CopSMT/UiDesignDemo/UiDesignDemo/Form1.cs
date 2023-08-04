using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UiDesignDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(secondUC1);
            bunifuTransition1.ShowSync(firstUC1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(firstUC1);
            bunifuTransition1.ShowSync(secondUC1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(secondUC1);
            bunifuTransition1.ShowSync(firstUC1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(firstUC1);
            bunifuTransition1.ShowSync(secondUC1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(secondUC1);
            bunifuTransition1.ShowSync(firstUC1);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(firstUC1);
            bunifuTransition1.ShowSync(secondUC1);
        }


    }
}
