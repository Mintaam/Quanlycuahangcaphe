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
            SqlConnection ketnoi = new SqlConnection(@"Data Source=DESKTOP-R128S04\SQLEXPRESS;Initial Catalog=QLCF2;Integrated Security=True");
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {

        }


    }
}
