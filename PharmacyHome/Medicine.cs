using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyHome
{
    public class Medicine
    {
        private static int _id = 0;

        public int ID { get; set; }
        public string Type { get; set; }



        public string Name { get; set; }
        public string Price { get; set; }
        public Medicine()
        {
            _id++;
            ID = _id;

        }
        public override string ToString()
        {
            return $"{ID}{Type}{Name}{Price}";
        }


    }
}
