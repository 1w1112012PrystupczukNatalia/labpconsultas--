using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Text;

namespace trabajo_practico_labb
{
    public partial class Consulta_2 : Form
    {
        SqlConnection conexion = new SqlConnection();
        SqlCommand comando = new SqlCommand();

        public Consulta_2()
        {
            InitializeComponent();
        }

        private void Consulta_2_Load(object sender, EventArgs e)
        {

        }
        private void conectarBD()
        {
            conexion.ConnectionString = @"Data Source=138.99.7.66,1433;Initial Catalog=TUP_PII_2020;User ID=tup_2020;Password=tup2020_!@NH";
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;

        }
        public void CargarGrilla()
        {
            Productos p = new Productos();
            p.pStock = Convert.ToInt32(txtStock.Text);

            SqlCommand comando = new SqlCommand("exec sp_consulta2 " +
                                                "@stock =" + p.pStock, conexion);

            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dtGrilla2.DataSource = tabla;



        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

    }
}
