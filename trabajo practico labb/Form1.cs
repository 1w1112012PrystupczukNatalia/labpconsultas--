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
    public partial class Form1 : Form
    {
        SqlConnection conexion = new SqlConnection();
        SqlCommand comando = new SqlCommand();


        public Form1()
        {
            InitializeComponent();
        }

        private void dtGrilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void conectarBD()
        {
            conexion.ConnectionString = @"Data Source=138.99.7.66,1433;Initial Catalog=TUP_PII_2020;User ID=tup_2020;Password=tup2020_!@NH";
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public void CargarGrilla()
        {
            Pedidos pe = new Pedidos();
            pe.pFecha_emision = Convert.ToInt32(txtAño.Text);

            SqlCommand comando = new SqlCommand("exec sp_consulta1 " +
                                                "@fecha_emision =" + pe.pFecha_emision, conexion);
                                               
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dtGrilla.DataSource = tabla;



        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CargarGrilla(); 
        }
    }
}