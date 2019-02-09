using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esperoque_no_te_borres.Modelo
{
    class Mesa
    {
        public int id { get; set; }
        public int zona { get; set; }
        public int n_sillas { get; set; }

        public Mesa() { }

        public Mesa(int id, int zona, int n_sillas)
        {
            this.id = id;
            this.zona = zona;
            this.n_sillas = n_sillas;
        }
    }
}
