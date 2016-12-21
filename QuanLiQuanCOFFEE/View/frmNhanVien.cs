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
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=qlBH;Integrated Security=True");
                kn.Open();
                string sql = "select *from NHANVIEN";
                SqlCommand commandsql = new SqlCommand(sql, kn);
                SqlDataAdapter com = new SqlDataAdapter(commandsql);
                DataTable table = new DataTable();
                com.Fill(table);
                dgvNV.DataSource = table;
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

        int index;
       private void dgvNV_Click(object sender, EventArgs e)
        {
           index = dgvNV.CurrentRow.Index;
           txtMaNV.Text = dgvNV.Rows[index].Cells[0].Value.ToString();
           txtTenNv.Text = dgvNV.Rows[index].Cells[1].Value.ToString();
           txtChucvu.Text = dgvNV.Rows[index].Cells[2].Value.ToString();
           txtNgayvaolam.Text = dgvNV.Rows[index].Cells[3].Value.ToString();
           txtDiachi.Text = dgvNV.Rows[index].Cells[4].Value.ToString();
           txtSDT.Text = dgvNV.Rows[index].Cells[5].Value.ToString();
           txtEmail.Text = dgvNV.Rows[index].Cells[6].Value.ToString();


        }
       string them;
       private void btnThem_Click(object sender, EventArgs e)
       {
           try
           {
               SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=qlBH;Integrated Security=True");
               kn.Open();
               them = "INSERT INTO NHANVIEN (MaNV,TenNV,ChucVu,NgayVaoLam,Diachi,Sdt,[E-Mail])VALUES('" +txtMaNV.Text+ "','" +txtTenNv.Text+ "','" +txtChucvu.Text+ "','" +txtNgayvaolam.Value+ "','" +txtDiachi.Text+ "','" +txtSDT.Text+ "','" +txtEmail.Text+ "')";
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
       private void btnSua_Click_1(object sender, EventArgs e)
       {
           try
           {
               SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=qlBH;Integrated Security=True");
                kn.Open();
                sua = "update NHANVIEN set MaNV ='"+txtMaNV.Text+"',tenNV ='"+txtTenNv.Text+"',ChucVu = '"+txtChucvu.Text+"',NgayVaoLam ='"+txtNgayvaolam.Value+"',DiaChi = '"+txtDiachi.Text+"',Sdt= '"+txtSDT.Text+ "',[E-Mail] = '"+txtEmail.Text+"' where MaNV = '"+txtMaNV.Text+"'";
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
               xoa = "delete from NHANVIEN where MaNV = '"+ txtMaNV.Text + "'";//,tenNV ='" + txtTenNv.Text + "',ChucVu = '" + txtChucvu.Text + "',NgayVaoLam ='" + txtNgayvaolam.Value + "',DiaChi ='" + txtDiachi.Text + "',Sdt= '" + txtSDT.Text +"',[E-Mail]= '" +txtEmail.Text+ "' where MaNV='" + txtMaNV.Text + "'";
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

       private void dgvNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
       {

       }
    }
}
