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
    class DBQuyTrinhBT
    {
        public int addnewQuyTrinh(QuyTrinhBT quytrinh, bool isUpdate)
        {
            DataBaseManager.initializeInstance();
            DataBaseManager dbmg = DataBaseManager.getInstance();
            SqlConnection con = dbmg.openDatabase();

            string insertNewCmd = "INSERT QUYTRINHBAOTRI (Id, TenQuyTrinh, NguoiVietQuyTrinh, NoiDungQT) "
    + " VALUES (@Id,@TenQuyTrinh,@NguoiVietQuyTrinh,@NoiDungQT)";
            string updateCmd = "UPDATE QUYTRINHBAOTRI SET Id = @Id, TenQuyTrinh = @TenQuyTrinh, NguoiVietQuyTrinh = @NguoiVietQuyTrinh,"
               + " NoiDungQT = @NoiDungQT";


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            if (!isUpdate) cmd.CommandText = insertNewCmd;
            else cmd.CommandText = updateCmd;
            //cmd.CommandText = "INSERT QUYTRINHBAOTRI (Id, TenQuyTrinh) VALUES (@maQTBT,@tenQTBT,@tennguoiviet)";
            cmd.Parameters.AddWithValue("@ID", quytrinh.maQTBT);
            cmd.Parameters.AddWithValue("@TenQuyTrinh", quytrinh.tenQTBT);
            cmd.Parameters.AddWithValue("@NguoiVietQuyTrinh", quytrinh.tennguoiviet);
            cmd.Parameters.AddWithValue("@NoiDungQT", quytrinh.noidungQT);

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

            string sql = "SELECT * FROM QuyTrinhBaoTri";
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "QuyTrinhBT");
            dataGirdQuyTrinh.DataSource = ds;
            dataGirdQuyTrinh.DataMember = "QuyTrinhBT";

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
            cmd.CommandText = "DELETE FROM QUYTRINHBAOTRI WHERE Id = @maQTBT";
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

        public void updateComboBoxTenOnly(ComboBox cb)
        {
            DataBaseManager.initializeInstance();
            DataBaseManager dbmg = DataBaseManager.getInstance();
            SqlConnection con = dbmg.openDatabase();

            string sql = "SELECT * FROM QUYTRINHBAOTRI";
            SqlCommand sqlCmd = new SqlCommand(sql, con);
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                cb.Items.Add(sqlReader["ID"].ToString());
            }

            sqlReader.Close();

            dbmg.closeDatabase();
        }

    }
}
