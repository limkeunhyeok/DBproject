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
    public partial class Find : Form
    {
        Connection c;
        Member m;

        public Find()
        {
            InitializeComponent();
            c = new Connection();
        }

        private void IDFindBtn_Click(object sender, EventArgs e)
        {
            m = new Member();
            m.Name = FindtxtName.Text;
            m.Personal_no = FindtxtPersonal_no.Text;
            MessageBox.Show(c.IDFind(m));
        }

        private void PWFindBtn_Click(object sender, EventArgs e)
        {
            m = new Member();
            m.Id = FindtxtID.Text;
            m.Question = FindtxtQuestion.SelectedText;
            m.Answer = FindtxtAnswer.Text;
            MessageBox.Show(c.PWFind(m));
        }
    }
}
