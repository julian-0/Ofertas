using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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


        public AgregarTarjeta()
        {
            InitializeComponent();
        }
    }
}
