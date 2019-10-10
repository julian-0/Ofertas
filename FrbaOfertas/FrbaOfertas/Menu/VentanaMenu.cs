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
using System.Data;
using FrbaOfertas.Conexion;

namespace FrbaOfertas.Menu
{
    public partial class VentanaMenu : Form
    {
        private String id_usuario;
        private c_Conexion conexion = new c_Conexion();

        public VentanaMenu(String usuario)
        {
            id_usuario = usuario;

            InitializeComponent();
        }

        private void VentanaMenu_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cargarGrilla()
        {
            DataTable tabla = new DataTable();
            SqlCommand procedure = new SqlCommand();
            procedure.Connection = conexion.AbrirConexion();
            procedure.Parameters.Clear();

            procedure.CommandText = "sp_obtenerFuncionalidades";
            procedure.CommandType = CommandType.StoredProcedure;
            procedure.Parameters.AddWithValue("@id_ingresado", SqlDbType.NVarChar).Value = id_usuario;
            procedure.Parameters.Add("@retorno", SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
            SqlDataReader sqlr = procedure.ExecuteReader();
            tabla.Load(sqlr);
            conexion.CerrarConexion();

            funcionalidadesGrid.DataSource = tabla;
        }
    }
}
