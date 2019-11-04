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

namespace FrbaOfertas.CragaCredito
{
    public partial class AgregarTarjeta : Form
    {
        public Dictionary<string, string> datosTarjeta = new Dictionary<string, string>();
        int cliente;

        public AgregarTarjeta(int _cliente)
        {
            InitializeComponent();
            cliente = _cliente;
            comboTipo.SelectedIndex = 0;
        }

        private bool camposCompletos(){
            return txtNumero.Text.ToString() != "" && txtNombre.Text.ToString() != "";
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            SqlConnection conex = Conexiones.AbrirConexion();
            if (this.camposCompletos())
            {
                SqlCommand procedure = new SqlCommand("[NUNCA_INJOIN].crearTarjeta", conex);
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.Add("@cliente", SqlDbType.Int).Value = cliente;
                procedure.Parameters.Add("@tarjeta_tipo", SqlDbType.NVarChar).Value = comboTipo.SelectedText.ToString();
                procedure.Parameters.Add("@duenio", SqlDbType.NVarChar).Value = txtNombre.Text.ToString();
                procedure.Parameters.Add("@tarjeta_numero", SqlDbType.Int).Value = Int32.Parse(txtNumero.Text.ToString());
                procedure.ExecuteNonQuery();
                Conexiones.CerrarConexion();
                MessageBox.Show("Tarjeta creada", "FrbaOfertas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Complete todos los campos para seguir", "FrbaOfertas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
