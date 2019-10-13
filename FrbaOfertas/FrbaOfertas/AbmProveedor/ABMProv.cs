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
        DataTable dt = new DataTable();

        public ABMProv()
        {
            InitializeComponent();
        }

        private void mostrarMas_Click(object sender, EventArgs e)
        {
            if (groupBox1.Visible == false)
                groupBox1.Visible = true;
            else groupBox1.Visible = false;
        }

        private void ABMProv_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BaseDeDatos bd = new BaseDeDatos();
            try
            {
            }
            catch (Exception ex)
            {
                Conexiones.CerrarConexion();
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt.Columns.Clear();
            dt.Rows.Clear();
            dataGridView1.DataSource = dt;
            SqlConnection conexion = Conexiones.AbrirConexion();
            char verInhabilitados = mostrarInhabilitados.Checked ? '1' : '0';
            char verHabilitados = mostrarHabilitados.Checked ? '1' : '0';
            SqlCommand command = new SqlCommand("SELECT * FROM NUNCA_INJOIN.VerProveedores(" + verHabilitados + "," + verInhabilitados + ")", conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            Conexiones.CerrarConexion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModProv ventanaModificacion = new ModProv();
            ventanaModificacion.Show();
        }
    }
}
