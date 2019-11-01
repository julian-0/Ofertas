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
            rellenarDatagrid();
        }

        //Hay un bug que resetea la fuente de ColumnHeadersDefaultCellStyle con cada build
        private void updateHeadersStyle()
        {
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 9.75F, FontStyle.Bold);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rellenarDatagrid()
        {
            Cursor = Cursors.WaitCursor;
            dt.Columns.Clear();
            dt.Rows.Clear();
            dataGridView1.DataSource = dt;
            SqlConnection conexion = Conexiones.AbrirConexion();
            SqlCommand command = new SqlCommand("SELECT [proveedor_id],[rubro_id],[usuario_id],[razon_social],"
                + "[mail],[telefono],[domicilio],[localidad],[ciudad],[codigo_postal],[cuit],[nombre_contacto],"
                                                        + "[baja_logica] FROM NUNCA_INJOIN.Proveedor", conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            Conexiones.CerrarConexion();
            Cursor = Cursors.Default;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            rellenarDatagrid();
           
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
                for (int i = 0; i < 10; i++)
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
