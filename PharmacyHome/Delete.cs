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
    public partial class Delete : Form
    {

        private Pharmacy pharmacy;
        public Delete(Pharmacy p)
        {
            InitializeComponent();
            pharmacy = p;
            comboDeleteMedicine.DataSource =pharmacy.GetMedicines();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
          int id=int.Parse(comboDeleteMedicine.SelectedValue.ToString().Substring(0,2).Trim());
            pharmacy.DeleteMedicine(id);
          
            comboDeleteMedicine.DataSource = null;
            comboDeleteMedicine.DataSource = pharmacy.GetMedicines();
        }

        
    }
}
