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
        public String funcionalidadAAgregar;
        public String funcionalidadAQuitar;
        public DataTable funcRol;
        public DataTable funcPosibles;

        public UserControlRol(DataTable funcionalidadesRol, DataTable funcionalidadesRestantes)
        {
            InitializeComponent();
            this.updateHeadersStyle();
            funcRol = funcionalidadesRol;
            funcPosibles = funcionalidadesRestantes;
            this.cargarDataGridView();
            dataGridActuales.ClearSelection();
            dataGridPosibles.ClearSelection();
        }

        private void updateHeadersStyle()
        {
            this.dataGridPosibles.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10F, FontStyle.Bold);
            this.dataGridActuales.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10F, FontStyle.Bold);
            dataGridActuales.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridPosibles.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;

        }

        public void cargarDataGridView()
        {
            dataGridActuales.DataSource = funcRol;
            dataGridPosibles.DataSource = funcPosibles;
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

        private void agregar_Click(object sender, EventArgs e)
        {
            if (dataGridPosibles.SelectedRows.Count > 0)
            {
                funcionalidadAAgregar = dataGridPosibles.SelectedRows[0].Cells["funcionalidad_id"].Value.ToString();
                DataRow nuevaFila = funcRol.NewRow();
                nuevaFila["funcionalidad_id"] = funcionalidadAAgregar;
                funcRol.Rows.Add(nuevaFila);
                foreach (DataRow row in funcPosibles.Rows)
                {
                    if (row.RowState != DataRowState.Deleted && row[0].ToString() == funcionalidadAAgregar)
                    {
                        row.Delete();
                        break; //Sin este break no sale _nunca_ del forEach();
                    }
                } 
            }
            
        }

        private void quitar_Click(object sender, EventArgs e)
        {
            if (dataGridActuales.SelectedRows.Count > 0)
            {
                funcionalidadAQuitar = dataGridActuales.SelectedRows[0].Cells["funcionalidad_id"].Value.ToString();
                DataRow nuevaFila = funcPosibles.NewRow();
                nuevaFila["funcionalidad_id"] = funcionalidadAQuitar;
                funcPosibles.Rows.Add(nuevaFila);
                foreach (DataRow row in funcRol.Rows)
                {
                    if (row.RowState != DataRowState.Deleted && row[0].ToString() == funcionalidadAQuitar)
                    {
                        row.Delete();
                        break;
                    }
                } 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
