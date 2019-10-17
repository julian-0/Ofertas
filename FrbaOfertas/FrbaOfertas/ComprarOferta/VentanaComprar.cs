using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FrbaOfertas.Conexion;

namespace FrbaOfertas.ComprarOferta
{
    public partial class VentanaComprar : Form
    {
        public DateTime fechaConfig = DateTime.Parse(System.Configuration.ConfigurationSettings.AppSettings["fechaConfig"]);
        public string ofertaSeleccionada;
        string user;


        public VentanaComprar(string usuario)
        {
            user = usuario;
            InitializeComponent();
        }

        private void ComprarOferta_Load(object sender, EventArgs e)
        {
            btnComprar.Enabled = false;
            cargarOfertas();
        }

        private void cargarOfertas()
        {
            string fecha = fechaConfig.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string consulta = "SELECT * FROM NUNCA_INJOIN.OfertasActivas('"+fecha+"')";

            DataTable dt = new DataTable();
            SqlConnection conexion = Conexiones.AbrirConexion();
            SqlCommand command = new SqlCommand(consulta, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            tablaOfertas.DataSource = dt;
            Conexiones.CerrarConexion();
        }

        private void tablaOfertas_SelectionChanged(object sender, EventArgs e)
        {
            btnComprar.Enabled = true;

            foreach (DataGridViewRow row in tablaOfertas.SelectedRows)
            {
                ofertaSeleccionada = row.Cells["oferta_codigo"].Value.ToString();
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            SqlCommand procedure = new SqlCommand();
            procedure.Connection = Conexiones.AbrirConexion();
            procedure.Parameters.Clear();

            procedure.CommandText = "NUNCA_INJOIN.comprarOferta";
            procedure.CommandType = CommandType.StoredProcedure;
           
            procedure.Parameters.Add("@usuario_id", SqlDbType.NVarChar).Value = user;
            procedure.Parameters.Add("@oferta_codigo", SqlDbType.NVarChar).Value = ofertaSeleccionada;
            procedure.Parameters.Add("@cantidad", SqlDbType.Int).Value = cantidad.Value;
            procedure.Parameters.Add("@fecha", SqlDbType.DateTime).Value = fechaConfig;
            
            try
            {
                procedure.ExecuteNonQuery();
                this.cargarOfertas();
                MessageBox.Show("Compra realizada exitosamente", "FrbaOfertas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FrbaOfertas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Conexiones.CerrarConexion();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
