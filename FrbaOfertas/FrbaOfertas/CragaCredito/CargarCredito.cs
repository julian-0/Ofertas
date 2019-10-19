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

        public CargarCredito()
        {
            InitializeComponent();
            comboNumero.Enabled = false;

            if (InfoUsuario.rolUsuario > 2)
            {
                btnSeleccionarCliente.Hide();
                txtCliente.ReadOnly = true;
                txtCliente.Text = InfoUsuario.nombreUsuario;
                datosClienteSeleccionado = InfoUsuario.datosCuenta;
                haySeleccionado = true;
            } 
        }

        private void btnInfoCLiente_Click(object sender, EventArgs e)
        {
            var lines = datosClienteSeleccionado.Select(kvp => kvp.Key + ": " + kvp.Value.ToString());
            MessageBox.Show(string.Join(Environment.NewLine, lines));
        }


        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {

            using (GestionarClientes ventanaSeleccion = new GestionarClientes())
            {
                if (ventanaSeleccion.ShowDialog() == DialogResult.OK)
                {
                    this.datosClienteSeleccionado = ventanaSeleccion.datosFilaCliente;
                    txtCliente.Text = datosClienteSeleccionado["Usuario"].ToString();
                    haySeleccionado = true;
                }
            }

        }

        private void cargarComboTarjetas()
        {
            string tipo = comboTipo.SelectedText;

            dt.Columns.Clear();
            dt.Rows.Clear();
            comboNumero.DataSource = dt;
            SqlConnection conexion = Conexiones.AbrirConexion();
            SqlCommand command = new SqlCommand("SELECT tarjeta_id,duenio,numero FROM NUNCA_INJOIN.Tarjeta WHERE tipo_pago = '"+tipo+"'", conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            comboNumero.ValueMember = "tarjeta_id";
            comboNumero.DisplayMember = "numero";
            comboNumero.DataSource = dt;
            Conexiones.CerrarConexion();
        }

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarComboTarjetas();
            comboNumero.Enabled = true;
        }

        private void comboNumero_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt.Columns.Clear();
            dt.Rows.Clear();
            SqlConnection conexion = Conexiones.AbrirConexion();
            SqlCommand command = new SqlCommand("SELECT tarjeta_id,duenio,numero,tipo_pago FROM NUNCA_INJOIN.Tarjeta WHERE tarjeta_id = '" + comboTipo.SelectedText + "'", conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            Conexiones.CerrarConexion();

            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn column in dt.Columns)
                {
                    datosTarjetaSeleccionada.Add(column.ColumnName.ToString(), row[column].ToString());
                }
            }
        }

        private void btnInfoTarjeta_Click(object sender, EventArgs e)
        {
            var lines = datosTarjetaSeleccionada.Select(kvp => kvp.Key + ": " + kvp.Value.ToString());
            MessageBox.Show(string.Join(Environment.NewLine, lines));
        }
    }
}
