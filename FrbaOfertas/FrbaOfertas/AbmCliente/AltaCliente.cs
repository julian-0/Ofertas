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
 
        }
    }
}
