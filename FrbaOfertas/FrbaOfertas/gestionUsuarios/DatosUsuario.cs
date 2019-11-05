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

namespace FrbaOfertas.gestionUsuarios
{
    public partial class DatosUsuario : Form
    {
        DataTable dt = new DataTable();

        public DatosUsuario(String usuario, String rol)
        {
            InitializeComponent();
            dt.Columns.Clear();
            dt.Rows.Clear();
            dt = BaseDeDatos.getInfoUsuario(usuario, rol);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
