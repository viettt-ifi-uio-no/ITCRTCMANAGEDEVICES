using CRTCIT.DataBaseHandler;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRTCIT.FormReport
{
    public partial class frmReportBaoTri : Form
    {
        public frmReportBaoTri()
        {
            InitializeComponent();
        }

        private void frmReportBaoTri_Load(object sender, EventArgs e)
        {

           
            this.rpvBaoCao.RefreshReport();
        }


        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            DBNhanVien dbnv = new DBNhanVien();
            DataSet ds = dbnv.testReport();

            rpvBaoCao.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            //rpvBaoCao.LocalReport.ReportPath = "rptTest.rdlc";

            if (ds.Tables[0].Rows.Count > 0)
            {
                //Tạo nguồn dữ liệu cho báo cáo
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "NhanVien";
                rds.Value = ds.Tables[0];
                //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
                rpvBaoCao.LocalReport.DataSources.Clear();
                //Add dữ liệu vào báo cáo
                rpvBaoCao.LocalReport.DataSources.Add(rds);
                //Refresh lại báo cáo
                rpvBaoCao.RefreshReport();
            }


        }
    }
}
