using FrbaOfertas.AbmProveedor;
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
        DataTable dt = new DataTable();
        private Form formAnterior;
        private String rolUsuario;
        private bool permitirCrearAdmin;

        public CreacionUsuario(Form log, String rolFijo, bool _permitirCrearAdmin)
        {
            InitializeComponent();
            formAnterior = log;
            permitirCrearAdmin = _permitirCrearAdmin;
            this.cargarComboRoles();
            if (rolFijo != null)
            {
                rolUsuario = rolFijo;
                comboBox1.SelectedValue = rolFijo;
                comboBox1.Enabled = false;
            }
        }
        public string nombreIngresado
        {
            get { return nombreUsuario.Text; }
        }
        private void cargarComboRoles()
        {
            dt.Columns.Clear();
            dt.Rows.Clear();
            comboBox1.DataSource = dt;
            SqlConnection conexion = Conexiones.AbrirConexion();
            String min = permitirCrearAdmin ? "1" : "2";
            SqlCommand command = new SqlCommand("SELECT rol_id, nombre_rol FROM NUNCA_INJOIN.RolesActivos WHERE rol_id > "+min, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            comboBox1.ValueMember = "rol_id";
            comboBox1.DisplayMember = "nombre_rol";
            comboBox1.DataSource = dt;
            Conexiones.CerrarConexion();
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
            formAnterior.Show();
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
                    procedure.Parameters.Add("@rol_id", SqlDbType.Int).Value = comboBox1.SelectedValue;
                    procedure.Parameters.Add("@contrasenia", SqlDbType.NVarChar).Value = password.Text;
                    procedure.ExecuteNonQuery();
                    Conexiones.CerrarConexion();
                    MessageBox.Show("Usuario creado correctamente! Para poder acceder, complete sus datos");
                    if (rolUsuario == null) //Se entro desde el login
                    {
                        switch (Int32.Parse(comboBox1.SelectedValue.ToString()))
                        {
                            case 3:
                                ModProv ventanaModificacionCliente = new ModProv(nombreUsuario.Text.ToString(), null);
                                ventanaModificacionCliente.Show();
                                break;
                            case 4:
                                ModProv ventanaModificacionProveedor = new ModProv(nombreUsuario.Text.ToString(), null);
                                ventanaModificacionProveedor.Show();
                                break;
                        }
                    }
                    else //Se entro desde abm proveedor
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    this.Close();
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
            formAnterior.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
