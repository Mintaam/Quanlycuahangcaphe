using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace QuanLiQuanCOFFEE
{
    public partial class FrmThongKe : Form
    {
        public FrmThongKe()
        {
            InitializeComponent();

        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            LoadComboxNgaylap();
            // TODO: This line of code loads data into the 'DSTKHD.DataTable1' table. You can move, or remove it, as needed.
      
        }
        private void LoadComboxNgaylap()// load 
        {
            SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=qlBH;Integrated Security=True");
            kn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT * FROM HOADON", kn);
            DataTable table = new DataTable();
            da.Fill(table);
            da.Dispose();
            cbThongKe.DataSource = table;
            cbThongKe.ValueMember = "Ngaylap";
        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            this.DataTable1TableAdapter.Fill(this.DSTKHD.DataTable1,cbThongKe.SelectedValue.ToString());

            this.reportViewer1.RefreshReport();
        }
    }
}