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
namespace QuanLiQuanCOFFEE
{
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }
        private void ketnoi()
        {
            SqlConnection kn = new SqlConnection(@"Data Source=HUYENNGO\SQLEXPRESS;Initial Catalog=qlBH;Integrated Security=True");
            kn.Open();
            string sql = "select *from NHANVIEN";
            SqlCommand commandsql = new SqlCommand(sql, kn);
            SqlDataAdapter com = new SqlDataAdapter(commandsql);
            DataTable table = new DataTable();
            com.Fill(table);
            dgvNV.DataSource = table;

        }
        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            ketnoi();


        }
    }
}
