using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Session;

namespace DBproject
{
    public partial class management2 : Form
    {
        Connection c;

        public management2()
        {
            InitializeComponent();
            c = new Connection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM dbo.MenuInfo";
            DataTable dt = c.GetDBTable(sql);
            dataGridView1.DataSource = dt;
        }
    }
}
