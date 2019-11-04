using FrbaOfertas.AbmCliente;
using FrbaOfertas.Conexion;
using FrbaOfertas.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.EntregarOferta
{
    public partial class Cupones : Form
    {
        public Dictionary<string, string> datosClienteSeleccionado = new Dictionary<string, string>();
        public Dictionary<string, string> datosFilaCupon = new Dictionary<string, string>();
        public bool haySeleccionado = false;
        public bool buscarWasClicked = false;

        public Cupones()
        {
            InitializeComponent();
            this.tablaCupones.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 9.75F, FontStyle.Bold);

            //Velocidad al mango:
            tablaCupones.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing; 
            tablaCupones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            tablaCupones.AutoSize = false;
            Type dgvType = tablaCupones.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(tablaCupones, null);

            buscar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            using (GestionarClientes ventanaSeleccion = new GestionarClientes())
            {
                if (ventanaSeleccion.ShowDialog() == DialogResult.OK)
                {
                    this.datosClienteSeleccionado = ventanaSeleccion.datosFilaCliente;
                    comprador.Text = datosClienteSeleccionado["Nombre"].ToString() + " " + datosClienteSeleccionado["Apellido"].ToString();
                    haySeleccionado = true;
                }
            }
            Cursor = Cursors.Default;
        }

        private void tablaCupones_SelectionChanged(object sender, EventArgs e)
        {
            datosFilaCupon.Clear();
            foreach (DataGridViewRow row in tablaCupones.SelectedRows)
            {
                for (int i = 0; i < tablaCupones.ColumnCount; i++)
                {
                    datosFilaCupon.Add(tablaCupones.Columns[i].Name, row.Cells[i].Value.ToString());
                }
            }
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void buscar()
        {
            Cursor = Cursors.WaitCursor;
            buscarWasClicked = true;
            if (comprador.Text == "") {
                tablaCupones.DataSource = BaseDeDatos.getCuponesFiltradosPorOferta(txtNombre.Text);
                Cursor = Cursors.Default;
                return;
            }
            tablaCupones.DataSource = BaseDeDatos.getCuponesFiltrados(txtNombre.Text, comprador.Text) ;
            Cursor = Cursors.Default;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }
    }
}
