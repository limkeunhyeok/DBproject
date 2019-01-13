using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBproject
{
    public partial class AdForm : Form
    {
        public AdForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            management1 회원관리 = new management1();
            회원관리.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            management2 메뉴관리 = new management2();
            메뉴관리.Show();
        }
    }
}
