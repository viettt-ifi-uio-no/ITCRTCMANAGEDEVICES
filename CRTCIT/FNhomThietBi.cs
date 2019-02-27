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
    public partial class FNhomThietBi : Form
    {
        public FNhomThietBi()
        {
            InitializeComponent();
            DBNhomThietBi ntb = new DBNhomThietBi();
            ntb.updateGridData(dataGridNhom);
        }

        private void updateDB(bool isNewNhom)
        {
            NhomThietBi nhom = new NhomThietBi();
            nhom.groupID = txtMaNhom.Text;
            nhom.groupName = txtTenNhom.Text;
            nhom.groupSection = txtHe.Text;

            if (nhom.groupID.Equals("") || nhom.groupName.Equals(""))
            {
                MessageBox.Show(this, "Vui Long Dien Ma Nhom Ten Nhom", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DBNhomThietBi ntbDB = new DBNhomThietBi();
            ntbDB.addNewDeviceGroup(nhom, isNewNhom);
            ntbDB.updateGridData(dataGridNhom);
        }

        private void dataGridNhom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0) return;
            DataGridViewRow row = dataGridNhom.Rows[rowIndex];
            txtMaNhom.Text = row.Cells[0].Value.ToString();
            txtTenNhom.Text = row.Cells[1].Value.ToString();
            txtHe.Text = row.Cells[2].Value.ToString();

            btnEditNhom.Enabled = true;
        }

        private void btnAddNhom_Click(object sender, EventArgs e)
        {
            updateDB(true);
            resetTXT();
        }

        private void btnDelNhom_Click(object sender, EventArgs e)
        {
            DBNhomThietBi ntb = new DBNhomThietBi();
            ntb.removeDeviceGroup(txtMaNhom.Text);
            ntb.updateGridData(dataGridNhom);
            resetTXT();
        }

        private void btnEditNhom_Click(object sender, EventArgs e)
        {
            updateDB(false);
            resetTXT();
        }


        private void resetTXT()
        {
            txtMaNhom.Text = "";
            txtTenNhom.Text = "";
            txtHe.Text = "";
        }
    }
}
