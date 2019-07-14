using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyHome
{
    public class Pharmacy
    {

        private static int _id = 0;

        public int ID { get; set; }
        public string Name { get; set; }
        private List<Medicine> medicines;
        public Pharmacy(string name)
        {

            _id++;
            ID = _id;
            Name = name;
            medicines = new List<Medicine>()
            {
             new Medicine {Type=" Bash", Name=" Analgin",Price=" 445"},
             new Medicine {Type=" Bash" ,Name= " Anarrlgin",Price=" 33"},

            new Medicine {Type="  Bash", Name="Analrrrn",Price=" 45"},
            new Medicine { Type="  Bash",Name=" Analgiddn",Price=" 44445"}
            };
        }
        public List<Medicine> GetMedicines()
        {
            return medicines;
        }
        public void AddMedicine(Medicine m)
        {
            medicines.Add(m);
        }
        public void DeleteMedicine(int id)
        {
            for (int i = 0; i < medicines.Count; i++)
            {
                if (id==medicines[i].ID)
                {
                    medicines.RemoveAt(i);
                    return;
                }

            }

        }
        public Medicine GetMedicine (int id)
        {
            Medicine result = null;
            for (int i = 0; i < medicines.Count; i++)
            {
                if (id == medicines[i].ID)
                {
                    result = medicines[i];
                }
                

            }
            return result;


        }
    }
}
