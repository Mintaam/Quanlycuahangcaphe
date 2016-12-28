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
    public partial class FrmBan : Form
    {
        public FrmBan()
        {
            InitializeComponent();
            LoadBan();
        }


        private void LoadBan()
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=. ;Initial Catalog=qlBH;Integrated Security=True");
                kn.Open();
                string sql = "select * from BAN";
                SqlCommand commandsql = new SqlCommand(sql, kn);
                SqlDataAdapter com = new SqlDataAdapter(commandsql);
                DataTable table = new DataTable();
                com.Fill(table);
                dgvBan.DataSource = table;

            }
            catch
            {
                MessageBox.Show("LỖI KẾT NỐI VUI LÒNG KIỂM TRA LẠI!");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=qlBH;Integrated Security=True");
                kn.Close();
            }
        }

        private void dgvBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

        string Them;
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-R128S04\SQLEXPRESS;Initial Catalog=qlBH;Integrated Security=True");
                kn.Open();
                Them = "INSERT INTO BAN (MaBan,TenBan,TrangThaiBan)VALUES('" + txtMaBan.Text + "','" + txtTenBan.Text + "','" + cbbTrangThaiBan.Text + "')";
                SqlCommand commandthem = new SqlCommand(Them, kn);
                commandthem.ExecuteNonQuery();
                LoadBan();
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
                SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-R128S04\SQLEXPRESS;Initial Catalog=qlBH;Integrated Security=True");
                kn.Open();
                sua = "update BAN set MaBan ='" + txtMaBan.Text + "',TenBan ='" + txtTenBan.Text + "', TrangThaiBan = '" + cbbTrangThaiBan.Text + "' where MaBan = '" + txtMaBan.Text + "'";
                SqlCommand commandsua = new SqlCommand(sua, kn);
                commandsua.ExecuteNonQuery();
                LoadBan();
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
                SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-R128S04\SQLEXPRESS;Initial Catalog=qlBH;Integrated Security=True");
                kn.Open();
                xoa = "delete from BAN where MaBan = '" + txtMaBan.Text + "'";
                SqlCommand commandxoa = new SqlCommand(xoa, kn);
                commandxoa.ExecuteNonQuery();
                LoadBan();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn thoát không?", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void LoadComboxBan()// load 
        {
            SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-R128S04\SQLEXPRESS;Initial Catalog=qlBH;Integrated Security=True");
            kn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT * FROM BAN", kn);
            DataTable table = new DataTable();
            da.Fill(table);
            da.Dispose();
            cbbTrangThaiBan.DataSource = table;
            cbbTrangThaiBan.ValueMember = "TrangThaiBan";
        }

        private void dgvBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvBan.CurrentRow.Index;
            txtMaBan.Text = dgvBan.Rows[index].Cells[0].Value.ToString();
            txtTenBan.Text = dgvBan.Rows[index].Cells[1].Value.ToString();
            cbbTrangThaiBan.Text = dgvBan.Rows[index].Cells[2].Value.ToString();
        }




    }
}
