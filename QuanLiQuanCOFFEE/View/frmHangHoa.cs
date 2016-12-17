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

        private void connect()
        {
          try
          {
              SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-R128S04\SQLEXPRESS;Initial Catalog=QLCF2;Integrated Security=True");
            cn.Open();
            string sql = "SELECT * FROM HANGHOA";
            SqlCommand commandsql = new SqlCommand(sql,cn);
            SqlDataAdapter com = new SqlDataAdapter(commandsql);
            DataTable table = new DataTable();
            com.Fill(table);
            dataGridView1.DataSource = table;
         }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
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
            connect();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        int index;
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentRow.Index;
            txtMaHH.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            txtLoaiHH.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtLoaiHH2.Text= dataGridView1.Rows[index].Cells[2].Value.ToString();
            txtTenHH.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            txtTenHH2.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            txtLoaiHH2.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();    
        }

        string them;
        private void btnThem_Click(object sender, EventArgs e)
       {
           try
           {
               SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-R128S04\SQLEXPRESS;Initial Catalog=QLCF2;Integrated Security=True");
               cn.Open();
               them = "INSERT INTO HANGHOA (MaHH,TenHH,LoaiHH)VALUES('" + txtMaHH.Text + "','" + txtTenHH.Text + "','" + txtLoaiHH.Text + "')"; 
               SqlCommand commandthem = new SqlCommand(them, cn);
               commandthem.ExecuteNonQuery();
               connect();
           }
           catch (SqlException ex)
           {
               MessageBox.Show(ex.Message);
           }
           
       }

        private void frmHangHoa_Load1(object sender, EventArgs e)
        {
            connect();
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
        private void dataGridView2_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentRow.Index;
            txtMaHH.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            txtLoaiHH.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtLoaiHH2.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            txtTenHH.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            txtTenHH2.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            txtLoaiHH2.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();  
        }
    }
}

