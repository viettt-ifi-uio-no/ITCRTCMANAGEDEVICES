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
    class DBNhanVien
    {
        public string addNewStaf(NhanVien nv, bool isNewNhanVien)
        {
            DataBaseManager.initializeInstance();
            DataBaseManager dbmg = DataBaseManager.getInstance();
            SqlConnection con = dbmg.openDatabase();

            string newNhanVien = "INSERT NHANVIEN (Id, Ten) "
                + " VALUES (@maNV,@tenNV)";
            string updateNhanVien = "UPDATE NHANVIEN SET Id = @maNV, Ten = @tenNV WHERE Id = @maNV";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;

            if (isNewNhanVien) cmd.CommandText = newNhanVien;
            else cmd.CommandText = updateNhanVien;

            cmd.Parameters.AddWithValue("@maNv", nv.maNv);
            cmd.Parameters.AddWithValue("@tenNv", nv.tenNv);

            //int ret = -1;
            string ret = "";

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Debug.WriteLine("The product name is " + e.Message);
                ret = e.Message;
            }

            dbmg.closeDatabase();
            return ret;
            //return (ret > 0) ? ret : -1;
        }

        public int removeNewStaf(string nv)
        {
            DataBaseManager.initializeInstance();
            DataBaseManager dbmg = DataBaseManager.getInstance();
            SqlConnection con = dbmg.openDatabase();


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM NHANVIEN WHERE Id = @maNv";
            cmd.Parameters.AddWithValue("@maNv", nv);


            int ret = -1;

            try {
                ret = cmd.ExecuteNonQuery();
            } catch (Exception e)
            {
                Debug.WriteLine("The product name is " + e.Message);
            }

            dbmg.closeDatabase();

            return (ret > 0) ? ret : -1;
        }

        public void updateGridData(DataGridView dataGrid)
        {
            DataBaseManager.initializeInstance();
            DataBaseManager dbmg = DataBaseManager.getInstance();
            SqlConnection con = dbmg.openDatabase();

            string sql = "SELECT * FROM NhanVien";
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "NhanVien");
            dataGrid.DataSource = ds;
            dataGrid.DataMember = "NhanVien";

            dbmg.closeDatabase();
        }

        public DataSet testReport()
        {
            DataBaseManager.initializeInstance();
            DataBaseManager dbmg = DataBaseManager.getInstance();
            SqlConnection con = dbmg.openDatabase();

            string sql = "SELECT * FROM NhanVien";
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "NhanVien");
            dbmg.closeDatabase();
            return ds;
        }

        public void updateComboBoxTenOnly(ComboBox cb)
        {
            DataBaseManager.initializeInstance();
            DataBaseManager dbmg = DataBaseManager.getInstance();
            SqlConnection con = dbmg.openDatabase();

            string sql = "SELECT * FROM NhanVien ";
            SqlCommand sqlCmd = new SqlCommand(sql, con);
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                cb.Items.Add(sqlReader["TEN"].ToString());
            }

            sqlReader.Close();

            dbmg.closeDatabase();
        }

    }
}
