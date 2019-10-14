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
            this.updateHeadersStyle();
            this.cargarDataGridView(funcionalidadesRol);
        }

        private void updateHeadersStyle()
        {
            this.dataGridPosibles.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10F, FontStyle.Bold);
            this.dataGridActuales.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10F, FontStyle.Bold);
            dataGridActuales.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridPosibles.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;

        }

        public void cargarDataGridView(DataTable funcionalidadesRol)
        {
            dataGridActuales.DataSource = funcionalidadesRol;
            dataGridPosibles.DataSource = BaseDeDatos.getFuncionalidadesPosibles();
            dataGridPosibles.Columns[0].HeaderText = "Posibles";
            dataGridActuales.Columns[0].HeaderText = "Actuales";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridPosibles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridActuales.ClearSelection();
        }

        private void dataGridActuales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridPosibles.ClearSelection();
        }
    }
}
