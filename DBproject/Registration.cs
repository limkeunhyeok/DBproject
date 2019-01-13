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
using Domain;
using Session;

namespace DBproject
{
    public partial class Registration : Form
    {
        Connection c;
        Member m;
        
        public Registration()
        {
            InitializeComponent();
            c = new Connection();
            txtPW.PasswordChar = '*';
            textBox3.PasswordChar = '*';
            txtPersonal_no2.PasswordChar = '*';    
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            m = new Member();
            m.Id = txtID.Text;
            m.Pw = txtPW.Text;
            m.Name = txtName.Text;
            m.Personal_no = txtPersonal_no1.Text + '-' + txtPersonal_no2.Text;
            m.Address = txtAddress.Text;
            m.Email = txtEmail1.Text + '@' + txtEmail2;
            m.Question = txtQuestion.Text;
            m.Answer = txtAnswer.Text;
            if (man.Checked)
            {
                m.Sex = "남";
            }
            if (woman.Checked)
            {
                m.Sex = "여";
            }
            
            if (txtPW.Text == textBox3.Text)
            {
                c.Insert(m);
                MessageBox.Show("가입완료");
                this.Close();
            }
            else
            {
                MessageBox.Show("암호불일치");
            }
        }

        private void txtQuestion_TextChanged(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            m = new Member();
            m.Id = txtID.Text;
            bool res = c.Search(m);
            if (res)
            {
                MessageBox.Show("중복");
            }
            if (!res)
            {
                MessageBox.Show("사용가능");
            }

        }
    }
}
