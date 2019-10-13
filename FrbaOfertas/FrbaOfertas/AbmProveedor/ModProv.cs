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
using FrbaOfertas.gestionUsuarios;
using FrbaOfertas.Datos;

namespace FrbaOfertas.AbmProveedor
{
    public partial class ModProv : Form
    {
        Conexiones conexion = new Conexiones();
        DataTable dt = new DataTable();

        public ModProv(String usuario_id, List<string> datosOriginales)
        {
            InitializeComponent();
            if (usuario_id != null) ///Llega desde crear cuenta
            {
                textBox1.Text = usuario_id;
                textBox1.ReadOnly = true;
                button1.Hide();
                textBox2.Hide();
            }
            else if ((datosOriginales != null)) //Llega de modificacion
            {
                this.autocompletarCampos(datosOriginales);
                if (datosOriginales[1] != "")
                {
                    textBox1.Text = datosOriginales[1];
                    textBox1.ReadOnly = true;
                    button1.Hide();
                    textBox2.Text = "Ya tiene usuario";
                }
            }
            
            this.cargarComboRubro();
        }

        private void autocompletarCampos(List<string> datosOriginales)
        {
            razonSocial.Text = datosOriginales[0];
            rubro.SelectedText = datosOriginales[2];
            cuit.Text = datosOriginales[3];
            telefono.Text = datosOriginales[4];
            email.Text = datosOriginales[5];
            localidad.Text = datosOriginales[6];
            nombre_de_contacto.Text = datosOriginales[7];
            ciudad.Text = datosOriginales[8];
            codigo_postal.Text = datosOriginales[9];
        }

        private void cargarComboRubro()
        {
            dt.Columns.Clear();
            dt.Rows.Clear();
            rubro.DataSource = dt;
            SqlConnection conexion = Conexiones.AbrirConexion();
            SqlCommand command = new SqlCommand("SELECT rubro_id, nombre_rubro FROM NUNCA_INJOIN.Rubro", conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            rubro.ValueMember = "rubro_id";
            rubro.DisplayMember = "nombre_rubro";
            rubro.DataSource = dt;
            Conexiones.CerrarConexion();
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
            SqlConnection conex = Conexiones.AbrirConexion();
            try
            {
                if (CamposCompletos())
                {
                        SqlCommand procedure = new SqlCommand("[NUNCA_INJOIN].altaProveedor", conex);
                        procedure.CommandType = CommandType.StoredProcedure;
                        procedure.Parameters.Add("@nombre_rubro", SqlDbType.Int).Value = rubro.SelectedValue;
                        procedure.Parameters.Add("@usuario_id", SqlDbType.VarChar).Value = textBox1.Text;    
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
                        Conexiones.CerrarConexion();
                        MessageBox.Show("Proveedor creado correctamente", "FrbaOfertas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            using (CreacionUsuario ventanaCreacion = new CreacionUsuario(this, "4", InfoUsuario.rolUsuario == 1))
            {
                if (ventanaCreacion.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = ventanaCreacion.nombreIngresado;
                    textBox1.ReadOnly = true;
                    button1.Hide();
                    textBox2.Hide();
                }
            }
        }
    }
}

