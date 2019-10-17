using FrbaOfertas.CrearOferta;
using FrbaOfertas.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        
        public FacturarProv()
        {
            InitializeComponent();
        }

        public bool camposCompletos()
        {
            return haySeleccionado;
        }

        private void buttonSeleccionarProveedor_Click(object sender, EventArgs e)
        {
            using (SeleccionProveedor ventanaCreacion = new SeleccionProveedor())
            {
                if (ventanaCreacion.ShowDialog() == DialogResult.OK)
                {
                    this.datosProveedorSeleccionado = ventanaCreacion.datosProveedor;
                    textBoxProveedor.Text = datosProveedorSeleccionado["razon_social"].ToString();
                    haySeleccionado = true;
                }
            }
        }

        private void rellenarDataGrid()
        {
            if (camposCompletos())
            {
                DataTable dt;
                dt = BaseDeDatos.getOfertasProveedor(fechaDesde.Text.ToString(), fechaHasta.Text.ToString(), datosProveedorSeleccionado["proveedor_id"].ToString());
                dataGridView1.DataSource = dt;
            }
        }

        private void fechaDesde_TabIndexChanged(object sender, EventArgs e)
        {
            rellenarDataGrid();
        }

        private void fechaHasta_TabIndexChanged(object sender, EventArgs e)
        {
            rellenarDataGrid();
        }
    }
}
