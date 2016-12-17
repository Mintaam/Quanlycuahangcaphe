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
        internal static List<byte> typePage = new List<byte>();
        public void ThemTabPages(UserControl utc, byte typeControl, string tenTab)
        {
            //Hien thi trang ton tai chua
            for (int i = 0; i < tabHienThi.TabPages.Count; i++)
            {
                if (tabHienThi.TabPages[i].Contains(utc) == true)
                {
                    tabHienThi.SelectedTab = tabHienThi.TabPages[i];
                        return;
                }
            }
            TabPage tab = new TabPage ();
            typePage.Add(typeControl);
            tab.Name = utc.Name;
            tab.Size = tabHienThi.Size;
            tab.Text = tenTab;
            tabHienThi.TabPages.Add(tab);
            tabHienThi.SelectedTab = tab;
            utc.Dock = DockStyle.Fill;
            tab.Controls.Add(utc);
            utc.Focus();
        }
        //Dong tab hien tai
        public void DongTabHienTai()
        {
            tabHienThi.TabPages.Remove(tabHienThi.SelectedTab);
        }
        //Dong all tab
        public
             void DongAllTab()
            {
                while(tabHienThi.TabPages.Count>0)
                {
                    DongTabHienTai();
                }
            }

        private void tênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(View.FrmNhanVien,4
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmchinh_Load(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
