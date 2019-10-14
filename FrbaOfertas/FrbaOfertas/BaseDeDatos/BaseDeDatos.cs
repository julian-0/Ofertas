using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using FrbaOfertas.Conexion;
using System.Windows.Forms;
using System.Data;

namespace FrbaOfertas.Datos
{
    class BaseDeDatos
    {

        public static SqlConnection conexion = Conexiones.AbrirConexion(); 

        public static SqlCommand nuevoQuery(string query)
        {
            return new SqlCommand(query, conexion);
        }

        public void ventanaErrorBD(Exception excepcion)
        {

            MessageBox.Show("Database error:\n" + excepcion.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ejecutarConsulta(string query)
        {
            SqlCommand consulta = nuevoQuery(query);
            try
            {
                Conexiones.AbrirConexion();
                consulta.ExecuteNonQuery();
            }
            catch (Exception excepcion)
            {
                ventanaErrorBD(excepcion);
            }
            Conexiones.CerrarConexion();
        }

        public DataSet obtenerDataSet(SqlCommand consulta)
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(consulta);
            dataAdapter.Fill(dataSet);
            return dataSet;
        }

        public DataTable obtenerDataTable(SqlCommand consulta)
        {
            DataTable tabla = obtenerDataSet(consulta).Tables[0];
            return tabla;
        }


    }

    class InfoUsuario
    {
        public static String nombreUsuario;
        public static int rolUsuario;
        public static DataTable dt = new DataTable();
        public static Dictionary<string, string> datosCuenta = new Dictionary<string, string>();

        public static void Actualizar(String usuario)
        {
            cargarDatosUsuario(usuario);
            if(rolUsuario>2)
                rellenarInformacion();
        }

        private static void rellenarInformacion()
        {
            dt.Columns.Clear();
            dt.Rows.Clear();
            SqlConnection conexion = Conexiones.AbrirConexion();
            SqlCommand command;
            SqlDataAdapter adapter;
            switch(rolUsuario)
            {
                case 3:
                    command = new SqlCommand("SELECT [cliente_id],[usuario_id],[nombre],[apellido],[dni],[mail]," +
                        "[telefono],[domicilio],[localidad],[codigo_postal],[fecha_nac],[credito],[baja_logica]" +
                        " FROM NUNCA_INJOIN.Cliente WHERE usuario_id LIKE '" + nombreUsuario + "'", conexion);
                    adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                    break;
                case 4:
                    command = new SqlCommand("SELECT [proveedor_id],[rubro_id],[usuario_id],[razon_social],"
                        + "[mail],[telefono],[domicilio],[localidad],[ciudad],[codigo_postal],[cuit],[nombre_contacto],"
                        + "[baja_logica] FROM NUNCA_INJOIN.Proveedor WHERE usuario_id LIKE '" + nombreUsuario+ "'", conexion);
                    adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                    break;
            }

            Conexiones.CerrarConexion();
            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn column in dt.Columns)
                {
                    datosCuenta.Add(column.ColumnName.ToString(), row[column].ToString());
                }
            }

        }

        private static void cargarDatosUsuario(String usuario)
        {
            dt.Columns.Clear();
            dt.Rows.Clear();
            SqlConnection conexion = Conexiones.AbrirConexion();
            SqlCommand command = new SqlCommand("SELECT usuario_id, rol_id FROM NUNCA_INJOIN.Usuario where usuario_id LIKE '" + usuario + "'", conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            Conexiones.CerrarConexion();
            DataRow columna = dt.Rows[0];
            nombreUsuario = columna["usuario_id"].ToString();
            rolUsuario = Int32.Parse(columna["rol_id"].ToString());
        }
        public static void Clear()
        {
            nombreUsuario=null;
            rolUsuario = 3;
        }
    }
}
