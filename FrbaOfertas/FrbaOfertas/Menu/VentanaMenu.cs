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
using FrbaOfertas.Datos;
using FrbaOfertas.CrearOferta;
using FrbaOfertas.AbmRol;
using FrbaOfertas.ComprarOferta;
using FrbaOfertas.ListadoEstadistico;
using FrbaOfertas.Facturar;
using FrbaOfertas.EntregarOferta;
using FrbaOfertas.CragaCredito;

namespace FrbaOfertas.Menu
{
    public partial class VentanaMenu : Form
    {
        private Login login;
        private Conexiones conexion = new Conexiones();

        public VentanaMenu(Login log,String usuario)
        {
            login = log;
            InfoUsuario.Completar(usuario);
            InitializeComponent();
            dateTimePicker1.Value = BaseDeDatos.fechaConfig;
            dateTimePicker1.Enabled = false;
        }

        private void VentanaMenu_Load(object sender, EventArgs e)
        {
            labelBienvenida.Text = "Bienvenidx " + InfoUsuario.nombreUsuario + "!";
            ocultarBotones(InfoUsuario.nombreUsuario);
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
            procedure.Parameters.Add("@puedeEntregar", SqlDbType.Int).Direction = ParameterDirection.Output;

            procedure.ExecuteNonQuery();
            Conexiones.CerrarConexion();

            int entregar = Convert.ToInt32(procedure.Parameters["@puedeEntregar"].Value);
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
            if (entregar == 0)  botonEntregar.Hide();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            InfoUsuario.Clear();
            login.Show();
            this.Hide();
        }

        private void VentanaMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAbmCli_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            abrir(new GestionarClientes(this));
        }

        private void btnAbmPro_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            abrir(new ABMProv());
        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            abrir(new ABMUsuarios());
        }

        private void btnOfertar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            abrir(new CreacionOferta());
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            abrir(new ABMRol());
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            abrir(new VentanaComprar(login.getUsuario()));
        }

        private void btnEst_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            abrir(new Listado());
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            abrir(new FacturarProv());
        }

        private void botonEntregar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            abrir(new EntregaOferta());
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            abrir(new CargarCredito());
        }

        private void abrir(Form ventana)
        {
            ventana.ShowDialog();
            Cursor = Cursors.Default;
        }
    }
}
