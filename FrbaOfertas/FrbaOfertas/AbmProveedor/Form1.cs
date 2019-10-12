using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FrbaOfertas.Conexion;
using FrbaOfertas.Menu;

namespace FrbaOfertas.AbmProveedor
{
    public partial class Form1 : Form
    {
        c_Conexion conexion = new c_Conexion();

        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TextBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        public bool CamposCompletos()
        {

            return razonSocial.Text != "" && email.Text != "" && telefono.Text != ""
                && cuit.Text != "" && nombre_de_contacto.Text != ""
                && ciudad.Text != "" && localidad.Text != "" && codigo_postal.Text != "" && domicilio.Text != "" ;

        }

        private void Signinbutton_Click(object sender, EventArgs e)
        {
            SqlConnection conex = conexion.AbrirConexion();
            try
            {
                if (CamposCompletos())
                {
                        SqlCommand procedure = new SqlCommand("[NUNCA_INJOIN].sp_cargarProveedor", conex);
                        procedure.CommandType = CommandType.StoredProcedure;
                        procedure.Parameters.Add("@rubro_id", SqlDbType.Int).Value = rubro.Text;
                        procedure.Parameters.Add("@razon_social", SqlDbType.NVarChar).Value = razonSocial.Text;
                        procedure.Parameters.Add("@mail", SqlDbType.NVarChar).Value = email.Text;
                        procedure.Parameters.Add("@telefono", SqlDbType.Int).Value = int.Parse(telefono.Text.ToString());
                        procedure.Parameters.Add("@domicilio", SqlDbType.NVarChar).Value = domicilio.Text;
                        procedure.Parameters.Add("@localidad", SqlDbType.NVarChar).Value = localidad.Text;
                        procedure.Parameters.Add("@ciudad", SqlDbType.NVarChar).Value = ciudad.Text;
                        procedure.Parameters.Add("@codigo_postal", SqlDbType.NVarChar).Value = codigo_postal.Text;
                        procedure.Parameters.Add("@cuit", SqlDbType.NVarChar).Value = cuit.Text;
                        procedure.Parameters.Add("@nombre_contacto", SqlDbType.NVarChar).Value = nombre_de_contacto.Text;
                        procedure.ExecuteNonQuery();
                        conexion.CerrarConexion();
                }
                else
                    MessageBox.Show("Complete todos los campos para seguir", "FrbaOfertas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique el formato de los campos completados", "FrbaOfertas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Rubro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

