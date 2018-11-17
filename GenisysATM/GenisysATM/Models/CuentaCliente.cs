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
    class CuentaCliente
    {
        // Propiedades
        public string numero { get; set; }
        public int idCliente { get; set; }
        public decimal saldo { get; set; }
        public string pin { get; set; }

        // Constructores
        public CuentaCliente() { }

        // Métodos
        /// <summary>
        /// Obtiene la información de una cuenta para un cliente.
        /// </summary>
        /// <param name="cuenta">El número de cuenta del cliente</param>
        /// <returns>CuentaCliente el objeto que contiene la información de la cuenta del cliente</returns>
        public static CuentaCliente ObtenerCliente(string cuenta)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");
            CuentaCliente laCuenta = new CuentaCliente();
            string sql = @"SELECT *
                           FROM ATM.CuentaCliente
                           WHERE numero = @cuenta";

            SqlCommand cmd = conn.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@cuenta", SqlDbType.Char, 14).Value = cuenta;

                    rdr = cmd.ExecuteReader();
                }

                while (rdr.Read())
                {
                    laCuenta.numero = rdr.GetString(0);
                    laCuenta.idCliente = Convert.ToInt16(rdr["idCliente"]);
                    laCuenta.saldo = rdr.GetDecimal(2);
                    laCuenta.pin = rdr.GetString(3);

                    // Remover los espacios en blanco al final del los campos CHAR (hotfix101)
                    laCuenta.numero = laCuenta.numero.TrimEnd();
                }

                return laCuenta;
            }
            catch (SqlException ex)
            {
                return laCuenta;
            }
            finally
            {
                conn.CerrarConexion();
            }
        }

        /// <summary>
        /// Actualiza el saldo en la cuenta de un cliente. Dicha actualización
        /// solamente toma en cuenta débitos.
        /// </summary>
        /// <param name="cuenta">el número de cuenta del cliente</param>
        /// <param name="debito">el valor a ser debitado del saldo de la cuenta</param>
        /// <returns>true si el débidto pudo ser realizado. false en caso contrario.</returns>
        public static bool ActualizarSaldo(string cuenta, decimal debito)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");
            CuentaCliente laCuenta = CuentaCliente.ObtenerCliente(cuenta);

            SqlCommand cmd = conn.EjecutarComando("sp_ActualizarSaldoCuenta");

            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros
            cmd.Parameters.Add(new SqlParameter("cuenta", SqlDbType.Char, 14));
            cmd.Parameters.Add(new SqlParameter("debito", SqlDbType.Decimal));
            cmd.Parameters["cuenta"].Value = laCuenta.numero;
            cmd.Parameters["debito"].Value = debito;

            try
            {
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException ex)
            {
                return false;
            }
            finally
            {
                conn.CerrarConexion();
            }
        }

        /// <summary>
        /// Actualiza el valor del PIN para la cuenta de un cliente.
        /// </summary>
        /// <param name="laCuenta">número de cuenta del cliente</param>
        /// <param name="pinNuevo">el nuevo valor para el PIN</param>
        /// <returns>true si se actualiza el PIN. false en caso contrario.</returns>
        public static bool ActualizarPin(CuentaCliente laCuenta, string pinNuevo)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");

            SqlCommand cmd = conn.EjecutarComando("sp_ActualizarPin");
            cmd.Parameters.Add(new SqlParameter("cuenta", SqlDbType.Char, 14));
            cmd.Parameters.Add(new SqlParameter("pinActual", SqlDbType.Char, 4));
            cmd.Parameters.Add(new SqlParameter("pinNuevo", SqlDbType.Char, 4));

            cmd.Parameters["cuenta"].Value = laCuenta.numero;
            cmd.Parameters["pinActual"].Value = laCuenta.pin;
            cmd.Parameters["pinNuevo"].Value = pinNuevo;

            try
            {
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException ex)
            {
                return false;
            }
            finally
            {
                conn.CerrarConexion();
            }
        }


        /// <summary>
        /// Funcion quq agrega una nueva cuenta del cliente
        /// </summary>
        /// <param name="numero"> numero de cuenta del cliente (caracter 14)</param>
        /// <param name="idCliente"> clave primaria del cliente (entero)</param>
        /// <param name="saldo"> cantidad de dinero en la cuenta (decimal)</param>
        /// <param name="pin"> codigo de la cuenta (caracter 4)</param>
        /// <returns> Retorna agregando una nueva cuenta</returns>
        public static CuentaCliente InsertarCuentaCliente(char numero, int idCliente, decimal saldo, char pin)
        {
            // Crear la conexion
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");

            // Variable para el query
            string sql;

            // Variable globlal
            CuentaCliente insertar = new CuentaCliente();

            // Query Insert
            sql = @"INSERT INTO ATM.CuentaCliente(numero, idCliente, saldo, pin) VALUES (@Numero, @IDCliente, @Saldo, @Pin)";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    // Valores de los campos
                    cmd.Parameters.Add("@Numero", SqlDbType.Char, 14).Value = numero;
                    cmd.Parameters.Add("@IDCliente", SqlDbType.Int).Value = idCliente;
                    cmd.Parameters.Add("@Saldo", SqlDbType.Decimal).Value = saldo;
                    cmd.Parameters.Add("@Pin", SqlDbType.Char, 4).Value = pin;
         

                    // Ejecutar comando
                    rdr = cmd.ExecuteReader();


                }
                while (rdr.Read())
                {

                    // Leer todos los campos
                    insertar.numero= rdr.GetString(0);
                    insertar.idCliente = rdr.GetInt16(1);
                    insertar.saldo = rdr.GetDecimal(2);
                    insertar.pin = rdr.GetString(3);
                  


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
        ///  Funcion que elimina una cuenta de un cliente
        /// </summary>
        /// <param name="numeroCuenta"> numero de la cuenta del cliete (caracter 14)</param>
        /// <returns> Retorna eliminado una cuenta de la base de datos</returns>

        public static bool EliminarCliente(char numeroCuenta)
        {
            // Crear la conexion
            Conexion conectar = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");


            // Store Procedure
            SqlCommand cmd = conectar.EjecutarComando("sp_EliminarCuentaCliente");

            // Establecer el comando del Store Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parametros
            cmd.Parameters.Add(new SqlParameter("numero", SqlDbType.Char, 14));
            cmd.Parameters["numero"].Value = numeroCuenta;

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

    }
}
