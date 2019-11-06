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
            {
                using (ModProv ventanaModificacion = new ModProv(null, null))
                {
                    if (ventanaModificacion.ShowDialog() == DialogResult.OK)
                    {
                        generarBusqueda();
                    }
                }
            }
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
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            String bl = Convert.ToString(selectedRow.Cells["Inhabilitado"].Value);
            String id = Convert.ToString(selectedRow.Cells["ID"].Value.ToString());
            String razonSocial = Convert.ToString(selectedRow.Cells["Razon Social"].Value.ToString());

            String texto = bl == "N" ? "inhabilitar" : "habilitar";
            if (MessageBox.Show("¿Desea " + texto + " a " + razonSocial + " ?", texto + " proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String nueva_bl = bl == "S" ? "N" : "S";
                String query = " UPDATE NUNCA_INJOIN.Proveedor " +
                        " SET baja_logica = '" + nueva_bl + "'" +
                        " WHERE proveedor_id LIKE '" + id + "'";
                ejecutarQuery(query);
                generarBusqueda();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
