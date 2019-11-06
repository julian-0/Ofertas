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
using FrbaOfertas.Datos;
using System.Reflection;

namespace FrbaOfertas.AbmCliente
{
    public partial class GestionarClientes : Form
    {
        public Dictionary<string, string> datosFilaCliente = new Dictionary<string, string>();

        private bool buscarWasClicked = false;

        private VentanaMenu menu;

        public GestionarClientes(VentanaMenu m)
        {
            this.menu = m;
            InitializeComponent();
            updateHeadersStyle();
            aumentarVelocidad();
            buscar();
        }

        private void aumentarVelocidad()
        {
            tablaClientes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tablaClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            tablaClientes.AutoSize = false;
            Type dgvType = tablaClientes.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(tablaClientes, null);
        }

        private void updateHeadersStyle()
        {
            this.tablaClientes.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 9.75F, FontStyle.Bold);
        }

        public GestionarClientes()//es para la seleccion de un cliente en comprarOferta
        {
            InitializeComponent();
            this.btnModificar.Hide();
            this.btnEliminar.Hide();
            this.btnAlta.Hide();
            this.btnSeleccion.Show();
            updateHeadersStyle();
            aumentarVelocidad();
            buscar();
        }

        private void GestionarClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            InfoUsuario.Actualizar();
            if(menu!=null)
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

        private void buscar()
        {
            Cursor = Cursors.WaitCursor;
            foreach (DataGridViewColumn c in tablaClientes.Columns)
            {
                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }

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
                                                "', '" + apellido.Text +
                                                "', '" + txtMail.Text +
                                                "', '" + txtCiudad.Text +
                                                "', '" + txtLocalidad.Text +
                                                "', '" + BaseDeDatos.fechaConfigString +
                                                "' )", conexion);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);

            DataView dv = new DataView(dt);
            string filter = "";
            if (txtDni.Text != "")
            {
                filter += "DNI =" + txtDni.Text;
            }
            if (txtTelefono.Text != "")
            {
                if (filter != "") filter += " AND ";
                filter += "Telefono =" + txtTelefono.Text;
            }
            if (txtCodP.Text != "")
            {
                if (filter != "") filter += " AND ";
                filter += "Codigo_Postal = '" + txtCodP.Text + "'";
            }

            dv.RowFilter = filter;
            tablaClientes.DataSource = dv;
            Conexiones.CerrarConexion();
            Cursor = Cursors.Default;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void tablaClientes_SelectionChanged(object sender, EventArgs e)
        {
            datosFilaCliente.Clear();
            foreach (DataGridViewRow row in tablaClientes.SelectedRows)
            {
                for (int i = 0; i < tablaClientes.ColumnCount; i++)
                {
                    datosFilaCliente.Add(tablaClientes.Columns[i].Name, row.Cells[i].Value.ToString());
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (buscarWasClicked)
            {
                using (AltaCliente ventanaModificacion = new AltaCliente(null, datosFilaCliente))
                {
                    if (ventanaModificacion.ShowDialog() == DialogResult.OK)
                    {
                        buscar();
                    }
                }
            }
            else MessageBox.Show("Seleccione un cliente");
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int selectedrowindex = tablaClientes.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = tablaClientes.Rows[selectedrowindex];
            String bl = Convert.ToString(selectedRow.Cells["Inhabilitado"].Value);
            String id = Convert.ToString(selectedRow.Cells["ID"].Value.ToString());
            String nombre = Convert.ToString(selectedRow.Cells["Nombre"].Value.ToString());
            String apellido = Convert.ToString(selectedRow.Cells["Apellido"].Value.ToString());

            String texto = bl == "N" ? "inhabilitar" : "habilitar";
            if (MessageBox.Show("¿Desea " + texto + " a " + nombre + " " + apellido + " ?", texto + " proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String nueva_bl = bl == "S" ? "N" : "S";
                String query = " UPDATE NUNCA_INJOIN.Cliente " +
                        " SET baja_logica = '" + nueva_bl + "'" +
                        " WHERE cliente_id LIKE '" + id + "'";
                ejecutarQuery(query);
                buscar();
            }
            else
            {
                MessageBox.Show("No se guardaron los cambios.");
            }
        }

        private void ejecutarQuery(String query)
        {
            SqlConnection conexion = Conexiones.AbrirConexion();
            SqlCommand consulta = new SqlCommand(query, conexion);
            consulta.ExecuteNonQuery();
            Conexiones.CerrarConexion();
        }
    }
}
