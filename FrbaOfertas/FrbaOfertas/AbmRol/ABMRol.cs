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
using Microsoft.VisualBasic;
using System.Data.SqlClient;
using FrbaOfertas.Conexion;
using FrbaOfertas.CrearOferta;

namespace FrbaOfertas.AbmRol
{
    public partial class ABMRol : Form
    {

        public List<string> rolesMostrados = new List<string>();

        public ABMRol()
        {
            InitializeComponent();
            this.agregarRolesActivos();
        }

        private void agregarTab(DataRow row)
        {
            TabPage tp = new TabPage(row["nombre_rol"].ToString());
            DataTable funcionalidadesRol = BaseDeDatos.getFuncionalidadesRol(row["rol_id"].ToString());
            DataTable funcionalidadesRestantes = BaseDeDatos.getFuncionalidadesRestantes(row["rol_id"].ToString());
            bool baja_logica = row["baja_logica"].ToString() == "S";
            UserControlRol myUserControl = new UserControlRol(funcionalidadesRol, funcionalidadesRestantes, row["rol_id"].ToString(), baja_logica);
            myUserControl.Dock = DockStyle.Fill;
            myUserControl.ParentForm = this;
            tp.Controls.Add(myUserControl);
            tabControl1.TabPages.Add(tp);
            rolesMostrados.Add(row["rol_id"].ToString());
        }

        private void agregarRolesActivos()
        {
            DataTable dtRoles = BaseDeDatos.getRoles();
            foreach (DataRow row in dtRoles.Rows)
            {
                if (!rolesMostrados.Contains(row["rol_id"].ToString()))
                   this.agregarTab(row);
            }
        }
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {

            if (e.Index == tabControl1.SelectedIndex)
            {
                e.Graphics.DrawString(tabControl1.TabPages[e.Index].Text,
                    new Font(new Font("Calibri", 11F, FontStyle.Bold), FontStyle.Bold),
                    Brushes.Black,
                    new PointF(e.Bounds.X + 3, e.Bounds.Y + 10));
            }
            else
            {
                e.Graphics.DrawString(tabControl1.TabPages[e.Index].Text,
                    new Font("Calibri", 10F, FontStyle.Bold),
                    Brushes.Gray,
                    new PointF(e.Bounds.X + 3, e.Bounds.Y + 10));
            }

            var g = e.Graphics;
            var text = this.tabControl1.TabPages[e.Index].Text;
            var sizeText = g.MeasureString(text, this.tabControl1.Font);

            var x = e.Bounds.Left + 3;
            var y = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nuevoRol = " ";
            using (NuevoNombre ventanaNombre = new NuevoNombre("Nuevo Rol"))
            {
                if (ventanaNombre.ShowDialog() == DialogResult.OK)
                {
                    nuevoRol = ventanaNombre.textBox1.Text;
                }
            }

            String query = "INSERT INTO NUNCA_INJOIN.Rol (nombre_rol) VALUES ('"+nuevoRol+"')";
            ejecutarQuery(query);
            agregarRolesActivos();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void ejecutarQuery(String query)
        {
            SqlConnection conexion = Conexiones.AbrirConexion();
            SqlCommand consulta = new SqlCommand(query, conexion);
            consulta.ExecuteNonQuery();
            Conexiones.CerrarConexion();
        }
    }
}
