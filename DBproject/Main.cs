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
using Domain;

namespace DBproject
{
    public partial class Main : Form
    {
        Connection c;
        Member m;

        public Main()
        {
            c = new Connection();
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox7.Text = (int.Parse(textBox1.Text) * 2000 + int.Parse(textBox2.Text) * 2000 + int.Parse(textBox3.Text) * 1500 + int.Parse(textBox6.Text) * 2500 + int.Parse(textBox5.Text) * 1000 + int.Parse(textBox4.Text) * 1000).ToString();
            DialogResult result1 = MessageBox.Show("주문하시겠습니까?", "주문", MessageBoxButtons.YesNo);
        }
    }
}
