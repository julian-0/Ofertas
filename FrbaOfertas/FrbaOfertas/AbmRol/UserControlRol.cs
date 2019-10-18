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
using FrbaOfertas.CrearOferta;
using System.Data.SqlClient;
using FrbaOfertas.Conexion;

namespace FrbaOfertas.AbmRol
{
    public partial class UserControlRol : UserControl
    {
        public ABMRol ParentForm;
        public DataTable funcRol;
        public DataTable funcPosibles;
        private String rol_id;
        private bool baja_logica;
        public String transaccion = "";

        public UserControlRol(DataTable funcionalidadesRol, DataTable funcionalidadesRestantes, String _rol_id, bool _baja_logica)
        {
            InitializeComponent();
            this.updateHeadersStyle();
            funcRol = funcionalidadesRol;
            funcPosibles = funcionalidadesRestantes;
            rol_id = _rol_id;
            baja_logica = _baja_logica;
            this.cargarDataGridView();
            dataGridActuales.ClearSelection();
            dataGridPosibles.ClearSelection();
            actualizarCartelBajaLogica();
        }
        private void actualizarCartelBajaLogica()
        {
            labelHab.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold);
            if (!baja_logica)
            {
                labelHab.Text = "[HABILITADO]";
                labelHab.ForeColor = Color.Green;
            }
            else 
            {
                labelHab.Text = "[INHABILITADO]";
                labelHab.ForeColor = Color.Red;
            }
            
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
                String funcionalidadAAgregar = dataGridPosibles.SelectedRows[0].Cells["funcionalidad_id"].Value.ToString();
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
                agregarFuncionalidad(funcionalidadAAgregar);
            }

        }

        private void quitar_Click(object sender, EventArgs e)
        {
            if (dataGridActuales.SelectedRows.Count > 0)
            {
                String funcionalidadAQuitar = dataGridActuales.SelectedRows[0].Cells["funcionalidad_id"].Value.ToString();
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
                quitarFuncionalidad(funcionalidadAQuitar);
            }
            
        }

        private void agregarFuncionalidad(String nuevaFunc)
        {

            SqlConnection conexion = Conexiones.AbrirConexion();
            String query = "INSERT INTO NUNCA_INJOIN.FuncionalidadPorRol(rol_id, funcionalidad_id)" +
                                          " VALUES (" + rol_id + ", '" +nuevaFunc + "') ";
            transaccion += query;
        }

        private void quitarFuncionalidad(String funcAQuitar)
        {
            SqlConnection conexion = Conexiones.AbrirConexion();
            String query = " DELETE FROM NUNCA_INJOIN.FuncionalidadPorRol " +
                                        " WHERE rol_id = " + rol_id +
                                        " AND funcionalidad_id = '" + funcAQuitar+"' ";
            transaccion += query;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void buttonNombre_Click(object sender, EventArgs e)
        {
            using (NuevoNombre ventanaNombre = new NuevoNombre(ParentForm.tabControl1.SelectedTab.Text))
            {
                if (ventanaNombre.ShowDialog() == DialogResult.OK)
                {
                    ParentForm.tabControl1.SelectedTab.Text = ventanaNombre.textBox1.Text;
                    actualizarNombre(ventanaNombre.textBox1.Text);
                }
            }
            ParentForm.tabControl1.Refresh();
            
        }

        private void actualizarNombre(String nuevoNombre)
        {
            String query = " UPDATE NUNCA_INJOIN.Rol " +
                                " SET nombre_rol = '"+nuevoNombre+"'"+
                                " WHERE rol_id = " + rol_id;
            transaccion += query;
        }

        private void buttonInhabilitar_Click(object sender, EventArgs e)
        {
            String nueva_bl = baja_logica? "'N'" : "'S'";
            String query= " UPDATE NUNCA_INJOIN.Rol " +
                                    " SET baja_logica = " + nueva_bl +
                                    " WHERE rol_id = " + rol_id;
            baja_logica = !baja_logica;
            transaccion += query;
            actualizarCartelBajaLogica();
        }

        private void ejecutarQuery(String query)
        {
            SqlConnection conexion = Conexiones.AbrirConexion();
            SqlCommand consulta = new SqlCommand(query, conexion);
            consulta.ExecuteNonQuery();
            Conexiones.CerrarConexion();
        }

        public void guardarModificaciones()
        {
            if (transaccion != "")
            {
                ejecutarQuery(transaccion);
                transaccion = "";
            }
        }
    }
}
