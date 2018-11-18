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
    class ServicioPublico
    {
        // Propiedades
        public int id { get; set; }
        public string descripcion { get; set; }

        // Constructores
        public ServicioPublico() { }

        /// <summary>
        /// Funcion que se encarga de buscar los servicios publicos
        /// </summary>
        /// <param name="id"> clave primaria (entero)</param>
        /// <param name="descripcion"> descripcion del servicio publico </param>
        /// <returns> Retorna listando todos los servicio de la base de datos </returns>
        public static ServicioPublico buscarServicioPublico(int id, string descripcion)
        {
            //  Realizar conexion
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");

            // Variable del Qery
            string sql;
            ServicioPublico buscar = new ServicioPublico();

            // Query SQL
            sql = @"SELECT * FROM ATM.ServicioPublico";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    // Valores de los campos
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cmd.Parameters.Add("@descripcion", SqlDbType.NVarChar, 100).Value = descripcion;

                    // Ejecutar comando
                    rdr = cmd.ExecuteReader();
                }

                while (rdr.Read())
                {
                    buscar.id = rdr.GetInt16(0);
                    buscar.descripcion = rdr.GetString(1);
               
                }

                return buscar;
            }
            catch (SqlException ex)
            {
                return buscar;
            }
            finally
            {
                // Cerrar conexion
                conexion.CerrarConexion();
            }
        }

        /// <summary>
        /// Funcion que se encarga de agregar los servicios publicos
        /// </summary>
        /// <param name="descripcion"> descripcion del servicio publico </param>
        /// <returns> Retorna agregando un nuevo servicio de la base de datos </returns>
        public static ServicioPublico InsertarServicioPublico(string descripcion)
        {
            // Crear la conexion
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");

            // Variable para el query
            string sql;

            // Variable globlal
            ServicioPublico insertarServicio = new ServicioPublico();

            // Query Insert
            sql = @"INSERT INTO ATM.ServicioPublico (descripcion) VALUES (@Descripcion)";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    // Valores de los campos
                    cmd.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 100).Value = descripcion;
                 
                    // Ejecutar comando
                    rdr = cmd.ExecuteReader();

                }
                while (rdr.Read())
                {

                    // Leer todos los campos
                    insertarServicio.id = rdr.GetInt16(0);
                    insertarServicio.descripcion= rdr.GetString(1);
                  
                }

                return insertarServicio;
            }
            catch (SqlException exe)
            {
                return insertarServicio;
            }
            finally
            {
                // Cerrar coneccion
                conexion.CerrarConexion();
            }
        }


        /// <summary>
        /// Funcion que se encarga de eliminar los servicios publicos
        /// </summary>
        /// <param name="id"> clave primaria (entero)</param>
        /// <returns> Retorna eliminado servicio de la base de datos </returns>
        public static bool EliminarServicioPublico(int id)
        {
            // Crear la conexion
            Conexion conectar = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");


            // Store Procedure
            SqlCommand cmd = conectar.EjecutarComando("sp_EliminarServicioPublico");

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
        /// Funcion que se encarga de actulizar los servicios publicos
        /// </summary>
        /// <param name="id"> clave primaria (entero)</param>
        /// <param name="descripcion"> descripcion del servicio publico </param>
        /// <returns> Retorna actualizando todos los servicio de la base de datos </returns>
        public static bool ActualizarServicioPublico(int id, string descripcion)
        {
            // crear la conexion
            Conexion conectar = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");

            // Store Procedure
            SqlCommand cmd = conectar.EjecutarComando("sp_ActualizarServicioPublico");

            // Establecer el comando del Store Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Valores de los campos
            cmd.Parameters.Add(new SqlParameter("id", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("descripcion", SqlDbType.NVarChar, 100));
    

            // Remplazar los valores
            cmd.Parameters["id"].Value = id;
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
