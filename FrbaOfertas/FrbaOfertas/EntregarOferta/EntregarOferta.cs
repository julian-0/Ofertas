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

namespace FrbaOfertas.EntregarOferta
{
    public partial class EntregaOferta : Form
    {
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

        private bool hayError()
        {
            return errorCupon.GetError(cupon) + errorCliente.GetError(cliente) != "";
        }

        private void buttonConsumirCupon_Click(object sender, EventArgs e)
        {
            if (hayError()) {
                MessageBox.Show("Los campos ingresados deben ser numericos", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlCommand procedure = new SqlCommand();
            procedure.Connection = Conexiones.AbrirConexion();
            procedure.Parameters.Clear();

            procedure.CommandText = "NUNCA_INJOIN.consumirOferta";
            procedure.CommandType = CommandType.StoredProcedure;

            procedure.Parameters.Add("@cupon_id", SqlDbType.Decimal).Value = Convert.ToInt32(cupon.Text);
            procedure.Parameters.Add("@cliente_entrega_id", SqlDbType.Decimal).Value = Convert.ToInt32(cliente.Text);
            procedure.Parameters.Add("@fecha", SqlDbType.NVarChar).Value = System.Configuration.ConfigurationSettings.AppSettings["fechaConfig"];

            try
            {
                procedure.ExecuteNonQuery();
                MessageBox.Show("Consumicion realizada exitosamente", "FrbaOfertas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Conexiones.CerrarConexion();
        }

        private void cupon_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
