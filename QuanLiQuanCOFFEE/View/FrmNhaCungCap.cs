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
                SqlConnection kn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=qlBH;Integrated Security=True");
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
                SqlConnection kn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=qlBH;Integrated Security=True");
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
        string them;
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=qlBH;Integrated Security=True");
                kn.Open();
                them = "INSERT INTO NHACUNGCAP (MaNCC,TenNCC,Diachi,Sdt,[E-Mail])VALUES('" + txtMaNCC.Text + "','" + txtTenNCC.Text + "','" + txtDiachi.Text + "','" + txtSDT.Text + "','" + txtEmail.Text + "')";
                SqlCommand commandthem = new SqlCommand(them, kn);
                commandthem.ExecuteNonQuery();
                ketnoi();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        string sua;
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=qlBH;Integrated Security=True");
                kn.Open();
                sua = "update NCC set MaNCC ='" + txtMaNCC.Text + "',tenNV ='" + txtTenNCC.Text + txtDiachi.Text + "',Sdt= '" + txtSDT.Text + "',[E-Mail] = '" + txtEmail.Text + "' where MaNCC = '" + txtMaNCC.Text + "'";
                SqlCommand commandsua = new SqlCommand(sua, kn);
                commandsua.ExecuteNonQuery();
                ketnoi();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        string xoa;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=qlBH;Integrated Security=True");
                kn.Open();
                xoa = "delete NHANVIEN set MaNCC='" + txtMaNCC.Text + "',tenNCC ='" + txtTenNCC.Text + txtDiachi.Text + "',Sdt= '" + txtSDT.Text + "',[E-Mail]= '" + txtEmail.Text + "' where MaNCC='" + txtMaNCC.Text + "'";
                SqlCommand commandxoa = new SqlCommand(xoa, kn);
                commandxoa.ExecuteNonQuery();
                ketnoi();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn thoát không?", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
