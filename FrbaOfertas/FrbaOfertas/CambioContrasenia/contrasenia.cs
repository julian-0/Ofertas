using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.Datos;
using FrbaOfertas.Conexion;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace FrbaOfertas.CambioContrasenia
{
    public partial class Contrasenia : Form
    {
        public Contrasenia()
        {
            InitializeComponent();
            if (InfoUsuario.rolUsuario > 2)
            {
                usuarioTxt.ReadOnly = true;
                usuarioTxt.Text = InfoUsuario.nombreUsuario;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void usuarioTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CamposCompletos()
        {
            return usuarioTxt.Text != "" && contraseniaTxt.Text != "";
        }

        private void cambiarButton_Click(object sender, EventArgs e)
        {
            SqlConnection conex = Conexiones.AbrirConexion();
            if (this.CamposCompletos())
            {
                SqlCommand procedure = new SqlCommand("[NUNCA_INJOIN].cambiarContrasenia", conex);
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.Add("@usuario_id", SqlDbType.NVarChar).Value = usuarioTxt.Text;
                procedure.Parameters.Add("@nuevaContrasenia", SqlDbType.NVarChar).Value = contraseniaTxt.Text;
                procedure.ExecuteNonQuery();
                Conexiones.CerrarConexion();
                MessageBox.Show("Contraseña cambiada correctamente", "FrbaOfertas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Complete todos los campos para seguir", "FrbaOfertas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
