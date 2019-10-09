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

namespace FrbaOfertas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            password.PasswordChar = '*';
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Signinbutton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-6C0TANM\SQLSERVER2012;Initial Catalog=GD2C2019;Persist Security Info=True;User ID=gdCupon2019;Password=gd2019");
            String query = "Select * from NUNCA_INJOIN.Usuario where usuario_id = '" + password.Text.Trim() + "' and contrasenia= '" + usuarioTxt.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                Login objFrmMain = new Login();
                this.Hide();
                objFrmMain.Show();
            }
            else
            {
                MessageBox.Show("Check your username and password");
            }
        }

        private void UsuarioTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
