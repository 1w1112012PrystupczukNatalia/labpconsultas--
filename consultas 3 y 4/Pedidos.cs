using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consultas_3_y_4
{
    class Pedidos
    {
      
           DateTime fecha_emision;

            public Pedidos()
            { }
            public DateTime pFecha_emision
            {
                set { fecha_emision = value; }
                get { return fecha_emision; }
            }
        
   }
}
