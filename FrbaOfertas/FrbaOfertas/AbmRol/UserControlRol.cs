using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.Datos;

namespace FrbaOfertas.AbmRol
{
    public partial class UserControlRol : UserControl
    {
        public UserControlRol(DataTable funcionalidadesRol)
        {
            InitializeComponent();
            this.cargarDataGridView(funcionalidadesRol);
        }

        public void cargarDataGridView(DataTable funcionalidadesRol)
        {
            dataGridActuales.DataSource = funcionalidadesRol;
            dataGridPosibles.DataSource = BaseDeDatos.getFuncionalidadesPosibles();
        }
    }
}
