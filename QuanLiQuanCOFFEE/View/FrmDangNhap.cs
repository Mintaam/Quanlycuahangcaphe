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
using System.Configuration;

namespace QuanLiQuanCOFFEE
{
    public partial class FrmDangNhap : Form
    {
        frmchinh Ql;
        string cnStr = @"Data Source= .;Initial Catalog=qlBH;Integrated Security=True";
       
        SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=qlBH;Integrated Security=True");
        SqlCommand cmd;
       
        public FrmDangNhap()
        {
            InitializeComponent();
        }

       
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không?","Thông báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;

            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
           /* frmchinh f = new frmchinh();
            this.Hide();
            f.ShowDialog();
            this.Show();*/
             try
            {
                kn = new SqlConnection(cnStr);
                kn.Open();
                string sql = "SELECT Count(*) FROM [qlBH].[dbo].[TAIKHOAN] WHERE MaNV = @acc AND MatKhau =@pass ";
                cmd = new SqlCommand(sql, kn);
                cmd.Parameters.Add(new SqlParameter("@acc", txtUsername.Text));
                cmd.Parameters.Add(new SqlParameter("@pass", txtPass.Text));
                int x = (int)cmd.ExecuteScalar();
                if (x==1)
                {
                    this.Hide();
                    Ql = new frmchinh();
                    Ql.Show();
                }
                else
                {
                    MessageBox.Show("MÃ NHÂN VIÊN HOẶC MẬT KHẨU KHÔNG ĐÚNG!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
              
            }
        }
        

       
    }
}
