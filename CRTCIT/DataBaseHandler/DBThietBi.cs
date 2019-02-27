using CRTCIT.AllObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace CRTCIT.DataBaseHandler
{
    class DBThietBi
    {
        public int addNewDevice(ThietBi thietBi, bool isUpdate)
        {
            DataBaseManager.initializeInstance();
            DataBaseManager dbmg = DataBaseManager.getInstance();
            SqlConnection con = dbmg.openDatabase();

            string insertNewCmd = "INSERT THIETBI (Id, Ten, NgayBatDau, NgayKetThuc, ViTri, BaoHanh, LOG, TinhTrang, MaNhom, TangSuat, Model, Seri, Hang, NgayThucHienCuoi) "
                + " VALUES (@Id,@Ten,@NgayBatDau,@NgayKetThuc,@ViTri,@BaoHanh,@LOG,@TinhTrang,@MaNhom, @TangSuat, @Model, @Seri, @Hang, @NgayThucHienCuoi)";
            string updateCmd = "UPDATE THIETBI SET Id = @Id, Ten = @Ten, NgayBatDau = @NgayBatDau,"
                + " NgayKetThuc = @NgayKetThuc, ViTri = @ViTri, BaoHanh = @BaoHanh, LOG = @LOG, TinhTrang = @TinhTrang,"
                + " MaNhom = @MaNhom, TangSuat = @TangSuat, Model = @Model, Seri = @Seri, Hang = @Hang,NgayThucHienCuoi = @NgayThucHienCuoi"
                + " WHERE Id = @Id";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            if (!isUpdate) cmd.CommandText = insertNewCmd;
            else cmd.CommandText = updateCmd;
            cmd.Parameters.AddWithValue("@Id", thietBi.deviceID);
            cmd.Parameters.AddWithValue("@Ten", thietBi.deviceName);
            cmd.Parameters.AddWithValue("@NgayBatDau", thietBi.startDate);
            cmd.Parameters.AddWithValue("@NgayKetThuc", thietBi.endDate);
            cmd.Parameters.AddWithValue("@ViTri", thietBi.position);
            cmd.Parameters.AddWithValue("@BaoHanh", thietBi.warranty);
            cmd.Parameters.AddWithValue("@LOG", thietBi.LOG);
            cmd.Parameters.AddWithValue("@TinhTrang", thietBi.status);
            cmd.Parameters.AddWithValue("@MaNhom", thietBi.deviceIDGroup);
            cmd.Parameters.AddWithValue("@TangSuat", thietBi.tangSuat);
            cmd.Parameters.AddWithValue("@Model", thietBi.model);
            cmd.Parameters.AddWithValue("@Seri", thietBi.serial);
            cmd.Parameters.AddWithValue("@Hang", thietBi.hangsx);
            cmd.Parameters.AddWithValue("@NgayThucHienCuoi", thietBi.lanCuoi);

            int ret = -1;

            try
            {
                ret = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Debug.WriteLine("The product name is ------->   " + e.Message);
            }

            dbmg.closeDatabase();
            Debug.WriteLine("DEVICE IS REGISTERED ");

            return (ret > 0) ? ret : -1;
        }

        public void updateGridData(DataGridView dataGrid)
        {

            DataBaseManager.initializeInstance();
            DataBaseManager dbmg = DataBaseManager.getInstance();
            SqlConnection con = dbmg.openDatabase();

            string sql = "SELECT * FROM ThietBi";
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds,"ThietBi");
            dataGrid.DataSource = ds;
            dataGrid.DataMember = "ThietBi";

            dbmg.closeDatabase();
        }

        public int removeDevice(string deviceID)
        {
            DataBaseManager.initializeInstance();
            DataBaseManager dbmg = DataBaseManager.getInstance();
            SqlConnection con = dbmg.openDatabase();


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM THIETBI WHERE Id = @maThietBi";
            cmd.Parameters.AddWithValue("@maThietBi", deviceID);


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
