using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FrbaOfertas.Conexion;
using FrbaOfertas.Datos;

namespace FrbaOfertas.ListadoEstadistico
{
    public partial class UserControlListado : UserControl
    {
        int selectedTab;
        public UserControlListado(int tabIndex)
        {
            InitializeComponent();
            selectedTab = tabIndex;
            rellenarCombobox();
            rellenarDataGrid();
        }
        private void ejecutarQuery(String query)
        {
            SqlConnection conexion = Conexiones.AbrirConexion();
            SqlCommand consulta = new SqlCommand(query, conexion);
            consulta.ExecuteNonQuery();
            Conexiones.CerrarConexion();
        }

        private void rellenarCombobox()
        {
            DataTable dtAnios = (selectedTab == 0) ? BaseDeDatos.getAniosOfertas() : BaseDeDatos.getAniosFacturas();
            comboBoxAnio.DisplayMember = "Anio";
            comboBoxAnio.ValueMember = "Anio";
            comboBoxAnio.DataSource = dtAnios;
            if(comboBoxAnio.Items.Count != 0)
               comboBoxAnio.SelectedIndex = 0;
            comboBoxSem.SelectedIndex = 0;
        }

        private void rellenarDataGrid()
        {
            DataTable dt;
            if (selectedTab == 0)
                dt = BaseDeDatos.getTopDescuentos(comboBoxAnio.SelectedValue.ToString(), comboBoxSem.Text.ToString());
            else
                dt = BaseDeDatos.getTopFacturas(comboBoxAnio.SelectedValue.ToString(), comboBoxSem.Text.ToString());
            dataGridView1.DataSource = dt;
        }

        private void comboBoxAnio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            rellenarDataGrid();
        }

        private void comboBoxSem_SelectionChangeCommitted(object sender, EventArgs e)
        {
            rellenarDataGrid();
        }
    }
}
