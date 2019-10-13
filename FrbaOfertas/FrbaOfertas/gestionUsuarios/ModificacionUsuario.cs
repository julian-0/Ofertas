using FrbaOfertas.Conexion;
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

namespace FrbaOfertas.gestionUsuarios
{
    public partial class CreacionUsuario : Form
    {
        private Form login;
        public CreacionUsuario(Form log)
        {
            InitializeComponent();
            login = log;
        }

        private void nombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void password_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
        }

        private void botonCrear_Click(object sender, EventArgs e)
        {
            if (password.Text != password2.Text)
            {
                MessageBox.Show("Las contraseñas no coiniden", "FrbaOfertas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                password.Clear();
                password2.Clear();
            }
            else {
                try
                {
                    SqlConnection conex = Conexiones.AbrirConexion();
                    SqlCommand procedure = new SqlCommand("NUNCA_INJOIN.registrarUsuario", conex);
                    procedure.CommandType = CommandType.StoredProcedure;
                    procedure.Parameters.AddWithValue("@usuario_id", SqlDbType.NVarChar).Value = nombreUsuario.Text;
                    procedure.Parameters.Add("@rol_id", SqlDbType.Int).Value = 4;
                    procedure.Parameters.Add("@contrasenia", SqlDbType.NVarChar).Value = password.Text;
                    procedure.ExecuteNonQuery();
                    Conexiones.CerrarConexion();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    Conexiones.CerrarConexion();
                    password.Clear();
                    password2.Clear();
                }
            }

            
        }

        private void CreacionUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Show();
        }
    }
}
