using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
