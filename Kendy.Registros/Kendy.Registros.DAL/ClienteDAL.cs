using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Kendy.Registros.EN;
using System.Data;
using Kendy.Registros.DAL;

namespace Kendy.Registros.DAL

{
    public class ClienteDAL
    {
        public static int AgregarCliente(Cliente pCliente)
        {
            try
            {
                using (IDbConnection _connection = DBComun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("AgregarCliente", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Nombre", pCliente.Nombre);
                    _command.Parameters.AddWithValue("@Apellido", pCliente.Apellido);
                    _command.Parameters.AddWithValue("@Telefono", pCliente.Telefono);
                    _command.Parameters.AddWithValue("@CorreoElectronic", pCliente.CorreoElectronico);
                    _command.Parameters.AddWithValue("@Genero", pCliente.Genero);
                    _command.Parameters.AddWithValue("@DUI", pCliente.DUI);
                    _command.Parameters.AddWithValue("@NIT", pCliente.NIT);
                    _command.Parameters.AddWithValue("@ConsumidorFinal", pCliente.ConsumidorFinal);
                    _command.Parameters.AddWithValue("@SalonDeBelleza", pCliente.SalonDeBelleza);
                    _command.Parameters.AddWithValue("@NumeroDeCompras", pCliente.NumeroDeCompras);


                    int _resultado = _command.ExecuteNonQuery();

                    _connection.Close();

                    return _resultado;
                }
            }
            catch (NullReferenceException ex1)
            {
                throw;
            }
            catch (FormatException ex2)
            {
                throw;
            }
            catch (Exception ex3)
            {
                throw;
            }
        }




        //Modificar

        public static int ModificarCliente(Cliente pCliente)
        {
            try
            {
                using (IDbConnection _connection = DBComun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ModificarCliente", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Nombre", pCliente.Nombre);
                    _command.Parameters.AddWithValue("@Apellido", pCliente.Apellido);
                    _command.Parameters.AddWithValue("@Telefono", pCliente.Telefono);
                    _command.Parameters.AddWithValue("@CorreoElectronic", pCliente.CorreoElectronico);
                    _command.Parameters.AddWithValue("@Genero", pCliente.Genero);
                    _command.Parameters.AddWithValue("@DUI", pCliente.DUI);
                    _command.Parameters.AddWithValue("@NIT", pCliente.NIT);
                    _command.Parameters.AddWithValue("@ConsumidorFinal", pCliente.ConsumidorFinal);
                    _command.Parameters.AddWithValue("@SalonDeBelleza", pCliente.SalonDeBelleza);
                    _command.Parameters.AddWithValue("@NumeroDeCompras", pCliente.NumeroDeCompras);
                    _command.Parameters.AddWithValue("@Id", pCliente.Id);



                    int _resultado = _command.ExecuteNonQuery();

                    _connection.Close();

                    return _resultado;
                }
            }

            catch (IndexOutOfRangeException ex1)
            {
                throw;
            }
            catch (FormatException ex2)
            {
                throw;
            }
            catch (Exception ex3)
            {
                throw;
            }
        }

        //Eliminar

        public static int EliminarCliente(int pId)
        {
            try
            {
                using (IDbConnection _connection = DBComun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("EliminarCliente", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Id", pId);

                    int _resultado = _command.ExecuteNonQuery();

                    _connection.Close();

                    return _resultado;
                }
            }

            catch (IndexOutOfRangeException ex1)
            {
                throw;
            }
            catch (FormatException ex2)
            {
                throw;
            }
            catch (Exception ex3)
            {
                throw;
            }
        }

        //Buscar

        public static List<Cliente> ConsultarClientePorNombre(string pNombre)
        {
            try
            {
                using (IDbConnection _connection = DBComun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ConsultarClientePorNombre", _connection as SqlConnection);

                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Nombre", pNombre);

                    SqlDataReader _reader = _command.ExecuteReader();

                    List<Cliente> _listaCliente = new List<Cliente>();

                    while (_reader.Read())
                    {
                        Cliente _cliente = new Cliente();

                        _cliente.Id = _reader.GetInt32(0);
                        _cliente.Nombre = _reader.GetString(1);
                        _cliente.Apellido = _reader.GetString(2);
                        _cliente.Telefono = _reader.GetString(3);
                        _cliente.CorreoElectronico = _reader.GetString(4);
                        _cliente.Genero = _reader.GetString(5);
                        _cliente.DUI = _reader.GetString(6);
                        _cliente.NIT = _reader.GetString(7);
                        _cliente.ConsumidorFinal = _reader.GetString(8);
                        _cliente.SalonDeBelleza = _reader.GetString(9);
                        _cliente.NumeroDeCompras = _reader.GetInt32(10);

                        _listaCliente.Add(_cliente);

                    }

                    _reader.Close();

                    _connection.Close();

                    return _listaCliente;
                }
            }

            catch (IndexOutOfRangeException ex1)
            {
                throw;
            }
            catch (FormatException ex2)
            {
                throw;
            }
            catch (Exception ex3)
            {
                throw;
            }

        }

        public static List<Cliente> ConsultarClientePorNumeroDeCompras(int pNumeroDeCompras)
        {
            try
            {
                using (IDbConnection _connection = DBComun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ConsultarClientePorNumeroDeCompras", _connection as SqlConnection);

                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@NumeroDeCompras", pNumeroDeCompras);

                    SqlDataReader _reader = _command.ExecuteReader();

                    List<Cliente> _listaCliente = new List<Cliente>();

                    while (_reader.Read())
                    {
                        Cliente _cliente = new Cliente();

                        _cliente.Id = _reader.GetInt32(0);
                        _cliente.Nombre = _reader.GetString(1);
                        _cliente.Apellido = _reader.GetString(2);
                        _cliente.Telefono = _reader.GetString(3);
                        _cliente.CorreoElectronico = _reader.GetString(4);
                        _cliente.Genero = _reader.GetString(5);
                        _cliente.DUI = _reader.GetString(6);
                        _cliente.NIT = _reader.GetString(7);
                        _cliente.ConsumidorFinal = _reader.GetString(8);
                        _cliente.SalonDeBelleza = _reader.GetString(9);
                        _cliente.NumeroDeCompras = _reader.GetInt32(10);

                        _listaCliente.Add(_cliente);

                    }

                    _reader.Close();

                    _connection.Close();

                    return _listaCliente;
                }
            }

            catch (IndexOutOfRangeException ex1)
            {
                throw;
            }
            catch (FormatException ex2)
            {
                throw;
            }
            catch (Exception ex3)
            {
                throw;
            }

        }

        //obtener

        public static List<Cliente> ObtenerCliente()
        {
            try
            {
                using (IDbConnection _connection = DBComun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ObtenerCliente", _connection as SqlConnection);

                    _command.CommandType = CommandType.StoredProcedure;


                    SqlDataReader _reader = _command.ExecuteReader();

                    List<Cliente> _listaCliente = new List<Cliente>();

                    while (_reader.Read())
                    {
                        Cliente _cliente = new Cliente();

                        _cliente.Id = _reader.GetInt32(0);
                        _cliente.Nombre = _reader.GetString(1);
                        _cliente.Apellido = _reader.GetString(2);
                        _cliente.Telefono = _reader.GetString(3);
                        _cliente.CorreoElectronico = _reader.GetString(4);
                        _cliente.Genero = _reader.GetString(5);
                        _cliente.DUI = _reader.GetString(6);
                        _cliente.NIT = _reader.GetString(7);
                        _cliente.ConsumidorFinal = _reader.GetString(8);
                        _cliente.SalonDeBelleza = _reader.GetString(9);
                        _cliente.NumeroDeCompras = _reader.GetInt32(10);

                        _listaCliente.Add(_cliente);

                    }

                    _reader.Close();

                    _connection.Close();

                    return _listaCliente;
                }
            }

            catch (IndexOutOfRangeException ex1)
            {
                throw;
            }
            catch (FormatException ex2)
            {
                throw;
            }
            catch (Exception ex3)
            {
                throw;
            }

        }
    }
}