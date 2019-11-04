using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.Conexion;
using System.Data.SqlClient;
using FrbaOfertas.Clases;
using FrbaOfertas.AbmCliente;
using FrbaOfertas.Datos;

namespace FrbaOfertas.EntregarOferta
{
    public partial class EntregaOferta : Form
    {

        public Dictionary<string, string> datosClienteSeleccionado = new Dictionary<string, string>();
        public Dictionary<string, string> datosCupon = new Dictionary<string, string>();

        public bool haySeleccionado = false;
        public bool hayCupon = false;

        public EntregaOferta()
        {
            InitializeComponent();
        }

        private void labelUsuario_Click(object sender, EventArgs e)
        {

        }

        private void cliente_leave(object sender, EventArgs e) 
        {        }

        private void cupon_leave(object sender, EventArgs e)
        {
        }

        private void verificarCampos()
        {
            if (cupon.Text == "" || cliente.Text == "")
            {
                throw new ArgumentException("Complete los campos");
            }
            else if (!BaseDeDatos.existeCliente(Convert.ToInt32(cliente.Text)))
            {
                throw new ArgumentException("No existe el cliente solicidato");
            }
            else if (!BaseDeDatos.existeCupon(Convert.ToInt32(cliente.Text)))
            {
                throw new ArgumentException("No existe el cupon solicidato");
            }
        }

        private void buttonConsumirCupon_Click(object sender, EventArgs e)
        {
            try
            {
                verificarCampos();
                SqlCommand procedure = new SqlCommand();
                procedure.Connection = Conexiones.AbrirConexion();
                procedure.Parameters.Clear();

                procedure.CommandText = "NUNCA_INJOIN.consumirOferta";
                procedure.CommandType = CommandType.StoredProcedure;

                procedure.Parameters.Add("@cupon_id", SqlDbType.Decimal).Value = Convert.ToInt32(cupon.Text);
                procedure.Parameters.Add("@cliente_entrega_id", SqlDbType.Decimal).Value = Convert.ToInt32(cliente.Text);
                procedure.Parameters.Add("@fecha", SqlDbType.NVarChar).Value = System.Configuration.ConfigurationSettings.AppSettings["fechaConfig"];

                procedure.ExecuteNonQuery();
                Conexiones.CerrarConexion();
                MessageBox.Show("Cupón consumido exitosamente", "FrbaOfertas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message + ". No se realizó la entrega.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " No se realizó la entrega.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void cupon_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            using (GestionarClientes ventanaSeleccion = new GestionarClientes())
            {
                if (ventanaSeleccion.ShowDialog() == DialogResult.OK)
                {
                    this.datosClienteSeleccionado = ventanaSeleccion.datosFilaCliente;
                    cliente.Text = datosClienteSeleccionado["ID"].ToString();
                }
            }
            Cursor = Cursors.Default;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            using (Cupones ventanaSeleccion = new Cupones())
            {
                if (ventanaSeleccion.ShowDialog() == DialogResult.OK)
                {
                    this.datosCupon = ventanaSeleccion.datosFilaCupon;
                    cupon.Text = datosCupon["cupon_id"].ToString();
                    haySeleccionado = true;
                }
            }
            Cursor = Cursors.Default;
        }
    }
}
