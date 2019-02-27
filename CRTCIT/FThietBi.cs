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
    public partial class FThietBi : Form
    {
        public FThietBi()
        {
            InitializeComponent();
            DBThietBi dbThietBi = new DBThietBi();
            dbThietBi.updateGridData(dataGridThietBi);
            DBNhomThietBi ntb = new DBNhomThietBi();
            ntb.updateComboBoxIdOnly(cbBoxDeviceGroup);

        }
        private void dataGridThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0) return;
            DataGridViewRow row = dataGridThietBi.Rows[rowIndex];
            txtmaThietBi.Text = row.Cells[0].Value.ToString();
            txttenThietBi.Text = row.Cells[1].Value.ToString();
            dtPickStartDate.Text = row.Cells[2].Value.ToString();
            dtPickEndDate.Text = row.Cells[3].Value.ToString();
            txtviTri.Text = row.Cells[4].Value.ToString();
            dtPickWarranty.Text = row.Cells[5].Value.ToString();
            txtLOG.Text = row.Cells[6].Value.ToString();
            txtTinhTrang.Text = row.Cells[7].Value.ToString();
            cbBoxDeviceGroup.Text = row.Cells[8].Value.ToString();
            txtTangSuat.Text = row.Cells[9].Value.ToString();
            txtModel.Text = row.Cells[10].Value.ToString();
            txtSerial.Text = row.Cells[11].Value.ToString();
            txtHangsx.Text = row.Cells[12].Value.ToString();
            dtPickerLanCuoi.Text = row.Cells[13].Value.ToString();
            btnSua.Enabled = true;

        }

        private void updateDB(bool isNewDevice)
        {
            ThietBi thietBi = new ThietBi();

            thietBi.deviceID = txtmaThietBi.Text;
            thietBi.deviceName = txttenThietBi.Text;
            thietBi.startDate = dtPickStartDate.Value;
            thietBi.endDate = dtPickEndDate.Value;
            thietBi.position = txtviTri.Text;
            thietBi.warranty = dtPickWarranty.Value;
            thietBi.LOG = txtLOG.Text;
            thietBi.status = txtTinhTrang.Text;
            thietBi.deviceIDGroup = cbBoxDeviceGroup.GetItemText(cbBoxDeviceGroup.SelectedItem);

            if (txtTangSuat.Text == "" )
            {
                txtTangSuat.Text = "0";
            }
            else
            {
                thietBi.tangSuat = Convert.ToInt32(txtTangSuat.Text);
            }
            
            thietBi.model = txtModel.Text;
            thietBi.serial = txtSerial.Text;
            thietBi.hangsx = txtHangsx.Text;
            thietBi.lanCuoi = dtPickerLanCuoi.Value;

            if (thietBi.deviceID.Equals("") || thietBi.deviceName.Equals("") || thietBi.deviceIDGroup.Equals(""))
            {
                MessageBox.Show(this, "Vui Long Dien Ma, Ten Va Nhom Thiet Bi", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DBThietBi dbThietBi = new DBThietBi();
            if (isNewDevice) dbThietBi.addNewDevice(thietBi, false);
            else dbThietBi.addNewDevice(thietBi, true);
            dbThietBi.updateGridData(dataGridThietBi);
        }

        private void resetTxt()
        {
            txtmaThietBi.Text = "";
            txttenThietBi.Text = "";
            dtPickStartDate.ResetText();
            dtPickEndDate.ResetText();
            txtviTri.Text = "";
            dtPickWarranty.ResetText();
            txtLOG.Text = "";
            txtTinhTrang.Text = "";
            cbBoxDeviceGroup.SelectedIndex = -1;
            txtTangSuat.Text = "";
            txtModel.Text = "";
            txtSerial.Text = "";
            txtHangsx.Text = "";
            dtPickerLanCuoi.ResetText();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            updateDB(true);
            resetTxt();
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            DBThietBi dbThietBi = new DBThietBi();
            dbThietBi.removeDevice(txtmaThietBi.Text);
            dbThietBi.updateGridData(dataGridThietBi);
            resetTxt();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            updateDB(false);
            resetTxt();
            btnSua.Enabled = false;
        }


        private void txtTangSuat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Nhap Chu So!!!");
                e.Handled = true;
                return;
            }
        }
    }
}
