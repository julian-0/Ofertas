﻿using FrbaOfertas.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.Datos;
using System.Reflection;

namespace FrbaOfertas.gestionUsuarios
{
    public partial class ABMUsuarios : Form
    {
        DataTable dt = new DataTable();
        DataTable dtRoles = new DataTable();
        public Dictionary<string, string> datosUsuario = new Dictionary<string, string>();
        

        public ABMUsuarios()
        {
            InitializeComponent();
            updateHeadersStyle();
            cargarComboRoles();
            cargarDatos();
        }

        private void cargarComboRoles()
        {
            dtRoles.Columns.Clear();
            dtRoles.Rows.Clear();
            rol.DataSource = dtRoles;
            SqlConnection conexion = Conexiones.AbrirConexion();
            SqlCommand command = new SqlCommand("SELECT rol_id, nombre_rol FROM NUNCA_INJOIN.RolesActivos", conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dtRoles);
            rol.ValueMember = "rol_id";
            rol.DisplayMember = "nombre_rol";
            rol.DataSource = dtRoles;
            Conexiones.CerrarConexion();
        }

        private void updateHeadersStyle()
        {
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 9.75F, FontStyle.Bold);
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView1.AutoSize = false;
            Type dgvType = dataGridView1.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dataGridView1, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreacionUsuario ventanaCreacion = new CreacionUsuario(this, null, InfoUsuario.rolUsuario == 1);
            ventanaCreacion.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void ABMUsuarios_Load(object sender, EventArgs e)
        {
        }

        private void cargarDatos()
        {
            dt.Columns.Clear();
            dt.Rows.Clear();
            dataGridView1.DataSource = dt;
            SqlConnection conexion = Conexiones.AbrirConexion();
            char verInhabilitados = mostrarInhabilitados.Checked ? '1' : '0';
            char verHabilitados = mostrarHabilitados.Checked ? '1' : '0';
            SqlCommand command = new SqlCommand("SELECT * FROM NUNCA_INJOIN.VerUsuarios(" + verHabilitados + "," + verInhabilitados + ", '" + usuario.Text + "', '" + rol.Text + "' )", conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            Conexiones.CerrarConexion();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            String bl = Convert.ToString(selectedRow.Cells["Inhabilitado"].Value);
            String usuario_id = Convert.ToString(selectedRow.Cells["Usuario"].Value.ToString());
            String nueva_bl = bl == "S" ? "N" : "S";
            String query = " UPDATE NUNCA_INJOIN.Usuario " +
                    " SET baja_logica = '" + nueva_bl + "'" +
                    " WHERE usuario_id LIKE '" + usuario_id + "'";
            ejecutarQuery(query);
            cargarDatos();
        }

        private void ejecutarQuery(String query)
        {
            SqlConnection conexion = Conexiones.AbrirConexion();
            SqlCommand consulta = new SqlCommand(query, conexion);
            consulta.ExecuteNonQuery();
            Conexiones.CerrarConexion();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            datosUsuario.Clear();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                for (int i = 0; i < 3; i++)
                {
                    datosUsuario.Add(dataGridView1.Columns[i].Name, row.Cells[i].Value.ToString());
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void resetRol_Click(object sender, EventArgs e)
        {
            rol.ResetText();
            rol.SelectedIndex = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String usuario = datosUsuario["Usuario"].ToString();
            String rol = datosUsuario["Rol"].ToString();

            Cursor = Cursors.WaitCursor;
            using (DatosUsuario ventanaCreacion = new DatosUsuario(usuario, rol))
            {
                if (ventanaCreacion.ShowDialog() == DialogResult.OK)
                {
                }
            }
            Cursor = Cursors.Default;


        }
    }
}
