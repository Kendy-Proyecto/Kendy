﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kendy.Registros.DAL
{
    public class DBComun
    {
        public const string _cadenaConexion = @"Data Source=DESKTOP-GFF2SSM\SQLEXPRESS01;Initial Catalog=Kendy;Integrated Security=True";


        public static IDbConnection ObtenerConexion()
        {
            return new SqlConnection(_cadenaConexion);
        }
    }
}
