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


namespace FrbaOfertas.CragaCredito
{
    public partial class CargarCredito : Form
    {
        public Dictionary<string, string> datosClienteSeleccionado = new Dictionary<string, string>();
        public bool haySeleccionado = false;

        public CargarCredito()
        {
            InitializeComponent();
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

    }
}
