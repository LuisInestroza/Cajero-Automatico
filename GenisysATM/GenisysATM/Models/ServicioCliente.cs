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
    class ServicioCliente
    {
        // Propiedades
        public int id { get; set; }
        public int idCliente { get; set; }
        public int idServicio { get; set; }
        public decimal saldo { get; set; }

        // Constructores
        public ServicioCliente() { }

        // Métodos


        /// <summary>
        /// Funcion que lista todos los servicios del cliente
        /// </summary>
        /// <param name="id"> clave primaria (entero)</param>
        /// <returns>Retorna listando todos los servicios del cliente</returns>
        public bool  ObtenerServicioCliente(int id)
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");
            string sql;
            ServicioCliente resultado = new ServicioCliente();

            // Query SQL
            sql = @"SELECT * FROM ATM.Cliente WHERE id = @id";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    rdr = cmd.ExecuteReader();
                }

                while (rdr.Read())
                {
                    resultado.id = rdr.GetInt16(0);
                    resultado.idCliente = rdr.GetInt16(1);
                    resultado.idServicio = rdr.GetInt16(2);
                    resultado.saldo = rdr.GetDecimal(3);
                  
                    // Remover espacios
                }

                return true;
            }
            catch (SqlException ex)
            {
                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        /// <summary>
        /// Funcion que agrega un nuevo servicio del cliente
        /// </summary>
        /// <param name="idCliente">id del cliente (entero)</param>
        /// <param name="idServicio">id del servicio (entero)</param>
        /// <param name="saldo"> saldo del servicio (entero)</param>
        /// <returns>Retorna agregando un nuevo servicio del cliente </returns>
     
        public bool InsertarServicioCliente(int idCliente, int idServicio, decimal saldo)
        {
            // Crear la conexion
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");

            // Variable para el query
            string sql;

            // Variable globlal
            ServicioCliente insertar = new ServicioCliente();

            // Query Insert
            sql = @"INSERT INTO ATM.ServicioCliente (idCliente, idServicio, saldo) VALUES (@IDCliente,  @IDServicio, @Saldo)";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    // Valores de los campos
                    cmd.Parameters.Add("@IDCliente", SqlDbType.Int).Value = idCliente;
                    cmd.Parameters.Add("@IDServicio", SqlDbType.Int).Value = idServicio;
                    cmd.Parameters.Add("@Saldo", SqlDbType.Decimal).Value = saldo;
     
                    // Ejecutar comando
                    rdr = cmd.ExecuteReader();


                }
                while (rdr.Read())
                {

                    // Leer todos los campos
                    insertar.id = rdr.GetInt16(0);
                    insertar.idCliente = rdr.GetInt16(1);
                    insertar.idServicio = rdr.GetInt16(2);
                    insertar.saldo = rdr.GetDecimal(3);
                   

                }

                return true;
            }
            catch (SqlException exe)
            {
                return false;
            }
            finally
            {
                // Cerrar coneccion
                conexion.CerrarConexion();
            }
        }


        /// <summary>
        /// Funcion que elimina un servicio del cliente
        /// </summary>
        /// <param name="id"> clave primaria (entero)</param>
        /// <returns>Retorna eliminado un  servicio del cliente</returns>
        public  bool EliminarServicioCliente(int id)
        {
            // Crear la conexion
            Conexion conectar = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");


            // Store Procedure
            SqlCommand cmd = conectar.EjecutarComando("sp_EliminarServicioCliente");

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
        /// Funcion que actuliza un servicio del cliente
        /// </summary>
        /// <param name="id"> clave primaria (entero)</param>
        /// <param name="idCliente">id del cliente (entero)</param>
        /// <param name="idServicio">id del servicio (entero)</param>
        /// <param name="saldo"> saldo del servicio (entero)</param>
        /// <returns>Retorna actualizando un servicio del cliente </returns>
        public  bool ActualizarSercicioCliente(int id, int idCliente, int idServicio, decimal saldo)
        {
            // crear la conexion
            Conexion conectar = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");

            // Store Procedure
            SqlCommand cmd = conectar.EjecutarComando("sp_ActualizarServicioCliente");

            // Establecer el comando del Store Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Valores de los campos
            cmd.Parameters.Add(new SqlParameter("id", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("idCliente", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("idServicio", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("saldo", SqlDbType.Decimal));



            // Remplazar los valores
            cmd.Parameters["id"].Value = id;
            cmd.Parameters["idCliente"].Value = idCliente;
            cmd.Parameters["idServicio"].Value = idServicio;
            cmd.Parameters["saldo"].Value = saldo;
      
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
