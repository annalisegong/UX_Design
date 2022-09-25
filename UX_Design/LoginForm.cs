using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UX_Design
{
    public partial class LoginForm : Form
    {
        String username;
        String password;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            username = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password = textBox2.Text;
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            //HomePage hp = new HomePage();
            //hp.Show();
            CalcForm c = new CalcForm();
            c.Show();
        }
    }
}