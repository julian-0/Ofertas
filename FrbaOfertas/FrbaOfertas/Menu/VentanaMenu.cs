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
using FrbaOfertas.AbmCliente;
using FrbaOfertas.AbmProveedor;
using FrbaOfertas.gestionUsuarios;
namespace FrbaOfertas.Menu
{
    public partial class VentanaMenu : Form
    {
        private String id_usuario;
        private Login login;
        private Conexiones conexion = new Conexiones();

        public VentanaMenu(Login log,String usuario)
        {
            login = log;
            id_usuario = usuario;
            InitializeComponent();
        }

        private void VentanaMenu_Load(object sender, EventArgs e)
        {
            labelBienvenida.Text = "Bienvenidx " + id_usuario + "!";
            ocultarBotones(id_usuario);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void ocultarBotones(string usuario)
        {
            SqlCommand procedure = new SqlCommand();
            procedure.Connection = Conexiones.AbrirConexion();
            procedure.Parameters.Clear();

            procedure.CommandText = "NUNCA_INJOIN.sp_obtenerFuncionalidades";
            procedure.CommandType = CommandType.StoredProcedure;
            procedure.Parameters.Add("@id_usuario", SqlDbType.NVarChar).Value = usuario;
            procedure.Parameters.Add("@puedeRol", SqlDbType.Int).Direction = ParameterDirection.Output;
            procedure.Parameters.Add("@puedeRegUser", SqlDbType.Int).Direction = ParameterDirection.Output;
            procedure.Parameters.Add("@puedeAbmCli", SqlDbType.Int).Direction = ParameterDirection.Output;
            procedure.Parameters.Add("@puedeAbmPro", SqlDbType.Int).Direction = ParameterDirection.Output;
            procedure.Parameters.Add("@puedeCargar", SqlDbType.Int).Direction = ParameterDirection.Output;
            procedure.Parameters.Add("@puedeComprar", SqlDbType.Int).Direction = ParameterDirection.Output;
            procedure.Parameters.Add("@puedeOfertar", SqlDbType.Int).Direction = ParameterDirection.Output;
            procedure.Parameters.Add("@puedeFacturar", SqlDbType.Int).Direction = ParameterDirection.Output;
            procedure.Parameters.Add("@puedeEst", SqlDbType.Int).Direction = ParameterDirection.Output;
            
            procedure.ExecuteNonQuery();
            Conexiones.CerrarConexion();

            int rol         = Convert.ToInt32(procedure.Parameters["@puedeRol"].Value);
            int regUser     = Convert.ToInt32(procedure.Parameters["@puedeRegUser"].Value);
            int abmCli      = Convert.ToInt32(procedure.Parameters["@puedeAbmCli"].Value);
            int abmPro      = Convert.ToInt32(procedure.Parameters["@puedeAbmPro"].Value);
            int cargar      = Convert.ToInt32(procedure.Parameters["@puedeCargar"].Value);
            int comprar     = Convert.ToInt32(procedure.Parameters["@puedeComprar"].Value);
            int ofertar     = Convert.ToInt32(procedure.Parameters["@puedeOfertar"].Value);
            int facturar    = Convert.ToInt32(procedure.Parameters["@puedeFacturar"].Value);
            int est         = Convert.ToInt32(procedure.Parameters["@puedeEst"].Value);

            if (rol == 0)       btnRoles.Hide();
            if (regUser == 0)   btnRegis.Hide();
            if (abmCli == 0)    btnAbmCli.Hide();
            if (abmPro == 0)    btnAbmPro.Hide();
            if (cargar == 0)    btnCarga.Hide();
            if (comprar == 0)   btnComprar.Hide();
            if (ofertar== 0)    btnOfertar.Hide();
            if (facturar == 0)  btnFacturar.Hide();
            if (est == 0)       btnEst.Hide();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Hide();
        }

        private void VentanaMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAbmCli_Click(object sender, EventArgs e)
        {
            new GestionarClientes(this).Show();
            this.Hide();
        }

        private void btnAbmPro_Click(object sender, EventArgs e)
        {
            ABMProv abmProveedor = new ABMProv();
            abmProveedor.Show();
        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            ABMUsuarios abmUsuarios = new ABMUsuarios();
            abmUsuarios.Show();
        }
    }
}
