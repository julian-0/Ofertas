using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.Menu;

namespace FrbaOfertas.AbmCliente
{
    public partial class GestionarClientes : Form
    {
        private VentanaMenu menu;

        public GestionarClientes(VentanaMenu m)
        {
            this.menu = m;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GestionarClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu.Show();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            new AltaCliente().Show();
        }
    }
}
