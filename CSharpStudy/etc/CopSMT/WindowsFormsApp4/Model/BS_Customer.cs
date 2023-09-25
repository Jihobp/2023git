using System;
using System.Data;
using WindowsFormsApp4.Model;

namespace WindowsFormsApp4
{
    class BS_Customer
    {

        Database db = new Database();
        string query;

        /// <summary>
        /// 거래처정보 불러오기, 전체 보기 기능 & 특정 품목 구분들 불러오기 ???????? 
        /// </summary>
        /// <param name="cust_Div">전체 구분 코드 ex) new string[] {"10", "20", "60"}</param>
        /// <param name="all_Yn">전체 Row 추가</param>
        /// <returns></returns>
        public DataTable Select_Cust_List(string[] cust_Div = null, bool all_Yn = false)
        {
            query = "";

            if (all_Yn)
            {   //조회항목에서 전체를 추가하고 싶을경우
                query += @"SELECT 'ALL' AS 코드, '전체' AS 명칭
                        UNION ALL ";
            }

            query += $@"SELECT Cust_Cd AS 코드, Cust_Nm AS 명칭
                         FROM BS_Customer
                        WHERE Corp_Cd = '{WrGlobal.Corp_Cd}'";

            //특정 구분만 보고 싶은 경우
            if (cust_Div != null &&
                cust_Div.Length > 0)
            {
                query += " AND (";

                for (int idx = 0; idx < cust_Div.Length; idx++)
                {
                    if (idx != 0)
                    {
                        query += " OR ";
                    }

                    query += $@"Cust_Div_Cd = '{cust_Div[idx]}'";
                }

                query += ")";
            }

            return db.GetDataTable(query);
        }
    }
}