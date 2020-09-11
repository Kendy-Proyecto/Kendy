using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kendy.Registros.EN;
using System.Data;
using System.Data.SqlClient;

namespace Kendy.Registros.DAL
{
    class VentaDAL
    {
        public static int AgregarVenta(Venta pVenta)
        {
            try
            {
                using (IDbConnection _connection = DBComun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("AgregarVenta", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Fecha", pVenta.Fecha);
                    _command.Parameters.AddWithValue("@Total", pVenta.Total);
                    _command.Parameters.AddWithValue("@EmpleadoId", pVenta.EmpleadoId);
                    _command.Parameters.AddWithValue("@ClienteId", pVenta.ClienteId);
                   


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

public static int ModificarVenta(Venta pVenta)
{
    try
    {
        using (IDbConnection _connection = DBComun.ObtenerConexion())
        {
            _connection.Open();

            SqlCommand _command = new SqlCommand("ModificarVenta", _connection as SqlConnection);
            _command.CommandType = CommandType.StoredProcedure;

            _command.Parameters.AddWithValue("@Fecha", pVenta.Fecha);
            _command.Parameters.AddWithValue("@Total", pVenta.Total);
            _command.Parameters.AddWithValue("@Empleadoid", pVenta.EmpleadoId);
            _command.Parameters.AddWithValue("@Clienteid", pVenta.ClienteId);
            
          


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

public static int EliminarVenta(int pId)
{
    try
    {
        using (IDbConnection _connection = DBComun.ObtenerConexion())
        {
            _connection.Open();

            SqlCommand _command = new SqlCommand("EliminarVenta", _connection as SqlConnection);
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

public static List<Venta> ConsultarVenta(int pId)
{
    try
    {
        using (IDbConnection _connection = DBComun.ObtenerConexion())
        {
            _connection.Open();

            SqlCommand _command = new SqlCommand("BuscarVenta", _connection as SqlConnection);

            _command.CommandType = CommandType.StoredProcedure;

            _command.Parameters.AddWithValue("@Id", pId);

            SqlDataReader _reader = _command.ExecuteReader();

            List<Venta> _listaVenta = new List<Venta>();

            while (_reader.Read())
            {
                Venta _Venta = new Venta();

                _Venta.Id = _reader.GetInt32(0);
                _Venta.Fecha = _reader.GetDateTime(1);
                _Venta.Total = _reader.GetFloat(2);
                _Venta.EmpleadoId = _reader.GetInt32(3);
                _Venta.ClienteId = _reader.GetInt32(4);
                
                

                _listaVenta.Add(_Venta);

            }

            _reader.Close();

            _connection.Close();

            return _listaVenta;
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

public static List<Venta> ObtenerVenta()
{
    try
    {
        using (IDbConnection _connection = DBComun.ObtenerConexion())
        {
            _connection.Open();

            SqlCommand _command = new SqlCommand("ObtenerVenta", _connection as SqlConnection);

            _command.CommandType = CommandType.StoredProcedure;

            SqlDataReader _reader = _command.ExecuteReader();

            List<Venta> _listaVenta = new List<Venta>();

            while (_reader.Read())
            {
                Venta _Venta = new Venta();

                _Venta.Id = _reader.GetInt32(0);
                _Venta.Fecha = _reader.GetDateTime(1);
                _Venta.Total = _reader.GetFloat(2);
                _Venta.EmpleadoId = _reader.GetInt32(3);
                _Venta.ClienteId = _reader.GetInt32(4);
            

                _listaVenta.Add(_Venta);

            }

            _reader.Close();

            _connection.Close();

                    return _listaVenta;
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