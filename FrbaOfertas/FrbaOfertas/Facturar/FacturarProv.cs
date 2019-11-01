using FrbaOfertas.Conexion;
using FrbaOfertas.CrearOferta;
using FrbaOfertas.Datos;
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

namespace FrbaOfertas.Facturar
{
    public partial class FacturarProv : Form
    {
        private bool haySeleccionado = false;
        public Dictionary<string, string> datosProveedorSeleccionado = new Dictionary<string, string>();
        public DateTime fechaConfig{
            get { return DateTime.Parse(System.Configuration.ConfigurationSettings.AppSettings["fechaConfig"]); }
        }
        
        public FacturarProv()
        {
            InitializeComponent();
            fechaHasta.MaxDate = fechaConfig; 
        }

        public bool camposCompletos()
        {
            return haySeleccionado;
        }

        private void buttonSeleccionarProveedor_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            using (SeleccionProveedor ventanaCreacion = new SeleccionProveedor())
            {
                if (ventanaCreacion.ShowDialog() == DialogResult.OK)
                {
                    this.datosProveedorSeleccionado = ventanaCreacion.datosProveedor;
                    textBoxProveedor.Text = datosProveedorSeleccionado["razon_social"].ToString();
                    haySeleccionado = true;
                }
            }
            Cursor = Cursors.Default;
        }

        private void rellenarDataGrid()
        {
            if (camposCompletos())
            {
                DataTable dt;
                dt = BaseDeDatos.getOfertasProveedor(fechaDesde.Text.ToString(), fechaHasta.Text.ToString(), datosProveedorSeleccionado["proveedor_id"].ToString());
                dataGridView1.DataSource = dt;
            }
            completarTotal();
        }

        private void fechaDesde_TabIndexChanged(object sender, EventArgs e){}

        private void fechaHasta_TabIndexChanged(object sender, EventArgs e) {}

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            rellenarDataGrid();
            Cursor = Cursors.Default;
        }

        private void completarTotal()
        {
            float total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Total"].Value != null && row.Cells["Total"].Value.ToString() != "")
                {
                    float parcial = 0;
                    float.TryParse(row.Cells["Total"].Value.ToString(), out parcial);
                    total += parcial;
                }
            }
            textBox1.Text = "$" + total.ToString();
        }

        private void buttonFacturar_Click(object sender, EventArgs e)
        {

            if (camposCompletos())
            {
                rellenarDataGrid();
                var lines = datosProveedorSeleccionado.Select(kvp => kvp.Key + ": " + kvp.Value.ToString());

                if (MessageBox.Show("¿Generar factura?\nProveedor:\n" + string.Join(Environment.NewLine, lines) + "\nImporte: " + textBox1.Text, "Generar factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection conexion = Conexiones.AbrirConexion();
                    SqlCommand procedure = new SqlCommand("NUNCA_INJOIN.armarFactura", conexion);
                    procedure.CommandType = CommandType.StoredProcedure;
                    float total = 0;
                    float.TryParse(textBox1.Text.Trim('$'), out total);
                    procedure.Parameters.AddWithValue("@proveedor_id", SqlDbType.NVarChar).Value = datosProveedorSeleccionado["proveedor_id"];
                    procedure.Parameters.AddWithValue("@importe", SqlDbType.Int).Value = total;
                    procedure.Parameters.AddWithValue("@fechaFactura", SqlDbType.DateTime).Value = fechaConfig;
                    procedure.Parameters.AddWithValue("@fechaDesde", SqlDbType.DateTime).Value = fechaDesde.Value;
                    procedure.Parameters.AddWithValue("@fechaHasta", SqlDbType.DateTime).Value = fechaHasta.Value;
                    procedure.Parameters.Add("@factura_numero", SqlDbType.Int).Direction = ParameterDirection.Output;

                    procedure.ExecuteNonQuery();
                    Conexiones.CerrarConexion();

                    int retorno = (int)procedure.Parameters["@factura_numero"].Value;
                    textBox2.Text = retorno.ToString();
                    MessageBox.Show("Se generó la factura N° " + retorno.ToString());
                }
                else
                {
                    MessageBox.Show("Factura cancelada.");
                }
                
            }
        }

        private void buttonInformacionProveedor_Click(object sender, EventArgs e)
        {
            var lines = datosProveedorSeleccionado.Select(kvp => kvp.Key + ": " + kvp.Value.ToString());
            MessageBox.Show(string.Join(Environment.NewLine, lines));
        }

        private void FacturarProv_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
