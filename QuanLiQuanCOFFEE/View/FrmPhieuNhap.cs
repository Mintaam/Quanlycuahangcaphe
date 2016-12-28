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
    public partial class FrmPhieuNhap : Form
    {
        public FrmPhieuNhap()
        {
            InitializeComponent();
            loadPhieuNhap();
            loadChitietPN();
        }
        private void loadPhieuNhap()
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=qlBH;Integrated Security=True");
                kn.Open();
                string sql = "select * from PHIEUNHAP";
                SqlCommand commandsql = new SqlCommand(sql, kn);
                SqlDataAdapter com = new SqlDataAdapter(commandsql);
                DataTable table = new DataTable();
                com.Fill(table);
                dgvPN1.DataSource = table;

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
        private void loadChitietPN()
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=qlBH;Integrated Security=True");
                kn.Open();
                string sql = "select * from CHITIETPHIEUNHAP";
                SqlCommand commandsql = new SqlCommand(sql, kn);
                SqlDataAdapter com = new SqlDataAdapter(commandsql);
                DataTable table = new DataTable();
                com.Fill(table);
                dgvPN2.DataSource = table;

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



        
        string them;

        private void btnThem1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=qlBH;Integrated Security=True");
                kn.Open();
                them = "INSERT INTO PHIEUNHAP (MaPN,MaNV,NgayNhap)VALUES('" + txtMaPN1.Text + "','" + cbMaNV1.Text + "',N'" + txtNgaylap.Value + "')";
                SqlCommand commandthem = new SqlCommand(them, kn);
                commandthem.ExecuteNonQuery();
                loadChitietPN();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        string sua1;
        private void btnSua1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=qlBH;Integrated Security=True");
                kn.Open();
                sua1 = "update PHIEUNHAP set TenPN = N'" + txtMaPN1.Text + "',LoaiHH = '" + cbMaNV1.Text + "' where MaPN1 ='" + cbMaPN2.Text + "'";
                SqlCommand commandsua1 = new SqlCommand(sua1, kn);
                commandsua1.ExecuteNonQuery();
                loadPhieuNhap();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        string xoa1;
        private void btnXoa1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=qlBH;Integrated Security=True");
                kn.Open();
                xoa1 = "delete from PHIEUNHAP where MaPN = '" + txtMaPN1.Text + "'";
                SqlCommand commandxoa1 = new SqlCommand(xoa1, kn);
                commandxoa1.ExecuteNonQuery();
                loadPhieuNhap();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat1_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn thoát không?", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                Application.Exit();
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
             cbMaNV1.DataSource = table;
             cbMaNV1.ValueMember = "MaNV";
             kn.Close();
         }



        private void LoadcbbHangHoa()// load 
        {
            SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=qlBH;Integrated Security=True");
            kn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT * FROM HANGHOA", kn);
            DataTable table = new DataTable();
            da.Fill(table);
            da.Dispose();
            cbMaHH2.DataSource = table;
            cbMaHH2.ValueMember = "MaHH";
            kn.Close();
        }

        private void LoadcbbPhieuNhap()
        {
            SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=qlBH;Integrated Security=True");
            kn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT * FROM PHIEUNHAP", kn);
            DataTable table = new DataTable();
            da.Fill(table);
            da.Dispose();
            cbMaPN2.DataSource = table;
            cbMaPN2.ValueMember = "MaPN";
            kn.Close();
        }

       


        

       
        private void FrmPhieuNhap_Load(object sender, EventArgs e)
        {
           loadPhieuNhap();
            LoadcbbNhanVien();
            LoadcbbHangHoa();
            LoadcbbPhieuNhap();
        }

        private void dgvPN1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvPN1.CurrentRow.Index;
            txtMaPN1.Text = dgvPN1.Rows[index].Cells[0].Value.ToString();
            cbMaNV1.Text = dgvPN1.Rows[index].Cells[1].Value.ToString();
            txtNgaylap.Text = dgvPN1.Rows[index].Cells[2].Value.ToString();
        }

        private void dgvPN2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvPN2.CurrentRow.Index;
             cbMaPN2.Text = dgvPN2.Rows[index].Cells[0].Value.ToString();
             cbMaHH2.Text = dgvPN2.Rows[index].Cells[1].Value.ToString();
             txtSoLuong.Text = dgvPN2.Rows[index].Cells[2].Value.ToString();
             txtDonGia.Text = dgvPN2.Rows[index].Cells[3].Value.ToString();
        }

        private void btnThem1_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=qlBH;Integrated Security=True");
                kn.Open();
                string them = "INSERT INTO PHIEUNHAP (MaPN,MaNV,NgayNhap)VALUES('" + txtMaPN1.Text + "','" + cbMaNV1.Text + "',N'" + txtNgaylap.Value + "')";
                SqlCommand commandthem = new SqlCommand(them, kn);
                commandthem.ExecuteNonQuery();
                loadPhieuNhap();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua1_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=qlBH;Integrated Security=True");
                kn.Open();
                string sua1 = "update PHIEUNHAP set TenPN = N'" + txtMaPN1.Text + "',LoaiHH = '" + cbMaNV1.Text + "' where MaPN1 ='" + cbMaPN2.Text + "'";
                SqlCommand commandsua1 = new SqlCommand(sua1, kn);
                commandsua1.ExecuteNonQuery();
                loadPhieuNhap();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa1_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=qlBH;Integrated Security=True");
                kn.Open();
                string xoa1 = "delete from PHIEUNHAP where MaPN = '" + txtMaPN1.Text + "'";
                SqlCommand commandxoa1 = new SqlCommand(xoa1, kn);
                commandxoa1.ExecuteNonQuery();
                loadPhieuNhap();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat1_Click_1(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn thoát không?", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }















    }
}
