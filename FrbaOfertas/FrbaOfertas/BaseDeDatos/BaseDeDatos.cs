using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using FrbaOfertas.Conexion;
using System.Windows.Forms;
using System.Globalization;
using System.Data;

namespace FrbaOfertas.Datos
{
    class BaseDeDatos
    {

        public static void ventanaErrorBD(Exception excepcion)
        {

            MessageBox.Show("Database error:\n" + excepcion.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DateTime fechaConfig
        {
            get { return DateTime.Parse(System.Configuration.ConfigurationSettings.AppSettings["fechaConfig"]); }
        }

        public static String fechaConfigString
        {
            get { return fechaConfig.ToString("d", CultureInfo.CreateSpecificCulture("es-ES")); }
        }

        public static void ejecutarConsulta(string query)
        {
            
            try
            {
                SqlConnection conexion = Conexiones.AbrirConexion();
                SqlCommand consulta = new SqlCommand(query, conexion);
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

        public static DataTable solicitar(String query){
            DataTable dt = new DataTable();
            SqlConnection conexion = Conexiones.AbrirConexion();
            SqlCommand command;
            SqlDataAdapter adapter;

            command = new SqlCommand(query, conexion);
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            Conexiones.CerrarConexion();
            return dt;
        }

        public static DataTable getUsuarios()
        {
            return solicitar(String.Format("SELECT * FROM NUNCA_INJOIN.ClientesActualizados({0})", fechaConfigString));
        }

        public static DataTable getRoles()
        {
            return solicitar("SELECT rol_id, nombre_rol, baja_logica FROM NUNCA_INJOIN.Rol");
        }
        
        public static DataTable getAniosFacturas()
        {
            return solicitar("SELECT distinct year(fecha) as Anio FROM NUNCA_INJOIN.FacturaProveedor");
        }

        public static DataTable getAniosOfertas()
        {
            return solicitar("SELECT distinct year(fecha_publicacion) as Anio FROM NUNCA_INJOIN.Oferta");
        }

        public static DataTable getFuncionalidadesRol(String rol_id)
        {

            return solicitar("SELECT funcionalidad_id FROM NUNCA_INJOIN.FuncionalidadPorRol " +
            "WHERE rol_id = " + rol_id);
        }

        public static DataTable getFuncionalidadesRestantes(String rol_id)
        {
            return solicitar("SELECT funcionalidad_id FROM NUNCA_INJOIN.Funcionalidad WHERE funcionalidad_id not in" +
            "(SELECT funcionalidad_id FROM NUNCA_INJOIN.FuncionalidadPorRol where rol_id = " + rol_id + ")");
        }

        public static DataTable getTopFacturas(String anio, String semestre)
        {
            return solicitar("SELECT * FROM NUNCA_INJOIN.topFacturacion('" + anio + "','" + semestre + "')");
        }

        public static DataTable getTopDescuentos(String anio, String semestre)
        {
            return solicitar("SELECT * FROM NUNCA_INJOIN.topDescuentos('" + anio + "','" + semestre + "')");
        }

        internal static DataTable getOfertasProveedor(String desde, String hasta, String prov)
        {
            return solicitar("SELECT * FROM NUNCA_INJOIN.ofertasAFacturar('" + desde + "','" + hasta + "','" + prov + "','" + fechaConfigString + "')");
        }

        public static void cambiarEstadoProveedor(String proveedor_id)
        {
            SqlConnection conexion = Conexiones.AbrirConexion();
            SqlCommand procedure = new SqlCommand("NUNCA_INJOIN.cambiarEstadoProveedor", conexion);
            procedure.CommandType = CommandType.StoredProcedure;
            procedure.Parameters.AddWithValue("@proveedor_id", SqlDbType.Int).Value = Int32.Parse(proveedor_id);
            procedure.ExecuteNonQuery();
            Conexiones.CerrarConexion();
        }
    }

    class InfoUsuario
    {
        public static String nombreUsuario;
        public static int rolUsuario;
        public static DataTable dt = new DataTable();
        public static Dictionary<string, string> datosCuenta = new Dictionary<string, string>();

        public static void Actualizar()
        {
            if (rolUsuario > 2)
                rellenarInformacion();
        }

        public static void Completar(String usuario)
        {
            cargarDatosUsuario(usuario);
            Actualizar();
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
                    command = new SqlCommand("SELECT [cliente_id] as ID,[usuario_id] as Usuario,[nombre],[apellido],[dni],[mail]," +
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
            datosCuenta.Clear();
        }
    }
}
