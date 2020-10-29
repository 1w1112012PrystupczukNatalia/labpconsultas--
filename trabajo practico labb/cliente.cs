using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo_practico_labb
{
    class Clientes
    {
        string nombre;
        string apellido;
        int codigo;

        public Clientes()
        { }
        public string pNombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public string pApellido
        {
            set { apellido = value; }
            get { return apellido; }
        }
        public int pCodigo
        {
            set { codigo = value; }
            get { return codigo; }
        }

    }
}