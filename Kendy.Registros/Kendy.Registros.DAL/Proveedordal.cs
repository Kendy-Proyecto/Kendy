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
    public class ProveedorDAL
    {
        public static int AgregarProveedor(Proveedor pProveedor)
        {
           try
            {
                using (IDbConnection _connection = DBComun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("AgregarProveedor", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Nombre", pProveedor.Nombre);
                    _command.Parameters.AddWithValue("@Apellido", pProveedor.Apellido); 
                    _command.Parameters.AddWithValue("@Empresa", pProveedor.Empresa);
                    _command.Parameters.AddWithValue("@Direccion", pProveedor.Direccion);
                    _command.Parameters.AddWithValue("@Telefono", pProveedor.Telefono);
                    _command.Parameters.AddWithValue("@CorreoElectronico", pProveedor.CorreoElectronico);
                    _command.Parameters.AddWithValue("@Nit", pProveedor.NIT);
                    _command.Parameters.AddWithValue("@NumeroDeRegistro", pProveedor.NumeroDeRegistro);


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

public static int ModificarProveedor(Proveedor pProveedor)
{
    try
    {
        using (IDbConnection _connection = DBComun.ObtenerConexion())
        {
            _connection.Open();

            SqlCommand _command = new SqlCommand("ModificarProveedor", _connection as SqlConnection);
            _command.CommandType = CommandType.StoredProcedure;

            _command.Parameters.AddWithValue("@Nombre", pProveedor.Nombre);
            _command.Parameters.AddWithValue("@Apellido", pProveedor.Apellido);
            _command.Parameters.AddWithValue("@Empresa", pProveedor.Empresa);
            _command.Parameters.AddWithValue("@Direccion", pProveedor.Direccion);
            _command.Parameters.AddWithValue("@Telefono", pProveedor.Telefono);
            _command.Parameters.AddWithValue("@CorreoElectronico", pProveedor.CorreoElectronico);
            _command.Parameters.AddWithValue("@Nit", pProveedor.NIT);
            _command.Parameters.AddWithValue("@NumeroDeRegistro", pProveedor.NumeroDeRegistro);


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

public static int EliminarProveedor(int pId)
{
    try
    {
        using (IDbConnection _connection = DBComun.ObtenerConexion())
        {
            _connection.Open();

            SqlCommand _command = new SqlCommand("EliminarProveedor", _connection as SqlConnection);
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

public static List<Proveedor> BuscaProveedor (int pId)
{
    try
    {
        using (IDbConnection _connection = DBComun.ObtenerConexion())
        {
            _connection.Open();

            SqlCommand _command = new SqlCommand("BuscarProveedor", _connection as SqlConnection);

            _command.CommandType = CommandType.StoredProcedure;

            _command.Parameters.AddWithValue("@Id", pId);

            SqlDataReader _reader = _command.ExecuteReader();

            List<Proveedor> _listaProveedor = new List<Proveedor>();

            while (_reader.Read())
            {
                Proveedor _proveedor = new Proveedor();

                _proveedor.Id = _reader.GetInt32(0);
                _proveedor.Nombre = _reader.GetString(1);
                _proveedor.Empresa = _reader.GetString(2);
                _proveedor.Direccion = _reader.GetString(3);
                _proveedor.Telefono = _reader.GetString(4);
                _proveedor.CorreoElectronico = _reader.GetString(5);
                _proveedor.NIT= _reader.GetString(6);
                _proveedor.NumeroDeRegistro= _reader.GetInt32(7);

                _listaProveedor.Add(_proveedor);

            }

            _reader.Close();

            _connection.Close();

            return _listaProveedor;
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

public static List<Proveedor> BuscarProveedorPorNombre(string pNombre)
{
    try
    {
        using (IDbConnection _connection = DBComun.ObtenerConexion())
        {
            _connection.Open();

            SqlCommand _command = new SqlCommand("BuscarProveedorPorNombre", _connection as SqlConnection);

            _command.CommandType = CommandType.StoredProcedure;

            _command.Parameters.AddWithValue("@Nombre", pNombre);

            SqlDataReader _reader = _command.ExecuteReader();

            List<Proveedor> _listaProveedor = new List<Proveedor>();

            while (_reader.Read())
            {
                Proveedor _proveedor = new Proveedor();

                _proveedor.Id = _reader.GetInt32(0);
                _proveedor.Nombre = _reader.GetString(1);
                _proveedor.Empresa = _reader.GetString(2);
                _proveedor.Direccion = _reader.GetString(3);
                _proveedor.Telefono = _reader.GetString(4);
                _proveedor.CorreoElectronico = _reader.GetString(5);
                _proveedor.NIT = _reader.GetString(6);
                _proveedor.NumeroDeRegistro = _reader.GetInt32(7);

                _listaProveedor.Add(_proveedor);

            }

            _reader.Close();

            _connection.Close();

            return _listaProveedor;
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

public static List<Proveedor> ObtenerProveedor()
{
    try
    {
        using (IDbConnection _connection = DBComun.ObtenerConexion())
        {
            _connection.Open();

            SqlCommand _command = new SqlCommand("ObtenerProveedor", _connection as SqlConnection);

            _command.CommandType = CommandType.StoredProcedure;

            SqlDataReader _reader = _command.ExecuteReader();

            List<Proveedor> _listaProveedor = new List<Proveedor>();

            while (_reader.Read())
            {
                Proveedor _proveedor = new Proveedor();

                _proveedor.Id = _reader.GetInt32(0);
                _proveedor.Nombre = _reader.GetString(1);
                _proveedor.Empresa = _reader.GetString(2);
                _proveedor.Direccion = _reader.GetString(3);
                _proveedor.Telefono = _reader.GetString(4);
                _proveedor.CorreoElectronico = _reader.GetString(5);
                _proveedor.NIT = _reader.GetString(6);
                _proveedor.NumeroDeRegistro = _reader.GetInt32(7);

                _listaProveedor.Add(_proveedor);

            }

            _reader.Close();

            _connection.Close();

            return _listaProveedor;
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
