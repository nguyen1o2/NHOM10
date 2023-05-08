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
namespace Quản_Lý_Sinh_Viên
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var db = new Database();
            //dgvData.DataSource = db.SelectData();
            //dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //form main này sau này sez dùng để hiển thị điểm sinh viên
            //nên tạm thời không động đến form này
            //cho tới khi code xng các phần khác
            //dgvData.DataSource = db.SelectData(null);
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
