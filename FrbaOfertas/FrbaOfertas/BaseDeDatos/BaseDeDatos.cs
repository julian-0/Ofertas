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

        public static void Actualizar(String usuario)
        {
            dt.Columns.Clear();
            dt.Rows.Clear();
            SqlConnection conexion = Conexiones.AbrirConexion();
            SqlCommand command = new SqlCommand("SELECT usuario_id, rol_id FROM NUNCA_INJOIN.Usuario where usuario_id LIKE '"+usuario+"'", conexion);
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
