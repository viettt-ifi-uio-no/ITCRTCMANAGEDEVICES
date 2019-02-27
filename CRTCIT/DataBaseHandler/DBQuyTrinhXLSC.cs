using CRTCIT.AllObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRTCIT.DataBaseHandler
{
    class DBQuyTrinhXLSC
    {
        public int addnewQuyTrinh(QuyTrinhXLSC quytrinh, bool isUpdate)
        {
            DataBaseManager.initializeInstance();
            DataBaseManager dbmg = DataBaseManager.getInstance();
            SqlConnection con = dbmg.openDatabase();

            string insertNewCmd = "INSERT QUYTRINHXULYSUCO (Id, TenQuyTrinh, NguoiVietQuyTrinh, NoiDungQTXLSC) "
    + " VALUES (@Id,@TenQuyTrinh,@NguoiVietQuyTrinh,@NoiDungQTXLSC)";
            string updateCmd = "UPDATE QUYTRINHXULYSUCO SET Id = @Id, TenQuyTrinh = @TenQuyTrinh, NguoiVietQuyTrinh = @NguoiVietQuyTrinh,"
               + " NoiDungQTXLSC = @NoiDungQTXLSC";


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            if (!isUpdate) cmd.CommandText = insertNewCmd;
            else cmd.CommandText = updateCmd;
            //cmd.CommandText = "INSERT QUYTRINHBAOTRI (Id, TenQuyTrinh) VALUES (@maQTBT,@tenQTBT,@tennguoiviet)";
            cmd.Parameters.AddWithValue("@ID", quytrinh.maQTXLSC);
            cmd.Parameters.AddWithValue("@TenQuyTrinh", quytrinh.tenQTXLSC);
            cmd.Parameters.AddWithValue("@NguoiVietQuyTrinh", quytrinh.tennguoiviet);
            cmd.Parameters.AddWithValue("@NoiDungQTXLSC", quytrinh.noidungQTXLSC);

            int ret = -1;

            try
            {
                ret = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Debug.WriteLine("The product name is " + e.Message);
            }

            dbmg.closeDatabase();

            return (ret > 0) ? ret : -1;
        }





        internal void updateGridData(DataGridView dataGirdQuyTrinh)
        {
            DataBaseManager.initializeInstance();
            DataBaseManager dbmg = DataBaseManager.getInstance();
            SqlConnection con = dbmg.openDatabase();

            string sql = "SELECT * FROM QuyTrinhXuLySuCo";
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "QuyTrinhXLSC");
            dataGirdQuyTrinh.DataSource = ds;
            dataGirdQuyTrinh.DataMember = "QuyTrinhXLSC";

            dbmg.closeDatabase();
        }




        public int removeQuyTrinh(string idQt)
        {
            DataBaseManager.initializeInstance();
            DataBaseManager dbmg = DataBaseManager.getInstance();
            SqlConnection con = dbmg.openDatabase();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM QUYTRINHXULYSUCO WHERE Id = @maQTBT";
            cmd.Parameters.AddWithValue("@maQTBT", idQt);

            int ret = -1;

            try
            {
                ret = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Debug.WriteLine("The product name is " + e.Message);
            }
            dbmg.closeDatabase();
            return (ret > 0) ? ret : -1;
        }

    }
}
