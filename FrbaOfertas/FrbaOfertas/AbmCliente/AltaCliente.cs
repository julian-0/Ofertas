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
    }
}
