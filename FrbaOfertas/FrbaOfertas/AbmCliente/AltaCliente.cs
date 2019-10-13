using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.Clases;
using FrbaOfertas.gestionUsuarios;
using System.Data.SqlClient;
using FrbaOfertas.Conexion;


namespace FrbaOfertas.AbmCliente
{
    public partial class AltaCliente : Form
    {
        public AltaCliente()
        {
            InitializeComponent();
        }

        private void txtNom_Leave(object sender, EventArgs e)
        {
            ValidadorCampos.texto(txtNom,errorNombre);
        }

        private void txtApe_Leave(object sender, EventArgs e)
        {
            ValidadorCampos.texto(txtApe, errorApe);
        }

        private void txtDni_Leave(object sender, EventArgs e)
        {
            ValidadorCampos.numerico(txtDni,errorDni);
        }

        private void txtTel_Leave(object sender, EventArgs e)
        {
            ValidadorCampos.numerico(txtTel, errorTel);
        }

        private void txtCodP_Leave(object sender, EventArgs e)
        {
            ValidadorCampos.numerico(txtCodP, errorCodP);
        }

        private void btnNuevoUser_Click(object sender, EventArgs e)
        {
            using (CreacionUsuario ventanaCreacion = new CreacionUsuario(this, "3"))
            {
                if (ventanaCreacion.ShowDialog() == DialogResult.OK)
                {
                    textIdUsuario.Text = ventanaCreacion.nombreIngresado;
                    textIdUsuario.ReadOnly = true;
                    btnNuevoUser.Hide();
                    txtNoTieneUser.Hide();
                }
            }
        }

        private void signinbutton_Click(object sender, EventArgs e)
        {
            /*
            SqlConnection conex = Conexiones.AbrirConexion();
            try
            {
                if (CamposCompletos())
                {
                    SqlCommand procedure = new SqlCommand("[NUNCA_INJOIN].altaCliente", conex);
                    procedure.CommandType = CommandType.StoredProcedure;
                    procedure.Parameters.Add("@nombre_rubro", SqlDbType.Int).Value = rubro.SelectedValue;
                    procedure.Parameters.Add("@usuario_id", SqlDbType.Int).Value = textBox1.Text;
                    procedure.Parameters.Add("@razon_social", SqlDbType.NVarChar).Value = razonSocial.Text;

                    procedure.ExecuteNonQuery();
                    Conexiones.CerrarConexion();
                    MessageBox.Show("Cliente creado correctamente", "FrbaOfertas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Complete todos los campos para seguir", "FrbaOfertas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique el formato de los campos completados", "FrbaOfertas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
             * */
        }
        
        private bool camposValidos()
        {
            return noTienenError() && estanCompletos();
        }
        
        private bool noTienenError()
        {
            return errorNombre.GetError(txtNom)+errorApe.GetError(txtApe)+errorDni.GetError(txtDni)+
                    errorTel.GetError(txtTel)+errorCodP.GetError(txtCodP) == "";
        }

        private bool estanCompletos()
        {
            return txtNom.Text != "" && txtApe.Text != "" && txtDni.Text != "" && txtTel.Text != ""
                && txtMail.Text != "" && fechaNac.Text != "" && textIdUsuario.Text != "" && 
                txtLocalidad.Text != "" && txtCodP.Text != "" && txtDom.Text != "" ;
        }

        private void textIdUsuario_Leave(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conex = Conexiones.AbrirConexion();
                SqlCommand procedure = new SqlCommand("[NUNCA_INJOIN].esUsuarioExistente", conex);
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.Add("@usuario_id", SqlDbType.NVarChar).Value = textIdUsuario.Text;
                procedure.Parameters.Add("@rol_id", SqlDbType.Int).Value = "3";
                procedure.ExecuteNonQuery();
                Conexiones.CerrarConexion();
            }
            catch (Exception ex)
            {
                errorUserId.Clear();
                errorUserId.SetError(textIdUsuario, ex.Message);
            }
        }
    }
}
