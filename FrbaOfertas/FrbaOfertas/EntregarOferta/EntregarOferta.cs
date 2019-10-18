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

        private void cupon_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonConsumirCupon_Click(object sender, EventArgs e)
        {
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
                MessageBox.Show(ex.Message, "prueba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Conexiones.CerrarConexion();
        }
    }
}
