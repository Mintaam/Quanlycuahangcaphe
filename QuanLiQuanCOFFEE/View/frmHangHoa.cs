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
    public partial class FrmHangHoa : Form
    {
        public FrmHangHoa()
        {
            InitializeComponent();
            loadHangHoa();
            loadChitietHH();
        }

        private void loadHangHoa()
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=QLCF2;Integrated Security=True");
                kn.Open();
                string sql = "select * from HANGHOA";
                SqlCommand commandsql = new SqlCommand(sql, kn);
                SqlDataAdapter com = new SqlDataAdapter(commandsql);
                DataTable table = new DataTable();
                com.Fill(table);
                dgvHH1.DataSource = table;
               
            }
            catch
            {
                MessageBox.Show("LỖI KẾT NỐI VUI LÒNG KIỂM TRA LẠI!");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=QLCF2;Integrated Security=True");
                kn.Close();
            }
        }
        private void loadChitietHH()
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=QLCF2;Integrated Security=True");
                kn.Open();
                string sql = "select * from CHITIETHANGHOA";
                SqlCommand commandsql = new SqlCommand(sql, kn);
                SqlDataAdapter com = new SqlDataAdapter(commandsql);
                DataTable table = new DataTable();
                com.Fill(table);
                dgvHH2.DataSource = table;

            }
            catch
            {
                MessageBox.Show("LỖI KẾT NỐI VUI LÒNG KIỂM TRA LẠI!");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=QLCF2;Integrated Security=True");
                kn.Close();
            }
        }

     

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            loadHangHoa();
        }

        int index;

        private void dgvHH1_Click(object sender, EventArgs e)
        {
            index = dgvHH1.CurrentRow.Index;
            txtMaHH1.Text = dgvHH1.Rows[index].Cells[0].Value.ToString();
            txtTenHH1.Text = dgvHH1.Rows[index].Cells[1].Value.ToString();
            txtLoaiHH1.Text = dgvHH1.Rows[index].Cells[2].Value.ToString();
           
        }

       

        private void dgvHH2_Click(object sender, EventArgs e)
        {
            index = dgvHH2.CurrentRow.Index;
            txtMaNCC.Text = dgvHH2.Rows[index].Cells[0].Value.ToString();
            txtMaHH.Text = dgvHH2.Rows[index].Cells[1].Value.ToString();
            txtSoLuong.Text = dgvHH2.Rows[index].Cells[2].Value.ToString();
            txtDonGia.Text = dgvHH2.Rows[index].Cells[3].Value.ToString();
           
        }

        string them;
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=QLCF2;Integrated Security=True");
                kn.Open();
                them = "INSERT INTO CHITIETHANGHOA (MaNCC,MaHH,SoLuong,DonGia)VALUES('" + txtMaNCC.Text + "','" + txtMaHH.Text + "','" + txtSoLuong.Text + "','" + txtDonGia.Text + "')";
                SqlCommand commandthem = new SqlCommand(them, kn);
                commandthem.ExecuteNonQuery();
                loadChitietHH();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        string xoa;
        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=QLCF2;Integrated Security=True");
                kn.Open();
                xoa = "delete from CHITIETHANGHOA where MaHH = '" + txtMaHH.Text + "'";
                SqlCommand commandxoa = new SqlCommand(xoa, kn);
                commandxoa.ExecuteNonQuery();
                loadChitietHH();
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

        string sua;
        private void btnSua_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=QLCF2;Integrated Security=True");
                kn.Open();
                sua = "update CHITIETHANGHOA set MaNCC ='" + txtMaNCC.Text + "',MaHH ='" + txtMaHH.Text + "',,SoLuong ='" + txtSoLuong.Text+ "', DonGia = '" + txtDonGia.Text + "' where MaHH = '" + txtMaHH.Text + "'";
                SqlCommand commandsua = new SqlCommand(sua, kn);
                commandsua.ExecuteNonQuery();
                loadChitietHH();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        string them1;
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=QLCF2;Integrated Security=True");
                kn.Open();
                them1 = "INSERT INTO HANGHOA (MaHH,TenHH,LoaiHH)VALUES('" + txtMaHH1.Text + "','" + txtTenHH1.Text + "','" + txtLoaiHH1.Text + "')";
                SqlCommand commandthem1 = new SqlCommand(them1, kn);
                commandthem1.ExecuteNonQuery();
                loadHangHoa();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        string sua1;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=QLCF2;Integrated Security=True");
                kn.Open();
                sua1 = "update HANGHOA set MaHH ='" + txtMaHH.Text + "',TenHH ='" + txtTenHH1.Text + "',LoaiHH = '" + txtLoaiHH1.Text + "' where MaHH = '" + txtMaHH.Text + "'";
                SqlCommand commandsua1 = new SqlCommand(sua1, kn);
                commandsua1.ExecuteNonQuery();
                loadHangHoa();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        string xoa1;
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=QLCF2;Integrated Security=True");
                kn.Open();
                xoa1 = "delete from HANGHOA where MaHH = '" + txtMaHH1.Text + "'";
                SqlCommand commandxoa1 = new SqlCommand(xoa1, kn);
                commandxoa1.ExecuteNonQuery();
                loadHangHoa();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn thoát không?", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }


    }
}