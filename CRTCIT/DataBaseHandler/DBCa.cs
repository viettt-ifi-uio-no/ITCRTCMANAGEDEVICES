using CRTCIT.AllObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRTCIT.DataBaseHandler
{
    class DBCa
    {
        public int addNewShift(Ca ca)
        {
            DataBaseManager.initializeInstance();
            DataBaseManager dbmg = DataBaseManager.getInstance();
            SqlConnection con = dbmg.openDatabase();


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT CA (MaCa, TenCa) VALUES (@maCa,@tenCa)";
            cmd.Parameters.AddWithValue("@maCa",ca.maCa);
            cmd.Parameters.AddWithValue("@tenCa", ca.tenCa);

            int ret = cmd.ExecuteNonQuery();

            dbmg.closeDatabase();

            return (ret > 0) ? ret : -1;
        }
    }
}
