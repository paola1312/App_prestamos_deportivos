﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace App_ConsultaPrestamosDeportivos
{
    public class cls_conexion
    {
        public SqlConnection connection = new SqlConnection("Data Source=LAPTOP-E8K1E0PB\\SQLEXPRESS02;Initial Catalog=dbs_prestamos_deportivos;Integrated security = true");
    }
}