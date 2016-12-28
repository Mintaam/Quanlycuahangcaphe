using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiQuanCOFFEE
{
    public partial class frmchinh : Form
    {
        public frmchinh()
        {
            InitializeComponent();
        }


        

        private void frmchinh_Load(object sender, EventArgs e)
        {

        }

       

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát ? ", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
                return;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbChoose_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
        }

        private void NVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNhanVien f = new FrmNhanVien();
            f.MdiParent = this;
            f.Show();
        }

        private void HHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHangHoa f = new FrmHangHoa();
            f.MdiParent = this;
            f.Show();
        }

        private void NCCToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmNhaCungCap f = new FrmNhaCungCap();
            f.MdiParent = this;
            f.Show();
        }

        private void TDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmThucDon f = new FrmThucDon();
            f.MdiParent = this;
            f.Show();
        }

        private void PNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPhieuNhap f = new FrmPhieuNhap();
            f.MdiParent = this;
            f.Show();
        }

        private void HDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHoaDon f = new FrmHoaDon();
            f.MdiParent = this;
            f.Show();
        }

        private void bànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBan f = new FrmBan();
            f.MdiParent = this;
            f.Show();
        }

        private void OrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmorder f = new Frmorder();
            f.MdiParent = this;
            f.Show();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmThongKe f = new FrmThongKe();
            f.Show();
        }

       
      

       

      
    }
}
