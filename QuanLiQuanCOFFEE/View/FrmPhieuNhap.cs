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
    public partial class FrmPhieuNhap : Form
    {
        public FrmPhieuNhap()
        {
            InitializeComponent();
           // loadPhieuNhap();
            //loadChitietPN();
        }
        /*private void loadPhieuNhap()
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
                them = "INSERT INTO PHIEUNHAP (MaPN,MaNV,NgayNhap)VALUES('" + cbMaPN1.Text + "','" + cbMaNV1.Text + "',N'" + txtNgaylap.Value + "')";
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
                sua1 = "update PHIEUNHAP set TenPN = N'" + cbMaPN1.Text + "',LoaiHH = '" + cbMaNV1.Text + "' where MaPN1 ='" + cbMaPN2.Text + "'";
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
                xoa1 = "delete from PHIEUNHAP where MaPN = '" + cbMaPN1.Text + "'";
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

         private void dgvHH1_Click_1(object sender, EventArgs e)
        {
            int index = dgvPN1.CurrentRow.Index;
            cbMaPN1.Text = dgvPN1.Rows[index].Cells[0].Value.ToString();
            cbMaNV1.Text = dgvPN1.Rows[index].Cells[1].Value.ToString();
            txtNgaylap.Text = dgvPN1.Rows[index].Cells[2].Value.ToString();
        }

         private void LoadComboxPN()// load 
         {
             SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=qlBH;Integrated Security=True");
             kn.Open();
             SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT * FROM PHIEUNHAP", kn);
             DataTable table = new DataTable();
             da.Fill(table);
             da.Dispose();
             cbMaPN1.DataSource = table;
             cbMaPN1.ValueMember = "MaPN";
         }

        private void LoadComboxNV()
         {
             SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=qlBH;Integrated Security=True");
             kn.Open();
             SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT * FROM NHANVIEN", kn);
             DataTable table = new DataTable();
             da.Fill(table);
             da.Dispose();
             cbMaNV1.DataSource = table;
             cbMaNV1.ValueMember = "MaNV";




         }

        private void FrmPhieuNhap_Load_1(object sender, EventArgs e)
        {
            loadPhieuNhap();
            LoadComboxPN();
            LoadComboxNV();
        }*/


         private void LoadPNhap()
        {
            using ( var db = new qlBHEntities())
            {
                var CT = from PN in db.PHIEUNHAPs
                         orderby PN.MaPN
                         select new
                         {
                             cbMaPN1 = PN.MaPN,
                             cbMaNV1 = PN.MaNV,
                             txtNgaylap = PN.NgayNhap.Value,
                         };
                dgvPN1.DataSource = CT.ToList();
            }
        }

        private void LoadComboboxMaPN()
        {
            var LoadMaPN = new qlBHEntities();
            
            
        }
        private void FrmPhieuNhap_Load(object sender, EventArgs e)
        {
            qlBHEntities db = new qlBHEntities();
            LoadPNhap();
        }












    }
}
