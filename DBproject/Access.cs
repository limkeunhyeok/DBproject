using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Session;

namespace DBproject
{
    public partial class Access : Form
    {
        Connection c;
        Member m;
        public Access()
        {
            InitializeComponent();
            c = new Connection();
            txtPW.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Access_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration 회원가입 = new Registration();
            회원가입.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Find 찾기 = new Find();
            찾기.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main 메인 = new Main();
            AdForm 관리자창 = new AdForm();
            m = new Member();
            m.Id = txtID.Text;
            if(txtPW.Text.ToString() == c.Login(m))
            {
                if(txtID.Text == "Ad" && txtPW.Text == "123")
                {
                    관리자창.Show();
                }
                else
                {
                    메인.Show();
                    MessageBox.Show("환영합니다!");
                }
            }
            else
            {
                MessageBox.Show("로그인 실패");
            }
        }
    }
}
