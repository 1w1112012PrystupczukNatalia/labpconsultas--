using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo_practico_labb
{
    class Productos
    {
        int stock;

        public Productos()
        { }
        public int pStock 
        {
            set { stock = value; }
            get { return stock; }
        }
    }
}
