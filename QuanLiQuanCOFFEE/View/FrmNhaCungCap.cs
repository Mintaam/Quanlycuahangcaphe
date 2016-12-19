using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QuanLiQuanCOFFEE
{
    public partial class FrmNhaCungCap : Form
    {
        public FrmNhaCungCap()
        {
            InitializeComponent();
        }
        private void ketnoi()
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=HUYENNGO\SQLEXPRESS;Initial Catalog=qlBH;Integrated Security=True");
                kn.Open();
                string sql = "select *from NHACUNGCAP";
                SqlCommand commandsql = new SqlCommand(sql, kn);
                SqlDataAdapter com = new SqlDataAdapter(commandsql);
                DataTable table = new DataTable();
                com.Fill(table);
                dgvNCC.DataSource = table;
            }
            catch
            {
                MessageBox.Show("LỖI KẾT NỐI VUI LÒNG KIỂM TRA LẠI!");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"Data Source=HUYENNGO\SQLEXPRESS;Initial Catalog=qlBH;Integrated Security=True");
                kn.Close();
            }
        }
        private void FrmNhaCungCap_Load(object sender, EventArgs e)
        {
            ketnoi();
        }
        int index;
        private void dgvNCC_Click(object sender, EventArgs e)
        {
            index = dgvNCC.CurrentRow.Index;
            txtMaNCC.Text = dgvNCC.Rows[index].Cells[0].Value.ToString();
            txtTenNCC.Text = dgvNCC.Rows[index].Cells[1].Value.ToString();
            txtDiachi.Text = dgvNCC.Rows[index].Cells[2].Value.ToString();
            txtSDT.Text = dgvNCC.Rows[index].Cells[3].Value.ToString();
            txtEmail.Text = dgvNCC.Rows[index].Cells[4].Value.ToString();


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn thoát không?", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
