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
using FrbaOfertas.AbmCliente;
using FrbaOfertas.Conexion;
using System.Data.SqlClient;



namespace FrbaOfertas.CragaCredito
{
    public partial class CargarCredito : Form
    {
        DataTable dt = new DataTable();

        public Dictionary<string, string> datosClienteSeleccionado = new Dictionary<string, string>();
        public Dictionary<string, string> datosTarjetaSeleccionada = new Dictionary<string, string>();
        public bool haySeleccionado = false;
        private bool seleccionoTipo = false;
        private bool seleccionoNumero = false;

        public CargarCredito()
        {
            InitializeComponent();
            comboNumero.Enabled = false;
            comboTipo.Enabled = false;

            btnAgregarTarjeta.Enabled = false;

            if (InfoUsuario.rolUsuario > 2)
            {
                btnSeleccionarCliente.Hide();
                txtCliente.ReadOnly = true;
                txtCliente.Text = InfoUsuario.nombreUsuario;
                datosClienteSeleccionado = InfoUsuario.datosCuenta;
                haySeleccionado = true;
                comboTipo.Enabled = true;
                btnAgregarTarjeta.Enabled = true;
            }
            comboTipo.SelectedIndex = 0;
        }

        private void btnInfoCLiente_Click(object sender, EventArgs e)
        {
            var lines = datosClienteSeleccionado.Select(kvp => kvp.Key + ": " + kvp.Value.ToString());
            MessageBox.Show(string.Join(Environment.NewLine, lines));
        }


        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            using (GestionarClientes ventanaSeleccion = new GestionarClientes())
            {
                if (ventanaSeleccion.ShowDialog() == DialogResult.OK)
                {
                    this.datosClienteSeleccionado = ventanaSeleccion.datosFilaCliente;
                    txtCliente.Text = datosClienteSeleccionado["Nombre"].ToString() + " " + datosClienteSeleccionado["Apellido"].ToString();
                    haySeleccionado = true;
                    btnAgregarTarjeta.Enabled = true;
                    comboTipo.Enabled = true;
                    comboNumero.Enabled = true;
                    cargarComboTarjetas();
                }
            }
            Cursor = Cursors.Default;
        }

        private void cargarComboTarjetas()
        {
            try
            {
                if (haySeleccionado)
                {
                    string tipo = comboTipo.SelectedItem.ToString();
                    dt.Columns.Clear();
                    dt.Rows.Clear();
                    comboNumero.DataSource = dt;
                    SqlConnection conexion = Conexiones.AbrirConexion();
                    SqlCommand command = new SqlCommand("SELECT tarjeta_id,duenio,numero FROM NUNCA_INJOIN.Tarjeta WHERE tipo_pago = '" + tipo + "' AND cliente_id = '" + datosClienteSeleccionado["ID"] + "'", conexion);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                    comboNumero.ValueMember = "tarjeta_id";
                    comboNumero.DisplayMember = "numero";
                    comboNumero.DataSource = dt;
                    Conexiones.CerrarConexion();
                }
            }
            catch
            {
            }
            try { comboNumero.SelectedIndex = 0; }
            catch { }
        }

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarComboTarjetas();
            comboNumero.Enabled = true;
            seleccionoTipo = true;
        }

        private void comboNumero_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccionoNumero = true;
        }

        private void btnInfoTarjeta_Click(object sender, EventArgs e)
        {
  
        }

        private void btnAgregarTarjeta_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if(seleccionoCliente())
            (new AgregarTarjeta(Int32.Parse(datosClienteSeleccionado["ID"]))).ShowDialog();
            else
                MessageBox.Show("Seleccione un cliente para vincular la tarjeta", "FrbaOfertas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Cursor = Cursors.Default;
            comboTipo.Enabled = true;
            cargarComboTarjetas();
        }

        private bool seleccionoCliente()
        {
            return haySeleccionado;
        }

        private bool camposCompletos()
        {
            return seleccionoTipo && seleccionoNumero && haySeleccionado;
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            SqlConnection conex = Conexiones.AbrirConexion();
            if (this.camposCompletos())
            {
                SqlCommand procedure = new SqlCommand("[NUNCA_INJOIN].cargarCredito", conex);
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.Add("@cliente", SqlDbType.Int).Value = Int32.Parse(datosClienteSeleccionado["ID"]);
                procedure.Parameters.Add("@cantidad", SqlDbType.Int).Value = Int32.Parse(monto.Value.ToString());
                procedure.Parameters.Add("@tarjeta", SqlDbType.Int).Value = comboNumero.SelectedValue;
                procedure.Parameters.Add("@fecha", SqlDbType.NVarChar).Value = BaseDeDatos.fechaConfigString;
                procedure.ExecuteNonQuery();
                Conexiones.CerrarConexion();
                MessageBox.Show("Carga realizada", "FrbaOfertas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Complete todos los campos para seguir", "FrbaOfertas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboTipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargarComboTarjetas();
            seleccionoTipo = true;
        }

        private void comboNumero_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataTable tarjeta = new DataTable();
            try
            {
                string numero = comboNumero.SelectedValue.ToString();
                tarjeta = BaseDeDatos.solicitar("SELECT tarjeta_id, duenio FROM NUNCA_INJOIN.Tarjeta WHERE tarjeta_id = " + numero);
                DataRow fila = tarjeta.Rows[0];
                String id = fila["tarjeta_id"].ToString();
                String duenio = fila["duenio"].ToString();
                textBox1.Text = duenio;
            }
            catch
            {
                textBox1.Text = "";
            }
        }
    }
}
