using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.ListadoEstadistico
{
    public partial class Listado : Form
    {
        public Listado()
        {
            InitializeComponent();
            agregarTabs();
            
        }

        private void agregarTabs()
        {
            TabPage tp1 = new TabPage("Descuentos");
            TabPage tp2 = new TabPage("Facturacion");
            tabControl1.TabPages.Add(tp1);
            tabControl1.TabPages.Add(tp2);
            UserControlListado uc1 = new UserControlListado(tabControl1.SelectedIndex);
            UserControlListado uc2 = new UserControlListado(tabControl1.SelectedIndex+1);
            tp1.Controls.Add(uc1);
            tp2.Controls.Add(uc2);
        }
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {   
            var text = this.tabControl1.TabPages[e.Index].Text;
            var sizeText = e.Graphics.MeasureString(text, this.tabControl1.Font);

            var x = e.Bounds.Left + 3;
            var y = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2;

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

        }

    }
}
