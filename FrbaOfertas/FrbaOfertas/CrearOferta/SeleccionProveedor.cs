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

namespace FrbaOfertas.CrearOferta
{
    public partial class SeleccionProveedor : Form
    {

        DataTable dt = new DataTable();
        public Dictionary<string, string> datosProveedor = new Dictionary<string, string>();

        public SeleccionProveedor()
        {
            InitializeComponent();
            this.updateHeadersStyle();
            rellenarRoles();
            generarBusqueda();
        }

        public void rellenarRoles()
        {
            SqlConnection conexion = Conexiones.AbrirConexion();
            SqlCommand command = new SqlCommand("SELECT nombre_rubro FROM NUNCA_INJOIN.Rubro", conexion);
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                rubro.Items.Add(dataReader[0]);
            }

            Conexiones.CerrarConexion();
        }

        //Hay un bug que resetea la fuente de ColumnHeadersDefaultCellStyle con cada build
        private void updateHeadersStyle()
        {
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 9.75F, FontStyle.Bold);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void generarBusqueda()
        {
            Cursor = Cursors.WaitCursor;
            DataTable dt = new DataTable();

            dataGridView1.DataSource = dt;
            SqlConnection conexion = Conexiones.AbrirConexion();

            SqlCommand command = new SqlCommand("SELECT * FROM NUNCA_INJOIN.VerProveedores(1,0" +
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
            Cursor = Cursors.Default;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            generarBusqueda();
           
        }

        private void mostrarMas_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = !groupBox1.Visible;
        }

        private void SeleccionProveedor_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            datosProveedor.Clear();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                for (int i = 0; i < 12; i++)
                {
                    datosProveedor.Add(dataGridView1.Columns[i].Name, row.Cells[i].Value.ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                this.DialogResult = DialogResult.OK;
        }
    }
}
