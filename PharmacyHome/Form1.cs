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
    public partial class Form1 : Form

    {
        private Pharmacy _pharmacy;
        private DataGridView dgv;
        

        public Form1()
        {
            InitializeComponent();
            
            Pharmacy Zeferan = new Pharmacy("Zeferan");
            _pharmacy = Zeferan;
            dgvList.DataSource = _pharmacy.GetMedicines();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string type = txttype.Text.Trim();
            string name = txtname.Text.Trim();
            string price = txtPrice.Text.Trim();
            if (type == "" || name == "" || price == "")
            {
                MessageBox.Show("Hamisini doldur", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Medicine medicine = new Medicine { Type = type, Name = name, Price = price + "  Azn" };
            _pharmacy.AddMedicine(medicine);
            dgvList.DataSource = null;
            dgvList.DataSource = _pharmacy.GetMedicines();
            txttype.Text = "";

            txtname.Text = "";
            txtPrice.Text = "";


        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete(_pharmacy);
            delete.Show();

        }

       
    }
}
