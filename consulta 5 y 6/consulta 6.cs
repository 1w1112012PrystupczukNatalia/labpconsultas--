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


namespace consulta_5_y_6
{
    public partial class consulta_6 : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-68QJC3A;Initial Catalog=LAB_PROG_II_VERSION_2;Integrated Security=True");
        SqlCommand comando = new SqlCommand();
        public consulta_6()
        {
            InitializeComponent();
        }

        private void consulta_6_Load(object sender, EventArgs e)
        {
            cargarTipo();

        }
        private void conectar()
        {
            conexion.ConnectionString = @"Data Source=DESKTOP-68QJC3A;Initial Catalog=LAB_PROG_II_VERSION_2;Integrated Security=True";
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }

        private void cargarTipo()
        {
            DataTable tabla = new DataTable();
            conectar();
            comando.CommandText = "SELECT * FROM Tipos_productos";
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            cboTipo.DataSource = tabla;
            cboTipo.DisplayMember = tabla.Columns[1].ColumnName;

        }
        private void cargarGrilla()
        {
            Productos6 prod = new Productos6 ();
            prod.pFecha = Convert.ToInt32(txtAño.Text);
            prod.pTipo = cboTipo.SelectedIndex + 1;
            prod.pCantidad = Convert.ToInt32(txtCantidad);

            SqlCommand comando = new SqlCommand("exec sp_consulta5 " +
                                                "@fecha =" + prod.pFecha + " , " +
                                                "@tipo = " + prod.pTipo + " , " +
                                                "@Cantidad = " + prod.pCantidad, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dtGrid6.DataSource = tabla;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cargarGrilla();
        }
    }
}