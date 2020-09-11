using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kendy.Registros.EN;
using Kendy.Registros.DAL;


namespace Kendy.Registros.DAL
{
    public class ProductoDAL
    {
        private static Producto _Producto;

        public static int AgregarProducto(Producto pProducto)
        {
            try
            {
                using (IDbConnection _connection = DBComun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("AgregarProducto", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Nombre", pProducto.Nombre);
                    _command.Parameters.AddWithValue("@Marca", pProducto.Marca);
                    _command.Parameters.AddWithValue("@FamiliaProducto", pProducto.FamiliaProducto);
                    _command.Parameters.AddWithValue("@FechaCaducacion", pProducto.FechaCaducacion);
                    _command.Parameters.AddWithValue("@FechaIngreso", pProducto.FechaIngreso);
                    _command.Parameters.AddWithValue("@Precio", pProducto.Precio);
                    _command.Parameters.AddWithValue("@Categoria", pProducto.Categoria);
                    _command.Parameters.AddWithValue("@Unidades", pProducto.Unidades);
                    _command.Parameters.AddWithValue("@Disponibilidad", pProducto.Disponibilidad);



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


        ///Modificar

        public static int ModificarProducto(Producto pProducto)
        {
            try
            {
                using (IDbConnection _connection = DBComun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ModificarProducto", _connection as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Nombre", pProducto.Nombre);
                    _command.Parameters.AddWithValue("@Marca", pProducto.Marca);
                    _command.Parameters.AddWithValue("@FamiliaProducto", pProducto.FamiliaProducto);
                    _command.Parameters.AddWithValue("@FechaCaducacion", pProducto.FechaCaducacion);
                    _command.Parameters.AddWithValue("@FechaIngreso", pProducto.FechaIngreso);
                    _command.Parameters.AddWithValue("@Precio", pProducto.Precio);
                    _command.Parameters.AddWithValue("@Categoria", pProducto.Categoria);
                    _command.Parameters.AddWithValue("@Unidades", pProducto.Unidades);
                    _command.Parameters.AddWithValue("@Disponibilidad", pProducto.Disponibilidad);

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

        public static int EliminarProducto(int pId)
        {
            try
            {
                using (IDbConnection _connection = DBComun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("EliminarProducto", _connection as SqlConnection);
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

        public static List<Producto> ConsultarProductoPorFechaIngreso(DateTime pFechaIngreso)
        {
            try
            {
                using (IDbConnection _connection = DBComun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ConsultarPoducto", _connection as SqlConnection);

                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@FechaIngresp", pFechaIngreso);

                    SqlDataReader _reader = _command.ExecuteReader();

                    List<Producto> _listaProducto = new List<Producto>();

                    while (_reader.Read())
                    {
                        Producto _Producto = new Producto();

                        
                        _Producto.Nombre = _reader.GetString(1); //Empieza de 0
                        _Producto.Marca = _reader.GetString(2);
                        _Producto.FamiliaProducto = _reader.GetString(3);
                        _Producto.FechaCaducacion = _reader.GetDateTime(4);
                        _Producto.FechaIngreso = _reader.GetDateTime(5);
                        _Producto.Precio = _reader.GetFloat(6); //Es float
                        _Producto.Categoria = _reader.GetString(7);
                        _Producto.Unidades = _reader.GetInt32(8); //es int
                        _Producto.Disponibilidad = _reader.GetString(9);

                        _listaProducto.Add(_Producto);

                    }

                    _reader.Close();

                    _connection.Close();

                    return _listaProducto;
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

       
        //Obtener

        public static List<Producto> ObtenerProducto()
        {
            try
            {
                using (IDbConnection _connection = DBComun.ObtenerConexion())
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ObtenerProducto", _connection as SqlConnection);

                    _command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader _reader = _command.ExecuteReader();

                    List<Producto> _listaProducto = new List<Producto>();

                    while (_reader.Read())
                    {
                        Producto _producto = new Producto();//minuscula ok

                        _producto.Id = _reader.GetInt32(0); //
                        _producto.Nombre = _reader.GetString(1);
                        _producto.Marca = _reader.GetString(2);
                        _producto.FamiliaProducto = _reader.GetString(3);
                        _producto.FechaCaducacion = _reader.GetDateTime(4);
                        _producto.FechaIngreso = _reader.GetDateTime(5);
                        _producto.Precio = _reader.GetFloat(6);
                        _producto.Categoria = _reader.GetString(7);
                        _producto.Unidades = _reader.GetInt32(8);
                        _producto.Disponibilidad = _reader.GetString(9);

                        _listaProducto.Add(_producto);

                    }

                    _reader.Close();

                    _connection.Close();

                    return _listaProducto;
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

        //Siguiente metodo

    } //Siempre quedan 2 }ok
}