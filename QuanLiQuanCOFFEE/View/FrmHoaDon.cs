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
    public partial class FrmHoaDon : Form
    {
        public FrmHoaDon()
        {
            InitializeComponent();
            LoadHoaDon();
            LoadChitietHD();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            LoadHoaDon();
            LoadcbbNhanVien();
            LoadcbbBan();
            LoadcbbThucDon();
            LoadcbbHoaDon();
        }


        private void LoadHoaDon()
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=qlBH;Integrated Security=True;");
                kn.Open();
                string sql = "select * from HOADON";
                SqlCommand commandsql = new SqlCommand(sql, kn);
                SqlDataAdapter com = new SqlDataAdapter(commandsql);
                DataTable table = new DataTable();
                com.Fill(table);
                dgvHD1.DataSource = table;

            }
            catch
            {
                MessageBox.Show("LỖI KẾT NỐI VUI LÒNG KIỂM TRA LẠI!");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=qlBH;Integrated Security=True;");
                kn.Close();
            }
        }



        private void LoadChitietHD()
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=qlBH;Integrated Security=True");
                kn.Open();
                string sql = "select * from CHITIETHOADON";
                SqlCommand commandsql = new SqlCommand(sql, kn);
                SqlDataAdapter com = new SqlDataAdapter(commandsql);
                DataTable table = new DataTable();
                com.Fill(table);
                dgvHD2.DataSource = table;

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



        private void LoadcbbNhanVien()
        {
            SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=qlBH;Integrated Security=True");
            kn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT * FROM NHANVIEN", kn);
            DataTable table = new DataTable();
            da.Fill(table);
            da.Dispose();
            cbMaNV.DataSource = table;
            cbMaNV.ValueMember = "MaNV";
            kn.Close();
        }

        private void LoadcbbBan()
        {
            SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=qlBH;Integrated Security=True");
            kn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BAN", kn);
            DataTable table = new DataTable();
            da.Fill(table);
            da.Dispose();
            cbMaBan.DataSource = table;
            cbMaBan.ValueMember = "MaBan";
            kn.Close();
        }

        private void LoadcbbThucDon()
        {
            SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=qlBH;Integrated Security=True");
            kn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT * FROM THUCDON", kn);
            DataTable table = new DataTable();
            da.Fill(table);
            da.Dispose();
            cbMaMon.DataSource = table;
            cbMaMon.ValueMember = "MaMon";
            kn.Close();
        }


        private void LoadcbbHoaDon()
        {
            SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=qlBH;Integrated Security=True");
            kn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT * FROM HOADON", kn);
            DataTable table = new DataTable();
            da.Fill(table);
            da.Dispose();
            cbMaHD.DataSource = table;
            cbMaHD.ValueMember = "MaHD";
            kn.Close();
        }

        private void dgvHD1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvHD1.CurrentRow.Index;

            txtMaHD.Text = dgvHD1.Rows[index].Cells[0].Value.ToString();
            cbMaNV.Text = dgvHD1.Rows[index].Cells[1].Value.ToString();
            cbMaBan.Text = dgvHD1.Rows[index].Cells[2].Value.ToString();
            txtNgaylap.Text = dgvHD1.Rows[index].Cells[3].Value.ToString();
        }

        private void dgvHD2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvHD2.CurrentRow.Index;
            cbMaHD.Text = dgvHD2.Rows[index].Cells[0].Value.ToString();
            cbMaMon.Text = dgvHD2.Rows[index].Cells[1].Value.ToString();
            txtSoLuong.Text = dgvHD2.Rows[index].Cells[2].Value.ToString();
            txtThanhTien.Text = dgvHD2.Rows[index].Cells[3].Value.ToString();
        }

        private void btnThem1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=qlBH;Integrated Security=True");
                kn.Open();
                string them = "INSERT INTO HOADON (MaHD,MaNV,MaBan,NgayLap)VALUES('" + txtMaHD.Text + "','" + cbMaNV.Text + "','" + cbMaBan.Text + "','" + txtNgaylap.Value + "')";
                SqlCommand commandthem = new SqlCommand(them, kn);
                commandthem.ExecuteNonQuery();
                LoadHoaDon();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=qlBH;Integrated Security=True");
                kn.Open();
                string sua1 = "update HOADON set MaHD = N'" + txtMaHD.Text + "',MaNV ='" + cbMaNV.Text + "',MaBan ='" + cbMaBan.Text + "',Ngaylap ='" + txtNgaylap.Value + "' where MaHD = '" + txtMaHD.Text + "'";
                SqlCommand commandsua1 = new SqlCommand(sua1, kn);
                commandsua1.ExecuteNonQuery();
                LoadHoaDon();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=qlBH;Integrated Security=True");
                kn.Open();
                string xoa1 = "delete from HOADON where MaHD = '" + txtMaHD.Text + "'";
                SqlCommand commandxoa1 = new SqlCommand(xoa1, kn);
                commandxoa1.ExecuteNonQuery();
                LoadHoaDon();
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

        private void btnThem2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=qlBH;Integrated Security=True");
                kn.Open();
                string them = "INSERT INTO CHITIETHOADON (MaHD,MaMon,SoLuong,ThanhTien)VALUES('" + cbMaHD.Text + "','" + cbMaMon.Text + "','" + txtSoLuong.Text + "','" + txtThanhTien.Text + "')";
                SqlCommand commandthem = new SqlCommand(them, kn);
                commandthem.ExecuteNonQuery();
                LoadChitietHD();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=qlBH;Integrated Security=True");
                kn.Open();
                string sua = "update CHITIETHOADON set MaHD ='" + cbMaHD.Text + "',MaMon ='" + cbMaMon.Text + "',SoLuong ='" + txtSoLuong.Text + "',ThanhTien ='" + txtThanhTien.Text + "' where MaHD = '" + cbMaHD.Text + "'";
                SqlCommand commandsua = new SqlCommand(sua, kn);
                commandsua.ExecuteNonQuery();
                LoadChitietHD();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=qlBH;Integrated Security=True");
                kn.Open();
                string xoa = "delete from CHITIETHOADON where MaHD = '" + cbMaHD.Text + "'";
                SqlCommand commandxoa = new SqlCommand(xoa, kn);
                commandxoa.ExecuteNonQuery();
                LoadChitietHD();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat2_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn thoát không?", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }







    }
}
