using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp4.Model;

namespace WindowsFormsApp4.View
{
    class SC_Switch
    {
        #region Property

        public string Task_Div { get; set; }
        public string Option_Nm { get; set; }
        public string Value { get; set; }
        public string Rmk { get; set; }

        #endregion

        Database db = new Database();
        string query = "";

        public DataTable Select_Switch(string task = null)
        {
            //사업부관리(Frm_SC_Corp) 호출 Query
            query = $@"SELECT '' AS Status
                            , Task_Div
                            , Option_Nm
                            , Value
                            , Rmk
                              
                            , Ins_Emp_No
                            , Ins_Date_Time
                            , Upd_Emp_No
                            , Upd_Date_Time

                         FROM SC_Switch
                        WHERE Corp_Cd = '{WrGlobal.Corp_Cd}'";

            if (task != null)
            {
                query += $"\nAND Task_Div = '{task}'";
            }

            return db.GetDataTable(query);
        }

        public DataTable Select_Switch_TaskDivList()
        {
            query = $@"SELECT DISTINCT
                              Task_Div

                         FROM SC_Switch
                        WHERE Corp_Cd = '{WrGlobal.Corp_Cd}'";

            return db.GetDataTable(query);
        }

        public bool Ins_Switch()
        {
            db.Edit_Property(this);

            query = $@"INSERT INTO SC_Switch(Corp_Cd, Task_Div, Option_Nm, Value, Rmk                              
                                           , Ins_Emp_No, Ins_Date_Time)
                            VALUES ('{WrGlobal.Corp_Cd}'
                                  , '{Task_Div}'
                                  , '{Option_Nm}'
                                  , '{Value}'
                                  , '{Rmk}'

                                  , '{WrGlobal.LoginID}'
                                  , GETDATE())";

            return db.ExecuteQuery(query);
        }

        public bool Upd_Switch()
        {
            db.Edit_Property(this);

            query = $@"UPDATE SC_Switch
                          SET Option_Nm = '{Option_Nm}'
                            , Value = '{Value}'
                            , Rmk = '{Rmk}'

                            , Upd_Emp_No = '{WrGlobal.LoginID}'
                            , Upd_Date_Time = GETDATE()


                        WHERE Corp_Cd = '{WrGlobal.Corp_Cd}'
                          AND Task_Div = '{Task_Div}'
                          AND Option_Nm = '{Option_Nm}'";

            return db.ExecuteQuery(query);
        }
    }
}