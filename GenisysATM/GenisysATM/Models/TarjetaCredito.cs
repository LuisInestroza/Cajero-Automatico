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
    class TarjetaCredito
    {
        // Propiedades
        public int id { get; set; }
        public string descripcion { get; set; }
        public decimal monto { get; set; }
        public decimal limite { get; set; }
        public int idCliente { get; set; }


        /// <summary>
        /// Mostrar todas las tarjetas registradas
        /// </summary>
        /// <param name="idCliente"> campo primario de la tabla Cliente (entero)9</param>
        /// <returns>Retorna mostrando las tajetas de credito registras</returns>
        public static TarjetaCredito ObtenerTarjeta(int idCliente)
        {
            // Crear la conexion
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");
            
            // Variable sql para el comando
            string sql;

            //
            TarjetaCredito resultado = new TarjetaCredito();

            // Query SQL
            sql = @"SELECT *FROM ATM.TarjetaCredito WHERE idClientes = @identidad";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    // Parametros de los campos
                    cmd.Parameters.Add("@identidad", SqlDbType.Int).Value = idCliente;

                    rdr = cmd.ExecuteReader();
                }

                while (rdr.Read())
                {
                    // Leer los campos
                    resultado.id = rdr.GetInt16(0);
                    resultado.descripcion = rdr.GetString(1);
                    resultado.monto = rdr.GetDecimal(2);
                    resultado.limite = rdr.GetDecimal(3);
                    resultado.idCliente = rdr.GetInt16(4);
             
             
                }

                return resultado;
            }
            catch (SqlException ex)
            {
                return resultado;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }


        /// <summary>
        /// Agrega una nueva tarjeta de credito 
        /// </summary>
        /// <param name="descripcion"> descripcion de la tarje (100 caracteres)9</param>
        /// <param name="monto"> cantidad de dinero depositado en la tarjeta (decimal)</param>
        /// <param name="limite"> limite de dinero que puede tener la tarjeta (deciamal)</param>
        /// <param name="idCliente">campo primario de la tabla Cliente (entero) </param>
        /// <returns> Retorna agregando una nueva tarjeta de credito</returns>

        public static TarjetaCredito InsertarTarjeta(string descripcion, decimal monto, decimal limite, int idCliente)
        {
            // Crear la conexion
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");

            // Variable para el query
            string sql;

            // Variable globlal
            TarjetaCredito insertar = new TarjetaCredito();

            // Query Insert
            sql = @"INSERT INTO ATM.TarjetaCredito (descripcion, monto, limites, idCliente) VALUES (@Descripcion, @Monto, @Limite, @IDCliente)";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    // Valores de los campos
                    cmd.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 100).Value = descripcion;
                    cmd.Parameters.Add("@Monto", SqlDbType.Decimal).Value = monto;
                    cmd.Parameters.Add("@Limite", SqlDbType.Decimal).Value = limite;
                    cmd.Parameters.Add("@IDCliente", SqlDbType.Int).Value = idCliente;

                    // Ejecutar comando
                    rdr = cmd.ExecuteReader();


                }
                while (rdr.Read())
                {

                    // Leer todos los campos
                    insertar.id = rdr.GetInt16(0);
                    insertar.descripcion = rdr.GetString(1);
                    insertar.monto = rdr.GetDecimal(2);
                    insertar.limite = rdr.GetDecimal(3);
                    insertar.idCliente = rdr.GetInt16(4);


                }

                return insertar;
            }
            catch (SqlException exe)
            {
                return insertar;
            }
            finally
            {
                // Cerrar coneccion
                conexion.CerrarConexion();
            }
        }

        /// <summary>
        /// Elimina una tarjeta de credito
        /// </summary>
        /// <param name="idCliente">campo primario de la tabla Cliente (entero)</param>
        /// <returns> Retorna eliminado una tarjeta de credito</returns>

        public static bool EliminarTarjetaCredito(int idCliente)
        {
            // Crear la conexion
            Conexion conectar = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");


            // Store Procedure
            SqlCommand cmd = conectar.EjecutarComando("sp_EliminarTarjetaCredito");

            // Establecer el comando del Store Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parametros
            cmd.Parameters.Add(new SqlParameter("idCliente", SqlDbType.Int));
            cmd.Parameters["idCliente"].Value = idCliente;

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
        /// Actualiza una tarjeta de credito 
        /// </summary>
        /// <param name="descripcion"> descripcion de la tarje (100 caracteres)9</param>
        /// <param name="monto"> cantidad de dinero depositado en la tarjeta (decimal)</param>
        /// <param name="limite"> limite de dinero que puede tener la tarjeta (deciamal)</param>
        /// <param name="idCliente">campo primario de la tabla Cliente (entero) </param>
        /// <returns> Retorna actualizando una nueva tarjeta de credito</returns>

        public static bool ActualizarTarjeta(int id, string descripcion, decimal monto, decimal limite, int idCliente)
        {
            // crear la conexion
            Conexion conectar = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");

            // Store Procedure
            SqlCommand cmd = conectar.EjecutarComando("sp_ActualizarTarjetaCredito");

            // Establecer el comando del Store Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Valores de los campos
            cmd.Parameters.Add(new SqlParameter("id", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("descripcion", SqlDbType.NVarChar, 100));
            cmd.Parameters.Add(new SqlParameter("monto", SqlDbType.Decimal));
            cmd.Parameters.Add(new SqlParameter("limite", SqlDbType.Decimal));
            cmd.Parameters.Add(new SqlParameter("idCliente", SqlDbType.Int));
 

            // Remplazar los valores
            cmd.Parameters["id"].Value = id;
            cmd.Parameters["descripcion"].Value = descripcion;
            cmd.Parameters["monto"].Value = monto;
            cmd.Parameters["limite"].Value = limite;
            cmd.Parameters["idCliente"].Value = idCliente;
         

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
