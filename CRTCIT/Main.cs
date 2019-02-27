using CRTCIT.FormReport;
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
    public partial class Main : Form
    {
        Form test, thietBi, nhanVien, nhomThietBi, baoTri, xuLySuCo, quyTrinhBaoTri, quyTrinhXuLySuCo, baoCao;
        public Main()
        {
            InitializeComponent();
        }

        

        void test_Closed(object sender, EventArgs e)
        {
            test = null;
        }
        void baoCao_Closed(object sender, EventArgs e)
        {
            baoCao = null;
        }

        void thietBi_Closed(object sender, EventArgs e)
        {
            thietBi = null;
        }

        void nhanVien_Closed(object sender, EventArgs e)
        {
            nhanVien = null;
        }

        void nhomThietBi_Closed(object sender, EventArgs e)
        {
            nhomThietBi = null;
        }

        void baoTri_Closed(object sender, EventArgs e)
        {
            baoTri = null;
        }

        void xuLySuCo_Closed(object sender, EventArgs e)
        {
            xuLySuCo = null;
        }

        void quyTrinhBaoTri_Closed(object sender, EventArgs e)
        {
            quyTrinhBaoTri = null;
        }

        void quyTrinhXuLySuCo_Closed(object sender, EventArgs e)
        {
            quyTrinhXuLySuCo = null;
        }

        private void btnTEST_Click(object sender, EventArgs e)
        {
            if (test != null) return;
            test = new Form1();
            test.Closed += test_Closed;
            test.Show();
        }

        private void btnThietBi_Click(object sender, EventArgs e)
        {
            if (thietBi != null) return;
            thietBi = new FThietBi();
            thietBi.Closed += thietBi_Closed;
            thietBi.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            if (nhanVien != null) return;
            nhanVien = new FNhanVien();
            nhanVien.Closed += nhanVien_Closed;
            nhanVien.Show();
        }

        private void btnNhomThietBi_Click(object sender, EventArgs e)
        {
            if (nhomThietBi != null) return;
            nhomThietBi = new FNhomThietBi();
            nhomThietBi.Closed += nhomThietBi_Closed;
            nhomThietBi.Show();
        }

        private void btnBaoTri_Click(object sender, EventArgs e)
        {
            if (baoTri != null) return;
            baoTri = new FBaoTri();
            baoTri.Closed += baoTri_Closed;
            baoTri.Show();
        }

        private void btnXuLySuCo_Click(object sender, EventArgs e)
        {
            if (xuLySuCo != null) return;
            xuLySuCo = new FQuyTrinhXuLySuCo();
            xuLySuCo.Closed += xuLySuCo_Closed;
            xuLySuCo.Show();
        }

        private void btnQuyTrinhBaoTri_Click(object sender, EventArgs e)
        {
            if (quyTrinhBaoTri != null) return;
            quyTrinhBaoTri = new FQuyTrinhBaoTri();
            quyTrinhBaoTri.Closed += quyTrinhBaoTri_Closed;
            quyTrinhBaoTri.Show();
        }

        private void btnQuyTrinhXuLySuCo_Click(object sender, EventArgs e)
        {
            if (quyTrinhXuLySuCo != null) return;
            quyTrinhXuLySuCo = new FQuyTrinhXuLySuCo();
            quyTrinhXuLySuCo.Closed += quyTrinhXuLySuCo_Closed;
            quyTrinhXuLySuCo.Show();
        }






        private void btnReport_Click(object sender, EventArgs e)
        {
            if (baoCao != null) return;
            baoCao = new frmReportBaoTri();
            baoCao.Closed += baoCao_Closed;
            baoCao.Show();
        }

    }
}
