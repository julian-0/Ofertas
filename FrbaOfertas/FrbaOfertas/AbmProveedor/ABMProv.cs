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
        private bool buscarWasClicked = false;

        public ABMProv()
        {
            InitializeComponent();
            this.updateHeadersStyle();
        }

        //Hay un bug que resetea la fuente de ColumnHeadersDefaultCellStyle con cada build
        private void updateHeadersStyle()
        {
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 9.75F, FontStyle.Bold);
        }
        private void mostrarMas_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = !groupBox1.Visible;
        }

        private void ABMProv_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD2C2019DataSet.Rubro' table. You can move, or remove it, as needed.
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
            DataTable dt = new DataTable();
            buscarWasClicked = true;

            dataGridView1.DataSource = dt;
            SqlConnection conexion = Conexiones.AbrirConexion();
            char verInhabilitados = mostrarInhabilitados.Checked ? '1' : '0';
            char verHabilitados = mostrarHabilitados.Checked ? '1' : '0';
            SqlCommand command = new SqlCommand("SELECT * FROM NUNCA_INJOIN.VerProveedores(" + verHabilitados + "," + verInhabilitados + 
                ", '" + razonSocial.Text + 
                "', '" + usuario.Text +
                "', '" + rubro.Text +
                "', '" + email.Text +
                "', '" + localidad.Text +
                "', '" + nombre_de_contacto.Text +
                "', '" + ciudad.Text +
                "' )", conexion);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
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
    }
}
