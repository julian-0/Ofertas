using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.Datos;
using FrbaOfertas.Conexion;
using System.Data.SqlClient;

namespace FrbaOfertas.AbmProveedor
{
    public partial class ABMProv : Form
    {
        public List<string> datosFilaProveedor = new List<string>();
        private bool buscarWasClicked = true;

        public ABMProv()
        {
            InitializeComponent();
            this.updateHeadersStyle();
            generarBusqueda();
        }

        //Hay un bug que resetea la fuente de ColumnHeadersDefaultCellStyle con cada build
        private void updateHeadersStyle()
        {
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 9.75F, FontStyle.Bold);
        }
        private void mostrarMas_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = !groupBox1.Visible;
            mostrarMas.Text = groupBox1.Visible ? "▲ Menos filtros" : "▼ Más filtros"; 
        }

        private void ABMProv_Load(object sender, EventArgs e)
        {
            SqlConnection conexion = Conexiones.AbrirConexion();
            SqlCommand command = new SqlCommand("SELECT nombre_rubro FROM NUNCA_INJOIN.Rubro", conexion);
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                rubro.Items.Add(dataReader[0]);
            }

            Conexiones.CerrarConexion();
            // TODO: This line of code loads data into the 'gD2C2019DataSet.Rubro' table. You can move, or remove it, as needed.
            groupBox1.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buscarWasClicked = true;
            generarBusqueda();
        }

        private void generarBusqueda()
        {
            DataTable dt = new DataTable();
            buscarWasClicked = true;

            dataGridView1.DataSource = dt;
            SqlConnection conexion = Conexiones.AbrirConexion();
            char verInhabilitados = mostrarInhabilitados.Checked ? '1' : '0';
            char verHabilitados = mostrarHabilitados.Checked ? '1' : '0';

            SqlCommand command = new SqlCommand("SELECT * FROM NUNCA_INJOIN.VerProveedores(" + verHabilitados + "," + verInhabilitados +
                ", '" + razonSocial.Text.ToString() +
                "', '" + usuario.Text.ToString() +
                "', '" + rubro.Text.ToString() +
                "', '" + email.Text.ToString() +
                "', '" + localidad.Text.ToString() +
                "', '" + nombre_de_contacto.Text.ToString() +
                "', '" + ciudad.Text.ToString() +
                "', '" + codigo_postal.Text.ToString() +
                "' )", conexion);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);

            DataView dv = new DataView(dt);
            string filter = "";
            if (cuit.Text != "")
            {
                filter += "CUIT = '" + cuit.Text + "'";
            }
            if (telefono.Text != "")
            {
                if (filter != "") filter += " AND ";
                filter += "Telefono =" + telefono.Text;
            }

            dv.RowFilter = filter;
            dataGridView1.DataSource = dv;
            Conexiones.CerrarConexion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModProv ventanaModificacion = new ModProv(null, null);
            ventanaModificacion.Show();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            datosFilaProveedor.Clear();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                for(int i = 0; i<11; i++){
                    datosFilaProveedor.Add(row.Cells[i].Value.ToString());
                }
                datosFilaProveedor.Add(row.Cells["ID"].Value.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (buscarWasClicked)
            {
                ModProv ventanaModificacion = new ModProv(null, datosFilaProveedor);
                ventanaModificacion.Show();
            }
            else MessageBox.Show("Seleccione un proveedor");
        }

        private void ABMProv_FormClosed(object sender, FormClosedEventArgs e)
        {
            InfoUsuario.Actualizar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //diccionario datosFilaProveedor??
            String texto = datosFilaProveedor[10] == "N" ? "inhabilitar" : "habilitar";
            if (MessageBox.Show("¿Desea " + texto + " a " + datosFilaProveedor[0] + " ?", texto + " proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BaseDeDatos.cambiarEstadoProveedor(datosFilaProveedor[11]);
            }
            else
            {
                MessageBox.Show("No se guardaron los cambios.");
            }
            
        }
    }
}
