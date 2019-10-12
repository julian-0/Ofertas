using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.Clases
{
    class ValidadorCampos
    {
        public static void texto(TextBox txt,ErrorProvider err)
        {
            err.Clear();
            bool b = txt.Text.All(Char.IsLetter);
            if (!b) err.SetError(txt, "No se aceptan numeros");
        }

        public static void numerico(TextBox txt, ErrorProvider err)
        {
            err.Clear();
            bool b = txt.Text.All(Char.IsDigit);
            if (!b) err.SetError(txt, "Solo se aceptan letras");
        }
    }
}
