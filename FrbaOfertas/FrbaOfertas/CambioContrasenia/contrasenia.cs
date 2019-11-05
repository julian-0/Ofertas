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

        private void verificarCampos()
        {
            if (usuarioTxt.Text == "" || contraseniaTxt.Text == "")
            {
                throw new ArgumentException("Complete los campos");
            }
            else if (!BaseDeDatos.existeUsuario(usuarioTxt.Text.ToString()))
            {
                throw new ArgumentException("No existe el usuario '" + usuarioTxt.Text.ToString() + "'");
            }
        }

        private void cambiarButton_Click(object sender, EventArgs e)
        {
            try
            {
                verificarCampos();
                SqlConnection conex = Conexiones.AbrirConexion();
                SqlCommand procedure = new SqlCommand("[NUNCA_INJOIN].cambiarContrasenia", conex);
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.Add("@usuario_id", SqlDbType.NVarChar).Value = usuarioTxt.Text;
                procedure.Parameters.Add("@nuevaContrasenia", SqlDbType.NVarChar).Value = contraseniaTxt.Text;
                procedure.ExecuteNonQuery();
                Conexiones.CerrarConexion();
                MessageBox.Show("Contraseña cambiada correctamente", "FrbaOfertas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message + ". No se cambio la contraseña.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " No se cambio la contraseña.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
