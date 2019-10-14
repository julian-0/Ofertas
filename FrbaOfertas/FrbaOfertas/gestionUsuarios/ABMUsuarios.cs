using FrbaOfertas.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.Datos;

namespace FrbaOfertas.gestionUsuarios
{
    public partial class ABMUsuarios : Form
    {
        DataTable dt = new DataTable();

        public ABMUsuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreacionUsuario ventanaCreacion = new CreacionUsuario(this, null, InfoUsuario.rolUsuario == 1);
            ventanaCreacion.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt.Columns.Clear();
            dt.Rows.Clear();
            dataGridView1.DataSource = dt;
            SqlConnection conexion = Conexiones.AbrirConexion();
            char verInhabilitados = mostrarInhabilitados.Checked ? '1' : '0';
            char verHabilitados = mostrarHabilitados.Checked ? '1' : '0';
            SqlCommand command = new SqlCommand("SELECT * FROM NUNCA_INJOIN.VerUsuarios(" + verHabilitados + "," + verInhabilitados + ", '"+ usuario.Text +"', '" + rol.Text + "' )", conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            Conexiones.CerrarConexion();
        }

        private void ABMUsuarios_Load(object sender, EventArgs e)
        {
            SqlConnection conexion = Conexiones.AbrirConexion();
            SqlCommand command = new SqlCommand("SELECT nombre_rol FROM NUNCA_INJOIN.Rol WHERE baja_logica = 'N'", conexion);
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                rol.Items.Add(dataReader[0]);
            }

            Conexiones.CerrarConexion();

        }
    }
}
