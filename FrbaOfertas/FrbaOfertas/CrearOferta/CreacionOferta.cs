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
namespace FrbaOfertas.CrearOferta
{
    public partial class CreacionOferta : Form
    {
        public DateTime fechaConfig = DateTime.Parse(System.Configuration.ConfigurationSettings.AppSettings["fechaConfig"]);

        public CreacionOferta()
        {
            InitializeComponent();
            if (InfoUsuario.rolUsuario > 2)
            {
                buttonSeleccionarProveedor.Hide();
                textBoxProveedor.ReadOnly = true;
                textBoxProveedor.Text = InfoUsuario.nombreUsuario;
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void buttonSeleccionarProveedor_Click(object sender, EventArgs e)
        {
            
            using (SeleccionProveedor ventanaCreacion = new SeleccionProveedor())
            {
                if (ventanaCreacion.ShowDialog() == DialogResult.OK)
                {
                    textBoxProveedor.Text = ventanaCreacion.proveedorSeleccionado;
                    textBoxProveedor.ReadOnly = true;
                }
            }
        }
    }
}
