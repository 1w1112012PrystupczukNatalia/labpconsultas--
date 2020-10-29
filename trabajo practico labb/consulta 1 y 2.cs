using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo_practico_labb
{
    class Pedidos
    {
        int fecha_emision;

        public Pedidos()
        { }
        public int pFecha_emision
        {
            set { fecha_emision= value; }
            get { return fecha_emision; }
        }
    }


}
