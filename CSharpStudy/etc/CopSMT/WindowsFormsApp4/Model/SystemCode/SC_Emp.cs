using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp4.Controls;
using WindowsFormsApp4.Model;

namespace WindowsFormsApp4.View
{
    class SC_Emp
    {
        #region Property

        public string Emp_No { get; set; }
        public string Emp_Nm { get; set; }
        public string Emp_Password { get; set; }
        public string Dept_Cd { get; set; }
        public string Class_Div_Cd { get; set; }
        public byte[] Emp_Image { get; set; }
        public string Use_Yn { get; set; }
        public string Prodt_Work_Or { get; set; }

        #endregion Property End

        Database db = new Database();
        string query = "";

        public DataTable Select_Emp()
        {
            db.Edit_Property(this);

            query = $@"   SELECT '' AS Status
                               , emp.Emp_No
                	           , emp.Emp_Nm
                	           , emp.Emp_PassWord
                	           , emp.Dept_Cd
                	           , emp.Dept_Cd AS Dept_Nm
                	           --, dpt.Dept_Nm

                	           , emp.Use_Yn
                	           , emp.Prodt_Work_Or
                	           , emp.Class_Div_Cd

                               , emp.Ins_Emp_No
                               , emp.Ins_Date_Time
                               , emp.Upd_Emp_No
                               , emp.Upd_Date_Time
                            FROM SC_Emp emp
                      LEFT JOIN SC_Dept dpt ON dpt.Dept_Cd = emp.Dept_Cd
                           WHERE emp.Corp_Cd = '{WrGlobal.Corp_Cd}'
                             AND Prodt_Work_Or = '{Prodt_Work_Or}'";

            //조회조건
            if (Dept_Cd != "ALL")
            {
                //부서
                query += $" AND dpt.Dept_Cd = '{Dept_Cd}' ";
            }

            if (Emp_Nm != "")
            {
                query += $" AND emp.Emp_Nm LIKE '%{Emp_Nm}%' ";
            }

            if (WrGlobal.LoginID != "Dev")
            {
                //개발자 접속여부
                query += $" AND emp.Emp_No <> 'Dev' ";
            }

            //정렬
            if (WrGlobal.ProcOption["SC"]["Emp_AutoNo"] == "Y")
            {
                query += " ORDER BY emp.Emp_Nm ASC";
            }
            else
            {
                query += " ORDER BY emp.Emp_No ASC";
            }

            return db.GetDataTable(query);
        }

        public DataTable Select_Emp_ByProcess(bool WorkerYN, string process)
        {
            string YesNo = (WorkerYN == true) ? "Y" : "N";

            query = $@"SELECT A.Emp_No AS 코드, B.Emp_Nm AS 명칭     
                         FROM BS_ProdtWorker A
                         JOIN SC_Emp B on (A.Emp_No = B.Emp_No)
                        WHERE A.Corp_Cd = '{WrGlobal.Corp_Cd}'
                          AND B.Use_Yn = 'Y'
                          AND B.Prodt_Work_Or = '{YesNo}'
                          AND A.Process_Cd like '{process}%'
                     ORDER BY LEN(A.Emp_No),A.Emp_No";

            DataTable dt = db.GetDataTable(query);

            return dt;
        }

        public DataRow Select_LoginUser()
        {
            //로그인시 로그인 유저 조회
            db.Edit_Property(this);

            query = $@"SELECT TOP 1
                              ep.Corp_Cd
                            , cr.Corp_Nm

                            , ep.Emp_No
                            , ep.Emp_Nm

                         FROM SC_Emp ep
                        INNER JOIN SC_Corp cr ON ep.Corp_Cd = cr.Corp_Cd

                        WHERE ep.Use_Yn = 'Y'
                          AND ep.Emp_No = '{Emp_No}'
                          AND ep.Emp_Password = '{Emp_Password}'";

            return db.GetDataRow(query);
        }

        public DataTable Select_Emp_ProdtWorker()
        {
            //공정별 작업자(Frm_BS_ProdtWorker)에서 작업자 목록 호출 Query
            db.Edit_Property(this);

            query = $@"SELECT Emp_No,
                              Emp_Nm,
                              CASE WHEN EXISTS(SELECT Emp_No
                                               FROM BS_ProdtWorker
                                               WHERE Emp_No = SC_Emp.Emp_No)
                                        THEN 'Y'
                                   ELSE 'N'
                              END AS PrdtWorker_Yn   --공정별 작업자 지정 여부
                         FROM SC_Emp
                        WHERE Corp_Cd = '{WrGlobal.Corp_Cd}'
                          AND Use_Yn = 'Y'
                          AND Prodt_Work_Or = 'Y'";

            return db.GetDataTable(query);
        }

        public DataTable Select_Emp_CdNm()
        {
            //공정별 작업자(Frm_BS_ProdtWorker)에서 작업자 Lookup 호출 Query
            query = $@"SELECT Emp_No,
                              Emp_Nm
                         FROM SC_Emp
                        WHERE Corp_Cd = '{WrGlobal.Corp_Cd}'
                          AND Use_Yn = 'Y'";

            return db.GetDataTable(query);
        }

        public DataTable Select_Emp(string WorkerYN)
        {
            //유저 리스트
            query = $@"SELECT Emp_No AS 코드, Emp_Nm AS 명칭
                         FROM SC_Emp

                        WHERE Use_Yn = 'Y'
                          AND Corp_Cd = '{WrGlobal.Corp_Cd}'";

            if (WorkerYN != "All")
            {
                // Y: 작업자, N : 관리자 
                query += $" AND (Prodt_Work_Or = '{WorkerYN}' or Dept_Cd = '02') ";
            }
            if (WrGlobal.LoginID != "Dev")
            {
                query += $" AND Emp_No <> 'Dev'";
            }

            query += $" ORDER BY LEN(Emp_No), Emp_No  ";

            return db.GetDataTable(query);
        }

        /// <summary>
        /// 유저리스트 호출
        /// </summary>
        /// <param name="workerYn">작업자유무 Y:작업자, N:관리자</param>
        /// <param name="Dept_Cd">부서코드</param>
        /// <param name="Class_Div">업무구분</param>
        /// <param name="all_Yn">전체 사용여부</param>
        /// <returns></returns>
        public DataTable Select_User_List(char workerYn, string[] Dept_Cd = null, string[] Class_Div = null, bool all_Yn = false)
        {
            //부서, 업무구분에따른 사용자 조회
            query = "";

            if (all_Yn)
            {   //조회항목에서 전체를 추가하고 싶을경우
                query += @"SELECT 'ALL' AS 코드
                                , '전체' AS 명칭
                                , '전체' AS 부서명
                            UNION ALL ";
            }

            query += $@"SELECT Emp_No AS 코드, Emp_Nm AS 명칭, dt.Dept_Nm AS 부서명
                          FROM SC_Emp emp
                     LEFT JOIN SC_Dept dt ON dt.Dept_Cd = emp.Dept_Cd
                    
                         WHERE emp.Corp_Cd = '{WrGlobal.Corp_Cd}'
                           AND emp.Use_Yn = 'Y'
                           AND emp.Prodt_Work_Or = '{workerYn}'";

            //특정 부서만 보고 싶은 경우
            if (Dept_Cd != null &&
                Dept_Cd.Length > 0)
            {
                query += "\nAND emp.Dept_Cd IN (";

                for (int idx = 0; idx < Dept_Cd.Length; idx++)
                {
                    if (idx != 0)
                    {
                        query += ", ";
                    }

                    query += $@"'{Dept_Cd[idx]}'";
                }

                query += ")";
            }

            //업무 구분에 따른 조회
            if (Class_Div != null &&
                Class_Div.Length > 0)
            {
                query += "\nAND emp.Class_Div_Cd IN (";

                for (int idx = 0; idx < Class_Div.Length; idx++)
                {
                    if (idx != 0)
                    {
                        query += ", ";
                    }

                    query += $@"'{Class_Div[idx]}'";
                }

                query += ")";
            }

            //개발자면 개발자 안보이게 하기
            if (WrGlobal.LoginID != "Dev")
            {
                query += $"\nAND Emp_No <> 'Dev'";
            }

            //query += $"\nORDER BY Emp_No ";

            return db.GetDataTable(query);
        }

        public DataTable Select_Worker()
        {
            //작업자관리(Frm_SC_Worker)에서 조회시 사용하는 Query
            Dept_Cd = Dept_Cd.ConvertStr_Empty_To_Null();

            query = $@"SELECT '' AS Status
                            , emp.Emp_No
                            , emp.Emp_Nm
                            , emp.Dept_Cd
                            , emp.Use_Yn

                            , emp.Ins_Emp_No
                            , emp.Ins_Date_Time
                            , emp.Upd_Emp_No
                            , emp.Upd_Date_Time

                         FROM SC_Emp emp
                        WHERE emp.Corp_Cd = '{WrGlobal.Corp_Cd}'
                          AND emp.Prodt_Work_Or = 'Y'";

            if (Dept_Cd != "NULL") { query += $"\n AND emp.Dept_Cd = {Dept_Cd}"; }

            query += "\nORDER BY Emp_Nm";

            return db.GetDataTable(query);
        }

        public DataTable Select_Emp_List()
        {
            query = $@"SELECT emp.Emp_No AS 코드,
                              emp.Emp_Nm AS 명칭,
                              dept.Dept_Nm AS 부서명

                         FROM SC_Emp emp
                    LEFT JOIN SC_Dept dept ON dept.Dept_Cd = emp.Dept_Cd

                        WHERE emp.Corp_Cd = '{WrGlobal.Corp_Cd}'
                          AND Use_Yn = 'Y'
                          AND emp.Dept_Cd =       CASE WHEN '{Dept_Cd}' = '' THEN emp.Dept_Cd	--빈칸이면 모두 부서보기
                                                                             ELSE '{Dept_Cd}'
                                                  END
                          AND emp.Prodt_Work_Or = CASE WHEN '{Prodt_Work_Or}' = 'Y' THEN 'Y'	--작업자만 보고 싶은경우
                                                       WHEN '{Prodt_Work_Or}' = 'N' THEN 'N'	--작업자가 아닌사람만 보고싶은 경우
                                                                                    ELSE emp.Prodt_Work_Or
                                                  END
                          AND emp.Emp_No <>       CASE WHEN '{WrGlobal.LoginID}' = 'Dev' THEN ''	--개발자로 로그인한경우 개발자 뜨게
                                                                                         ELSE 'Dev'
                                                  END";

            return db.GetDataTable(query);
        }

        public DataTable Select_Emp_Image()
        {
            query = $@" SELECT Emp_Image 
                          FROM SC_Emp 
                         WHERE Corp_Cd = '{WrGlobal.Corp_Cd}' 
                           AND Emp_No = '{Emp_No}' ";

            return db.GetDataTable(query);
        }

        public bool Insert_Emp()
        {
            //직원관리(Frm_SC_Emp) 입력 Query
            db.Edit_Property(this);

            query = $@" INSERT INTO SC_Emp( Corp_Cd, Emp_No, Emp_Nm, Emp_PassWord, Dept_Cd 
                                        , Use_Yn, Prodt_Work_Or, Class_Div_Cd
                                        , Ins_Emp_No, Ins_Date_Time) 
                       VALUES( '{WrGlobal.Corp_Cd}'
                             , CASE WHEN '{WrGlobal.ProcOption["SC"]["Emp_AutoNo"]}' = 'Y' THEN dbo.FN_Create_Cd_Emp('{WrGlobal.Corp_Cd}', 'E')
                                    ELSE '{Emp_No}'
                               END
                             , '{Emp_Nm}' 
                             , '{Emp_Password}' 
                             , {Dept_Cd.ConvertStr_Empty_To_Null()} 

                             , 'Y' 
                             , 'N' 
                             , {Class_Div_Cd.ConvertStr_Empty_To_Null()} 

                             , '{WrGlobal.LoginID}' 
                             ,  GETDATE()) ";

            return db.ExecuteQuery(query);
        }

        public bool Insert_Worker()
        {
            //직원관리(Frm_SC_Emp) 입력 Query
            db.Edit_Property(this);

            query = $@" INSERT INTO SC_Emp( Corp_Cd, Emp_No, Emp_Nm, Emp_PassWord, Dept_Cd 
                                        , Use_Yn, Prodt_Work_Or, Ins_Emp_No, Ins_Date_Time) 
                       VALUES( '{WrGlobal.Corp_Cd}'
                             , CASE WHEN '{WrGlobal.ProcOption["SC"]["Worker_AutoNo"]}' = 'Y' THEN dbo.FN_Create_Cd_Emp('{WrGlobal.Corp_Cd}', 'W')
                                    ELSE '{Emp_No}'
                               END

                             , '{Emp_Nm}' 
                             , '@admin9150' --작업자용 비밀번호
                             , '{Dept_Cd}' 
                             , 'Y' 
                             , 'Y' 
                             , '{WrGlobal.LoginID}' 
                             ,  GETDATE()) ";

            return db.ExecuteQuery(query);
        }

        public void Update_Emp_Image()
        {
            query = $@" UPDATE SC_Emp 
                           SET Emp_Image = @Pic
                         WHERE Corp_Cd = '{WrGlobal.Corp_Cd}' 
                           AND Emp_No = '{Emp_No}'";

            db.ExecuteQueryImage(query, Emp_Image);
        }

        public bool Update_Emp()
        {
            //직원관리(Frm_SC_Emp) 수정 Query
            db.Edit_Property(this);

            query = $@" UPDATE SC_Emp 
                           SET Emp_Nm = '{Emp_Nm}' 
                             , Emp_PassWord = '{Emp_Password}' 
                             , Dept_Cd = '{Dept_Cd}' 
                             , Use_Yn = '{Use_Yn}' 
                             , Prodt_Work_Or = '{Prodt_Work_Or}' 
                             , Class_Div_Cd = {Class_Div_Cd.ConvertStr_Empty_To_Null()}

                             , Upd_Emp_No = '{WrGlobal.LoginID}'
                             , Upd_Date_Time = GETDATE()
                         WHERE Corp_Cd = '{WrGlobal.Corp_Cd}' 
                           AND Emp_No = '{Emp_No}' ";

            return db.ExecuteQuery(query);
        }

        public bool Update_Worker()
        {
            //직원관리(Frm_SC_Emp) 수정 Query
            db.Edit_Property(this);

            query = $@" UPDATE SC_Emp 
                           SET Emp_Nm = '{Emp_Nm}' 
                             , Dept_Cd = '{Dept_Cd}' 
                             , Use_Yn = '{Use_Yn}' 
                             , Class_Div_Cd = {Class_Div_Cd.ConvertStr_Empty_To_Null()}

                             , Upd_Emp_No = '{WrGlobal.LoginID}'
                             , Upd_Date_Time = GETDATE()
                         WHERE Corp_Cd = '{WrGlobal.Corp_Cd}' 
                           AND Emp_No = '{Emp_No}' ";

            return db.ExecuteQuery(query);
        }

        public bool Delete_Emp()
        {
            query = $@" DELETE SC_Emp 
                         WHERE Corp_Cd = '{WrGlobal.Corp_Cd}' 
                           AND Emp_No = '{Emp_No}'";

            return db.ExecuteQuery(query);
        }
    }
}
