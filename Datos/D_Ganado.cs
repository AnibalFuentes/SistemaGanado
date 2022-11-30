using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System;
using Entidad;

namespace Datos
{
    public class D_Ganado
    {
        public List<Ganado> ListarGanados()
        {
            List<Ganado> Ganados = new List<Ganado>();

            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT [IdGanado],[Raza],[Sexo],[Peso],[PesoVenta],[MesesRecuperacion],");
                    query.AppendLine("[PrecioCompra],[PrecioVenta],[Estado],[Referencia] FROM [Ganado]");
                    SqlCommand command = new SqlCommand(query.ToString(), connection)
                    {
                        CommandType = CommandType.Text
                    };

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Ganados.Add(new Ganado()
                            {
                                IdGanado = Convert.ToInt32(reader["IdGanado"]),
                                Raza = reader["Raza"].ToString(),
                                Sexo = (reader["Sexo"].ToString()),
                                Peso = Convert.ToDecimal(reader["Peso"].ToString()),
                                PesoVenta = Convert.ToDecimal(reader["PesoVenta"].ToString()),
                                MesesRecuperacion = Convert.ToInt16(reader["MesesRecuperacion"].ToString()),
                                PrecioCompra = Convert.ToDecimal(reader["PrecioCompra"].ToString()),
                                PrecioVenta = Convert.ToDecimal(reader["PrecioVenta"].ToString()),
                                Referencia = reader["Referencia"].ToString(),
                                Estado = Convert.ToBoolean(reader["Estado"]),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Ganados = new List<Ganado>();
                    connection.Close();
                    throw ex;
                }
            }
            return Ganados;
        }

        public int RegistrarGanado(Ganado Ganado, out string mensaje)
        {
            int IdGanadoResultado = 0;
            mensaje = string.Empty;

            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("InsertarGanado", connection);
                    cmd.Parameters.AddWithValue("@Referencia", Ganado.Referencia);
                    cmd.Parameters.AddWithValue("@Raza", Ganado.Raza);
                    cmd.Parameters.AddWithValue("@Sexo", Ganado.Sexo);
                    cmd.Parameters.AddWithValue("@Peso", Ganado.Peso);
                    cmd.Parameters.AddWithValue("@PesoVenta", Ganado.PesoVenta);
                    cmd.Parameters.AddWithValue("@MesesRecuperacion", Ganado.MesesRecuperacion);
                    cmd.Parameters.AddWithValue("@PrecioCompra", Ganado.PrecioCompra);
                    cmd.Parameters.AddWithValue("@PrecioVenta", Ganado.PrecioVenta);
                    cmd.Parameters.AddWithValue("@Estado", Ganado.Estado);
                    cmd.Parameters.AddWithValue("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    cmd.ExecuteNonQuery();

                    IdGanadoResultado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
                catch (Exception ex)
                {
                    IdGanadoResultado = 0;
                    connection.Close();
                    mensaje = ex.Message;
                }
            }
            return IdGanadoResultado;
        }

        public bool EditarGanado(Ganado Ganado, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;

            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("EditarGanado", connection);
                    cmd.Parameters.AddWithValue("@IdGanado", Ganado.IdGanado);
                    cmd.Parameters.AddWithValue("@Referencia", Ganado.Referencia);
                    cmd.Parameters.AddWithValue("@Raza", Ganado.Raza);
                    cmd.Parameters.AddWithValue("@Sexo", Ganado.Sexo);
                    cmd.Parameters.AddWithValue("@Peso", Ganado.Peso);
                    cmd.Parameters.AddWithValue("@PesoVenta", Ganado.PesoVenta);
                    cmd.Parameters.AddWithValue("@MesesRecuperacion", Ganado.MesesRecuperacion);
                    cmd.Parameters.AddWithValue("@PrecioCompra", Ganado.PrecioCompra);
                    cmd.Parameters.AddWithValue("@PrecioVenta", Ganado.PrecioVenta);
                    cmd.Parameters.AddWithValue("@Estado", Ganado.Estado);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    cmd.ExecuteNonQuery();

                    resultado = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
                catch (Exception ex)
                {
                    connection.Close();
                    resultado = false;
                    mensaje = ex.Message;
                }
            }
            return resultado;
        }

        public bool EliminarGanado(Ganado Ganado, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("delete from Ganado where IdGanado = @IdGanado", connection);
                    cmd.Parameters.AddWithValue("@IdGanado", Ganado.IdGanado);
                    cmd.CommandType = CommandType.Text;
                    connection.Open();
                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception ex)
                {
                    connection.Close();
                    respuesta = false;
                    mensaje = ex.Message;
                }
            }
            return respuesta;
        }
    }
}
