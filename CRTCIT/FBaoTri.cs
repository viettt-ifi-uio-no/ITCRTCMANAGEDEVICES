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
    public partial class FBaoTri : Form
    {
        Timer t = new Timer();
        public FBaoTri()
        {
            InitializeComponent();
            DBNhanVien bnv = new DBNhanVien();
            bnv.updateComboBoxTenOnly(cbNhanVien);
            DBQuyTrinhBT dqt = new DBQuyTrinhBT();
            dqt.updateComboBoxTenOnly(cbQuyTrinh);
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
            string time = "" + DateTime.Now;
            //update label
            lblClock.Text = time;
        }

        private void btnLoadTBHanBaoTri_Click(object sender, EventArgs e)
        {
            DBBaoTri dbBaoTri = new DBBaoTri();
            dbBaoTri.loadThietBiDenHanBaoTri(dataGridTBBT);
        }
    }
}
