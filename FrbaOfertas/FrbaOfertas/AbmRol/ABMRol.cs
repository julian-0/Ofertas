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

namespace FrbaOfertas.AbmRol
{
    public partial class ABMRol : Form
    {
        public ABMRol()
        {
            InitializeComponent();
            this.agregarRolesActivos();
        }

        private void agregarTab(DataRow row)
        {
            TabPage tp = new TabPage(row["nombre_rol"].ToString());
            DataTable funcionalidadesRol = BaseDeDatos.getFuncionalidadesRol(row["rol_id"].ToString());
            UserControlRol myUserControl = new UserControlRol(funcionalidadesRol);
            myUserControl.Dock = DockStyle.Fill;

            tp.Controls.Add(myUserControl);
            tabControl1.TabPages.Add(tp);
        }

        private void agregarRolesActivos()
        {
            DataTable dtRoles = BaseDeDatos.getRoles();
            foreach (DataRow row in dtRoles.Rows)
            {
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

            //g.DrawString(text, this.tabControl1.Font, Brushes.Black, x, y);


                

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("nombre_rol");
            table.Columns.Add("rol_id");
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            row["nombre_rol"] = "Nuevo Rol";
            row["rol_id"] = "99";
            this.agregarTab(row);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
