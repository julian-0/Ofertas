using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.Menu;
using System.Data.SqlClient;
using FrbaOfertas.Conexion;

namespace FrbaOfertas.AbmCliente
{
    public partial class GestionarClientes : Form
    {
        DataTable dt = new DataTable();
        public List<string> datosFilaCliente = new List<string>();
        private bool buscarWasClicked = false;

        private VentanaMenu menu;

        public GestionarClientes(VentanaMenu m)
        {
            this.menu = m;
            InitializeComponent();
        }

        private void GestionarClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu.Show();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            new AltaCliente().Show();
        }

        private void GestionarClientes_Load(object sender, EventArgs e)
        {
            groupMasFiltros.Visible = false;
        }

        private void mostrarMas_Click(object sender, EventArgs e)
        {
            groupMasFiltros.Visible = !groupMasFiltros.Visible;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarWasClicked = true;
            dt.Columns.Clear();
            dt.Rows.Clear();
            dataGridView1.DataSource = dt;
            SqlConnection conexion = Conexiones.AbrirConexion();
            char verInhabilitados = mostrarInhabilitados.Checked ? '1' : '0';
            char verHabilitados = mostrarHabilitados.Checked ? '1' : '0';
            SqlCommand command = new SqlCommand("SELECT * FROM NUNCA_INJOIN.VerClientes(" + verHabilitados + "," + verInhabilitados + ")", conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            Conexiones.CerrarConexion();
        }
    }
}
