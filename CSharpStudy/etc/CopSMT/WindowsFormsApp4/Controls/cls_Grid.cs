using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;

namespace WindowsFormsApp4
{
    internal class cls_Grid
    {
        internal bool Check_Gv_FormClosing(GridControl gv_Mold, string v)
        {
            throw new NotImplementedException();
        }

        internal void Create_GvColumn(GridView gv, string caption, string fieldName, RepositoryItem repository=null)
        {
            //throw new NotImplementedException();
            GridColumnSummaryItem col = new GridColumnSummaryItem();
                //col.Caption = caption;          //표기명
                //col.Name = fieldName;           //Column명
                //col.FieldName = fieldName;      //연동 데이터 Column명
                //col.ColumnEdit = repository;    //Repository Item(ComboBox, Lookup 등_
                //col.Visible = true;             //화면에 보이기

                //col.OptionsColumn.AllowEdit = false;    //유저가 수정 허용 여부

                //gv.Columns.Add(col);            //GridView에 추가
        }
    }
}