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
    public partial class FQuyTrinhBaoTri : Form
    {
        public FQuyTrinhBaoTri()
        {
            InitializeComponent();
            DBQuyTrinhBT quytrinh = new DBQuyTrinhBT();
            quytrinh.updateGridData(dataGridQuyTrinh);
            DBNhanVien nv = new DBNhanVien();
            nv.updateComboBoxTenOnly(cbNguoiViet);
        }




        private void updateDB(bool isNewQT)
        {
            QuyTrinhBT quytrinh = new QuyTrinhBT();

            quytrinh.maQTBT = txtMaQT.Text;
            quytrinh.tenQTBT = txtTenQT.Text;
            quytrinh.noidungQT  = rtbNoidung.Text;
            quytrinh.tennguoiviet  = cbNguoiViet.GetItemText(cbNguoiViet.SelectedItem);

            if ((txtMaQT.Text == "" ) || (txtTenQT.Text == "" ) || (cbNguoiViet.Text == "" ))
            {
                MessageBox.Show(this, "Vui Long Dien Ma, TenQT Va Ten Nguoi Viet", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DBQuyTrinhBT dbquytrinh = new DBQuyTrinhBT();
            if (isNewQT) dbquytrinh.addnewQuyTrinh(quytrinh, false);
            else dbquytrinh.addnewQuyTrinh(quytrinh, true);
            dbquytrinh.updateGridData(dataGridQuyTrinh);

        }





        private void dataGridQuyTrinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = e.RowIndex;
            if (rowIndex < 0) return;
            DataGridViewRow row = dataGridQuyTrinh.Rows[rowIndex];
            txtMaQT.Text = row.Cells[0].Value.ToString();
            txtTenQT.Text = row.Cells[1].Value.ToString();
            cbNguoiViet.Text = row.Cells[2].Value.ToString();
            rtbNoidung.Text = row.Cells[3].Value.ToString();
            btnSua.Enabled = true;

        }




        private void resetTxt()
        {
            txtMaQT.Text = "";
            txtTenQT.Text = "";
            rtbNoidung.Text = "";
            cbNguoiViet.SelectedIndex = -1;
        }






        private void btnThem_Click(object sender, EventArgs e)
        {
            // updateDB(true);
            // resetTxt();
            /* int t = Convert.ToInt32(txtMaQT.Text);
             string sql = "SELECT ID FROM QuyTrinhBaoTri WHERE ID=t";
             if (sql == "")
             {
                 updateDB(true);
                 resetTxt();
             }
             else
             {
                 MessageBox.Show(sql);

                 txtMaQT.Focus();
             }*/



            string s = dataGridQuyTrinh.RowCount.ToString();
            int t = Convert.ToInt32(s);
            int kt = 0;
            if (t - 1 > 0)
            {
                for (int i = 0; i < t - 1; i++)
                {
                    
                    if (dataGridQuyTrinh.Rows[i].Cells[0].Value.ToString() == txtMaQT.Text)
                    {
                        MessageBox.Show("Trung Ma Quy Trinh!!!");
                        txtMaQT.Focus();
                        return;
                    }
                    else
                    {
                        kt = 1;
                    }
                }

            }
            else
            {
                updateDB(true);
                resetTxt();

            }


            if (kt == 1)
            {
                updateDB(true);
                resetTxt();
            }
            

            // MessageBox.Show(dataGridQuyTrinh.RowCount.ToString());
            //MessageBox.Show(dataGridQuyTrinh.Rows[1].Cells[0].Value.ToString());



        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DBQuyTrinhBT dbquytrinh = new DBQuyTrinhBT ();
            dbquytrinh.removeQuyTrinh(txtMaQT.Text);
            dbquytrinh.updateGridData(dataGridQuyTrinh);
            resetTxt();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            updateDB(false);
            resetTxt();
            btnSua.Enabled = false;
        }

        private void dataGridQuyTrinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
