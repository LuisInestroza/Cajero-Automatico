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
    class Cliente
    {
        // Propiedades
        public int id { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string identidad { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string celular { get; set; }

        // Métodos
        /// <summary>
        /// Obtiene un cliente desde la tabla ATM.Cliente
        /// </summary>
        /// <param name="identidad">La identidad del cliente (13 caracteres)</param>
        /// <returns>Un objeto de tipo Cliente.</returns>
        public static Cliente ObtenerCliente(string identidad)
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");
            string sql;
            Cliente resultado = new Cliente();

            // Query SQL
            sql = @"SELECT *
                    FROM ATM.Cliente
                    WHERE identidad = @identidad";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@identidad", SqlDbType.Char, 13).Value = identidad;

                    rdr = cmd.ExecuteReader();
                }

                while (rdr.Read())
                {
                    resultado.id = rdr.GetInt16(0);
                    resultado.nombres = rdr.GetString(1);
                    resultado.apellidos = rdr.GetString(2);
                    resultado.identidad = rdr.GetString(3);
                    resultado.direccion = rdr.GetString(4);
                    resultado.telefono = rdr.GetString(5);
                    resultado.celular = rdr.GetString(6);

                    // Remover espacios
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
        /// Agrega un nuevo cliente a la table ATM.Cliente
        /// </summary>
        /// <param name="nombre">nombre del cliente (100 caracteres)</param>
        /// <param name="apellido">apellido del cliente (100 caracteres)</param>
        /// <param name="identidad">identidad del cliente (13 caracteres)</param>
        /// <param name="direccion">direccion del cliente (100 caracteres)</param>
        /// <param name="telefono">telefono del cliente (9 caracteres)</param>
        /// <param name="celular">celular del cliente (9 caracteres)</param>
        /// <returns>Retorna un cliente agregado </returns>
        public static Cliente InsertarCliente(string nombre, string apellido, char identidad, string direccion, char telefono, char celular)
        {
            // Crear la conexion
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");

            // Variable para el query
            string sql;

            // Variable globlal
            Cliente insertar = new Cliente();

            // Query Insert
            sql = @"INSERT INTO ATM.Cliente (nombres, apellidos, identidad, direccion, telefono, celular) VALUES (@Nombre, @Apellido, @Identidad, @Direccion, @Telefono, @Celular)";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    // Valores de los campos
                    cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar, 100).Value = nombre;
                    cmd.Parameters.Add("@Apellido", SqlDbType.NVarChar, 100).Value = apellido;
                    cmd.Parameters.Add("@Identidad", SqlDbType.Char, 13).Value = identidad;
                    cmd.Parameters.Add("@Direccion", SqlDbType.NVarChar, 100).Value = direccion;
                    cmd.Parameters.Add("Telefono", SqlDbType.Char, 9).Value = telefono;
                    cmd.Parameters.Add("@Celular", SqlDbType.Char, 9).Value = celular;

                    // Ejecutar comando
                    rdr = cmd.ExecuteReader();


                }
                while (rdr.Read())
                {

                    // Leer todos los campos
                    insertar.id = rdr.GetInt16(0);
                    insertar.nombres = rdr.GetString(1);
                    insertar.apellidos = rdr.GetString(2);
                    insertar.identidad = rdr.GetString(3);
                    insertar.direccion = rdr.GetString(4);
                    insertar.telefono = rdr.GetString(5);
                    insertar.celular = rdr.GetString(6);


                }
                
                return insertar;
            }
            catch(SqlException exe)
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
        /// Eliminar un cliente de la table ATM.Clientes
        /// </summary>
        /// <param name="identidad">identidad del cliente (13 caracteres)9</param>
        /// <returns>Retorna eliminado un cliente</returns>

        public static bool  EliminarCliente(string identidad)
        {
            // Crear la conexion
            Conexion conectar = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");

     
            // Store Procedure
            SqlCommand cmd = conectar.EjecutarComando("sp_EliminarCliente");

            // Establecer el comando del Store Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parametros
            cmd.Parameters.Add(new SqlParameter("identidad", SqlDbType.Char, 13));
            cmd.Parameters["identidad"].Value = identidad;

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
        /// Actualizar los datos de un cliente 
        /// </summary>
        /// <param name="id">id de la llavve primaria (entero)</param>
        /// <param name="nombre"> nombre del cliente (100 caracteres)</param>
        /// <param name="apellido"> apaellido del cliente (100 caracteres)</param>
        /// <param name="identidad"> identidad del cliente (13 caracteres)</param>
        /// <param name="direccion"> direccion del cliente (100 caracteres)</param>
        /// <param name="telefono"> telefono del cliente (9 caracteres)</param>
        /// <param name="celular"> celular del cliente (9 caracteres)</param>
        /// <returns>Retorna la actulizacion de los datos de un cliente</returns>

        public static bool ActualizarCliente(int id, string nombre, string apellido, char identidad, string direccion, char telefono, char celular)
        {
            // crear la conexion
            Conexion conectar = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");

            // Store Procedure
            SqlCommand cmd = conectar.EjecutarComando("sp_ActualizarClienta");

            // Establecer el comando del Store Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Valores de los campos
            cmd.Parameters.Add(new SqlParameter("id", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("nombre", SqlDbType.NVarChar, 100));
            cmd.Parameters.Add(new SqlParameter("apellido", SqlDbType.Char, 13));
            cmd.Parameters.Add(new SqlParameter("identidad", SqlDbType.Char, 4));
            cmd.Parameters.Add(new SqlParameter("direccion", SqlDbType.NVarChar, 100));
            cmd.Parameters.Add(new SqlParameter("telefono", SqlDbType.Char, 9));
            cmd.Parameters.Add(new SqlParameter("celular", SqlDbType.Char, 9));

            // Remplazar los valores
            cmd.Parameters["id"].Value = id;
            cmd.Parameters["nombre"].Value = nombre;
            cmd.Parameters["apellido"].Value = apellido;
            cmd.Parameters["identidad"].Value = identidad;
            cmd.Parameters["direccion"].Value = direccion;
            cmd.Parameters["telefono"].Value = telefono;
            cmd.Parameters["celular"].Value = celular;




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
