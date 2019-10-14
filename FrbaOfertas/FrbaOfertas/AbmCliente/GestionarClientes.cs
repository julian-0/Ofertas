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
            DataTable dt = new DataTable();
            tablaClientes.DataSource = dt;
            SqlConnection conexion = Conexiones.AbrirConexion();
            char verInhabilitados = mostrarInhabilitados.Checked ? '1' : '0';
            char verHabilitados = mostrarHabilitados.Checked ? '1' : '0';

            SqlCommand command = new SqlCommand("SELECT * FROM NUNCA_INJOIN.VerClientes(" + 
                                                verHabilitados + 
                                                "," + verInhabilitados + 
                                                ", '" + txtNombre.Text + 
                                                "', '" + txtApellido.Text +
                                                "', '" + txtMail.Text +
                                                "', '" + txtCiudad.Text +
                                                "', '" + txtLocalidad.Text +
                                                "' )", conexion);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            
            DataView dv = new DataView(dt);
            string filter = "";
            if(txtDni.Text != "") {
                filter += "DNI =" + txtDni.Text;
            }
            if(txtTelefono.Text != "") {
                if (filter != "") filter += " AND ";
                filter += "Telefono =" + txtTelefono.Text;
            }
            if (txtCodP.Text != "") {
                if (filter != "") filter += " AND ";
                filter += "Codigo_Postal = '" + txtCodP.Text + "'";
            }

            dv.RowFilter = filter;
            tablaClientes.DataSource = dv;
            Conexiones.CerrarConexion();
        }

        private void tablaClientes_SelectionChanged(object sender, EventArgs e)
        {
            datosFilaCliente.Clear();
            foreach (DataGridViewRow row in tablaClientes.SelectedRows)
            {
                for (int i = 0; i < 11; i++)
                {
                    datosFilaCliente.Add(row.Cells[i].Value.ToString());
                }
                datosFilaCliente.Add(row.Cells["ID"].Value.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (buscarWasClicked)
            {
                AltaCliente ventanaModificacion = new AltaCliente(null, datosFilaCliente);
                ventanaModificacion.Show();
            }
            else MessageBox.Show("Seleccione un cliente");
        }
    }
}
