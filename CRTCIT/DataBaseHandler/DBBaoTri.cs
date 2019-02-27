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
    class DBBaoTri
    {
        public void loadThietBiDenHanBaoTri(DataGridView dataGrid)
        {
            DataBaseManager.initializeInstance();
            DataBaseManager dbmg = DataBaseManager.getInstance();
            SqlConnection con = dbmg.openDatabase();

            //Debug.WriteLine("The --------->   " + String.Format("{0:yyyy-MM-dd}", DateTime.Now));

            string sql = "SELECT * FROM ThietBi Where DATEADD(day,TangSuat,NgayThucHienCuoi) < '"+ String.Format("{0:yyyy-MM-dd}", DateTime.Now) +"'";

            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "ThietBi");
            dataGrid.DataSource = ds;
            dataGrid.DataMember = "ThietBi";

            dbmg.closeDatabase();
        }

    }
}
