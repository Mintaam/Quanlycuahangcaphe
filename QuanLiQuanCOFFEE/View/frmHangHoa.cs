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
        }

        private void ketnoi()
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=qlBH;Integrated Security=True");
                kn.Open();
                string sql = "select * from HANGHOA";
                SqlCommand commandsql = new SqlCommand(sql, kn);
                SqlDataAdapter com = new SqlDataAdapter(commandsql);
                DataTable table = new DataTable();
                com.Fill(table);
                dgvHH.DataSource = table;
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            ketnoi();
        }

        private void lbNV_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        int index;

        private void dgvHH_Click(object sender, EventArgs e)
        {
            index = dgvHH.CurrentRow.Index;
            txtMaHH.Text = dgvHH.Rows[index].Cells[0].Value.ToString();
            txtTenHH.Text = dgvHH.Rows[index].Cells[1].Value.ToString();
            txtLoaiHH.Text = dgvHH.Rows[index].Cells[2].Value.ToString();
            txtSoLuong.Text = dgvHH.Rows[index].Cells[3].Value.ToString();
            txtDonGia.Text = dgvHH.Rows[index].Cells[4].Value.ToString();
        }

        string them;

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=qlBH;Integrated Security=True");
                kn.Open();
                them = "INSERT INTO HANGHOA (MaHH,TenHH,LoaiHH,SoLuong,DonGia)VALUES('" + txtMaHH.Text + "','" + txtTenHH.Text + "','" + txtLoaiHH.Text + "','" + txtSoLuong.Text + "','" + txtDonGia.Text + "')";
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
                SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=qlBH;Integrated Security=True");
                kn.Open();
                sua = "update HANGHOA set MaHH ='" + txtMaHH.Text + "',TenHH ='" + txtTenHH.Text + "',LoaiHH = '" + txtLoaiHH.Text + "',SoLuong ='" + txtSoLuong.Text+ "', DonGia = '" + txtDonGia.Text + "' where MaHH = '" + txtMaHH.Text + "'";
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
                SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=qlBH;Integrated Security=True");
                kn.Open();
                xoa = "delete from HANGHOA where MaHH = '" + txtMaHH.Text + "'"; 
                SqlCommand commandxoa = new SqlCommand(xoa, kn);
                commandxoa.ExecuteNonQuery();
                ketnoi();
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

        private void dgvHH1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
