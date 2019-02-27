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
    class DBNhomThietBi
    {
        public int addNewDeviceGroup(NhomThietBi nhomThietBi, bool isNewNhom)
        {
            DataBaseManager.initializeInstance();
            DataBaseManager dbmg = DataBaseManager.getInstance();
            SqlConnection con = dbmg.openDatabase();

            string newNhomCMD = "INSERT NHOMTB (Id, Ten, He) "
                + " VALUES (@Id,@Ten,@He)";
            string updateNhomCMD = "UPDATE NHOMTB SET Id = @Id, Ten = @Ten, He = @He WHERE Id = @Id";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;

            if (isNewNhom)
                cmd.CommandText = newNhomCMD;
            else cmd.CommandText = updateNhomCMD;

            cmd.Parameters.AddWithValue("@Id", nhomThietBi.groupID);
            cmd.Parameters.AddWithValue("@Ten", nhomThietBi.groupName);
            cmd.Parameters.AddWithValue("@He", nhomThietBi.groupSection);

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

            Debug.WriteLine("DEVICE IS REGISTERED " + ret);

            return (ret > 0) ? ret : -1;
        }
        public void updateGridData(DataGridView dataGrid)
        {

            DataBaseManager.initializeInstance();
            DataBaseManager dbmg = DataBaseManager.getInstance();
            SqlConnection con = dbmg.openDatabase();

            string sql = "SELECT * FROM NHOMTB";
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            
            dataadapter.Fill(ds, "NHOMTB");
            dataGrid.DataSource = ds;
            dataGrid.DataMember = "NHOMTB";

            dbmg.closeDatabase();
        }

        public void updateComboBox(ComboBox cb)
        {
            DataBaseManager.initializeInstance();
            DataBaseManager dbmg = DataBaseManager.getInstance();
            SqlConnection con = dbmg.openDatabase();

            string sql = "SELECT * FROM NHOMTB";
            SqlCommand sqlCmd = new SqlCommand(sql, con);
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                cb.Items.Add(sqlReader["ID"].ToString() +" "+ sqlReader["Ten"].ToString() +" "+ sqlReader["He"].ToString());
            }

            sqlReader.Close();

            dbmg.closeDatabase();
        }

        public void updateComboBoxIdOnly(ComboBox cb)
        {
            DataBaseManager.initializeInstance();
            DataBaseManager dbmg = DataBaseManager.getInstance();
            SqlConnection con = dbmg.openDatabase();

            string sql = "SELECT * FROM NHOMTB";
            SqlCommand sqlCmd = new SqlCommand(sql, con);
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                cb.Items.Add(sqlReader["ID"].ToString());
            }

            sqlReader.Close();

            dbmg.closeDatabase();
        }

        public int removeDeviceGroup(string idTb)
        {
            DataBaseManager.initializeInstance();
            DataBaseManager dbmg = DataBaseManager.getInstance();
            SqlConnection con = dbmg.openDatabase();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM NHOMTB WHERE Id = @MaNhom";
            cmd.Parameters.AddWithValue("@MaNhom", idTb);

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
