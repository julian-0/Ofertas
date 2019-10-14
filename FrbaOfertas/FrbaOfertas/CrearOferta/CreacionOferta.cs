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
using System.Diagnostics;
namespace FrbaOfertas.CrearOferta
{
    public partial class CreacionOferta : Form
    {
        public List<string> datosProveedorSeleccionado = new List<string>();
        public DateTime fechaConfig = DateTime.Parse(System.Configuration.ConfigurationSettings.AppSettings["fechaConfig"]);

        public CreacionOferta()
        {
            InitializeComponent();
            if (InfoUsuario.rolUsuario > 2)
            {
                buttonSeleccionarProveedor.Hide();
                textBoxProveedor.ReadOnly = true;
                textBoxProveedor.Text = InfoUsuario.nombreUsuario;
            }
            fechaDesde.MinDate = fechaConfig;
            fechaHasta.MinDate = fechaConfig;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void buttonSeleccionarProveedor_Click(object sender, EventArgs e)
        {
            
            using (SeleccionProveedor ventanaCreacion = new SeleccionProveedor())
            {
                if (ventanaCreacion.ShowDialog() == DialogResult.OK)
                {
                    this.datosProveedorSeleccionado = ventanaCreacion.datosFilaProveedor;
                    textBoxProveedor.Text = datosProveedorSeleccionado[5].ToString();
                    textBoxProveedor.ReadOnly = true;
                }
            }
        }


        private bool CamposCompletos()
        {
            return textBoxProveedor.Text != "" && textBoxDescripcion.Text != "" && fechaDesde.Text != ""
                && fechaHasta.Text != "";
        }

        private void validarFechas()
        {
            DateTime desde = this.fechaDesde.Value.Date;
            DateTime hasta = this.fechaHasta.Value.Date;
            if (desde.CompareTo(fechaConfig) < 0 || hasta.CompareTo(fechaConfig) < 0)
            {
                throw new ArgumentException("La publicación no puede tener una fecha anterior a la fecha del sistema");
            }
        }

        private void buttonCrearOferta_Click(object sender, EventArgs e)
        {
            SqlConnection conex = Conexiones.AbrirConexion();
            try
            {
                String ts = Stopwatch.GetTimestamp().ToString();
                this.validarFechas();
                if (this.CamposCompletos())
                {
                    SqlCommand procedure = new SqlCommand("[NUNCA_INJOIN].CrearOferta", conex);
                    procedure.CommandType = CommandType.StoredProcedure;
                    procedure.Parameters.Add("@oferta_codigo", SqlDbType.NVarChar).Value = ts;
                    procedure.Parameters.Add("@usuario_id", SqlDbType.NVarChar).Value = textBoxProveedor.Text;
                    procedure.Parameters.Add("@descripcion", SqlDbType.NVarChar).Value = textBoxDescripcion.Text;
                    procedure.Parameters.Add("@fecha_publicacion", SqlDbType.NVarChar).Value = fechaDesde.Text.ToString();
                    procedure.Parameters.Add("@fecha_vencimiento", SqlDbType.NVarChar).Value = fechaHasta.Text.ToString();
                    procedure.Parameters.Add("@precio_oferta", SqlDbType.Int).Value = Convert.ToInt32(Math.Round(numericPrecioOferta.Value, 0));
                    procedure.Parameters.Add("@precio_lista", SqlDbType.Int).Value = Convert.ToInt32(Math.Round(numericPrecioOriginal.Value, 0));
                    procedure.Parameters.Add("@cantidad_disponible", SqlDbType.Int).Value = Convert.ToInt32(Math.Round(numericStock.Value, 0));
                    procedure.Parameters.Add("@cantidad_maxima_usuario", SqlDbType.Int).Value = Convert.ToInt32(Math.Round(numericMaxUsuario.Value, 0));
                    procedure.Parameters.Add("@plazo_entrega_dias", SqlDbType.Int).Value = Convert.ToInt32(Math.Round(numericPlazo.Value, 0));
                    procedure.ExecuteNonQuery();
                    Conexiones.CerrarConexion();
                    MessageBox.Show("Oferta creada correctamente", "FrbaOfertas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Complete todos los campos para seguir", "FrbaOfertas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException exeption)
            {
                MessageBox.Show("La publicación debe tener fecha mayor o igual a la fecha actual del sistema");
            }
        }

        private void buttonInformacionProveedor_Click(object sender, EventArgs e)
        {
            String datos = "";
            foreach (String dato in datosProveedorSeleccionado)
                datos = datos + dato;
            MessageBox.Show(datos);
        }

        private void fechaDesde_ValueChanged(object sender, EventArgs e)
        {
            fechaHasta.MinDate = fechaDesde.Value;
        }

        private void fechaHasta_ValueChanged(object sender, EventArgs e)
        {
            fechaDesde.MaxDate = fechaHasta.Value;
        }
    }
}
