using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Agregar los namespaces necesarios
using System.Data;
using System.Data.SqlClient;

namespace GenisysATM.Models
{
    class Configuracion
    {
        // Propiedades
        public int id { get; set; }
        public string appKey { get; set; }
        public string valor { get; set; }
        public string descripcion { get; set; }

        // Constructores
        public Configuracion() { }

        // Métodos

        /// <summary>
        /// Funcion que se encarga de listar todas las configuraciones
        /// </summary>
        /// <param name="key"> valor de key </param>
        /// <returns>Retorna listando todas las configuraciones</returns>
        public static string ObtenerConfiguracion(string key)
        {
            string valor = "";
            SqlDataReader rdr;
            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");
            SqlCommand cmd = conn.EjecutarComando(@"SELECT valor 
                                                    FROM ATM.Configuracion 
                                                    WHERE appKey = @key");

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@key", SqlDbType.NVarChar, 50).Value = key;

                    rdr = cmd.ExecuteReader();
                }

                while (rdr.Read())
                {
                    valor = rdr.GetString(0);
                }

                return valor;
            }
            catch (SqlException ex)
            {
                return "Clave no válida";
            }
            finally
            {
                conn.CerrarConexion();
            }
        }

        /// <summary>
        /// Funcion que agrega una nueva configracion
        /// </summary>
        /// <param name="appkey"> app del cajero (caracter 50)</param>
        /// <param name="valor"> valor del appkey (caracter 50)</param>
        /// <param name="descripcion"> descripcion de la configuracion(caracteres 200)</param>
        /// <returns>Retorna agregango una nueva configuracion</returns>
        public static Configuracion InsertarConfiguracion(char appkey, char valor, string descripcion)
        {
            // Crear la conexion
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");

            // Variable para el query
            string sql;

            // Variable globlal
            Configuracion insertarConfiguracion = new Configuracion();

            // Query Insert
            sql = @"INSERT INTO ATM.Configuracion(appkey, valor, descripcion) VALUES (@Appkey, @Valor, @Descripcion)";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    // Valores de los campos
                    cmd.Parameters.Add("@DAppkey", SqlDbType.NChar, 50).Value = appkey;
                    cmd.Parameters.Add("@Valor", SqlDbType.NChar, 50).Value = valor;
                    cmd.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 200).Value = descripcion;

                    // Ejecutar comando
                    rdr = cmd.ExecuteReader();

                }
                while (rdr.Read())
                {

                    // Leer todos los campos
                    insertarConfiguracion.id = rdr.GetInt16(0);
                    insertarConfiguracion.appKey = rdr.GetString(1);
                    insertarConfiguracion.valor = rdr.GetString(2);
                    insertarConfiguracion.descripcion = rdr.GetString(3);

                }

                return insertarConfiguracion;
            }
            catch (SqlException exe)
            {
                return insertarConfiguracion;
            }
            finally
            {
                // Cerrar coneccion
                conexion.CerrarConexion();
            }
        }


       /// <summary>
       /// Funcion que elimina una configuracion
       /// </summary>
       /// <param name="id"> valor de la llave primaria (entero)</param>
       /// <returns> Retorna eliminando una configuracion</returns>
        public static bool EliminarConfiguracion(int id)
        {
            // Crear la conexion
            Conexion conectar = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");


            // Store Procedure
            SqlCommand cmd = conectar.EjecutarComando("sp_EliminarConfiguracion");

            // Establecer el comando del Store Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parametros
            cmd.Parameters.Add(new SqlParameter("id", SqlDbType.Int));
            cmd.Parameters["id"].Value = id;

            try
            {

                // ejercutar comando
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException exe)
            {

                return false;
            }
            finally
            {
                // Cerrar conexion
                conectar.CerrarConexion();
            }

        }


        /// <summary>
        /// Funcion que actuliza una nueva configracion
        /// </summary>
        /// <param name="id"> valor primario (entero)</param>
        /// <param name="appkey"> app del cajero (caracter 50)</param>
        /// <param name="valor"> valor del appkey (caracter 50)</param>
        /// <param name="descripcion"> descripcion de la configuracion(caracteres 200)</param>
        /// <returns>Retorna actulizando una nueva configuracion</returns>
        public static bool ActualizarConfiguracion(int id, char appkey, char valor, string descripcion)
        {
            // crear la conexion
            Conexion conectar = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");

            // Store Procedure
            SqlCommand cmd = conectar.EjecutarComando("sp_ActualizarConfiguracion");

            // Establecer el comando del Store Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Valores de los campos
            cmd.Parameters.Add(new SqlParameter("id", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("appkey", SqlDbType.NChar, 50));
            cmd.Parameters.Add(new SqlParameter("valor", SqlDbType.NChar, 50));
            cmd.Parameters.Add(new SqlParameter("descripcion", SqlDbType.NVarChar, 200));


            // Remplazar los valores
            cmd.Parameters["id"].Value = id;
            cmd.Parameters["appkey"].Value = appkey;
            cmd.Parameters["valor"].Value = valor;
            cmd.Parameters["descripcion"].Value = descripcion;
            
            try
            {
                // Ejecuatar comando
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException ex)
            {
                return false;
            }
            finally
            {
                // Cerrar la conexion
                conectar.CerrarConexion();
            }
        }
    }
}
