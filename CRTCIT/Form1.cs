using CRTCIT.AllObjects;
using CRTCIT.DataBaseHandler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRTCIT
{
    public partial class Form1 : Form
    {
        Timer t = new Timer();

        public Form1()
        {
            InitializeComponent();
            DBNhanVien dbnv = new DBNhanVien();
            dbnv.updateGridData(dataGridNV);
            //timer interval
            t.Interval = 1000;  //in milliseconds

            t.Tick += new EventHandler(this.t_Tick);

            //start timer when form loads
            t.Start();  //this will use t_Tick() method
        }

        private void t_Tick(object sender, EventArgs e)
        {
            //get current time
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            string time = ""+DateTime.Now;
            //update label
            lblClock.Text = time;
        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDeleteNV_Click(object sender, EventArgs e)
        {
            if (txtMaNv.Text.Equals(""))
            {
                MessageBox.Show(this, "Nhap ma nhan vien", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DBNhanVien dbnv = new DBNhanVien();
            dbnv.removeNewStaf(txtMaNv.Text);
            dbnv.updateGridData(dataGridNV);
        }

        private void dataGridNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0) return;
            DataGridViewRow row = dataGridNV.Rows[rowIndex];
            txtMaNv.Text = row.Cells[0].Value.ToString();
            txtTenNv.Text = row.Cells[1].Value.ToString();
        }

        private void btnEXERawQuery_Click(object sender, EventArgs e)
        {
            DataBaseManager.initializeInstance();
            DataBaseManager dbmg = DataBaseManager.getInstance();
            SqlConnection con = dbmg.openDatabase();

            string sql = txtRawQuery.Text;
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds);
            dataGridViewRawData.DataSource = ds.Tables[0];
            dbmg.closeDatabase();
        }
    }
}
