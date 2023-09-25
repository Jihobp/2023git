using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4.Model
{
    class BS_Mold
    {
        Database db = new Database();
        string query = "";

        public DataRow Select_MoldInfo(string mold_Cd)
        {
            //throw new NotImplementedException();
            query = $@"SELECT Mold_Cd
                            , Mold_Mgmt_No
                            , Mold_Item_Count
                            , Mold_Cavity
                            , Init_Shot
                            , Life_Shot
                            , Mold_Image1
                            , Mold_Image2
                         FROM BS_Mold
                        WHERE Corp_Cd = '{WrGlobal.Corp_Cd}'
                          AND Mold_Cd = '{mold_Cd}'";

            return db.GetDataRow(query);


        }
    }
}
