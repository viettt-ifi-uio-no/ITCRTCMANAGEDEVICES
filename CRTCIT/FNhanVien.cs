using CRTCIT.AllObjects;
using CRTCIT.DataBaseHandler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRTCIT
{
    public partial class FNhanVien : Form
    {
        public FNhanVien()
        {
            InitializeComponent();
            DBNhanVien dbnv = new DBNhanVien();
            dbnv.updateGridData(dataGridNV);
        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            updateNhanVien(true);
            resetTXT();
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
            resetTXT();
        }

        private void updateNhanVien(bool isNewNhanVien)
        {
            NhanVien nv = new NhanVien();
            nv.maNv = txtMaNv.Text;
            nv.tenNv = txtTenNv.Text;

            if (nv.maNv.Equals("") || nv.tenNv.Equals(""))
            {
                MessageBox.Show(this, "Vui Long Dien Ma Nhan Vien hoac Ten Nhan Vien", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DBNhanVien dbnv = new DBNhanVien();
            string ret = dbnv.addNewStaf(nv, isNewNhanVien);
            if (ret.Contains("duplicate key")) MessageBox.Show(this, "TRUNG ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if(ret.Length > 0) MessageBox.Show(this, ret, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dbnv.updateGridData(dataGridNV);
        }

        private void resetTXT()
        {
            txtMaNv.Text = "";
            txtTenNv.Text = "";
        }

        private void btnEditNV_Click(object sender, EventArgs e)
        {
            updateNhanVien(false);
            resetTXT();
        }

        private void dataGridNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0) return;
            DataGridViewRow row = dataGridNV.Rows[rowIndex];
            txtMaNv.Text = row.Cells[0].Value.ToString();
            txtTenNv.Text = row.Cells[1].Value.ToString();

            btnEditNV.Enabled = true;
        }
    }
}
