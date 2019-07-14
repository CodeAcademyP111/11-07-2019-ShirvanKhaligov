using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyHome
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ownbutton1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "admin" || txtPassword.Text != "1234")
            {
                MessageBox.Show("Username or Password is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            Form1 form = new Form1();
            form.Show();
        }
       

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

       
    }
}
