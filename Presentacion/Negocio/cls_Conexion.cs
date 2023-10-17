using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
   public class cls_Conexion
    {
        public SqlConnection connection = new SqlConnection("Data Source=LAPTOP-E8K1E0PB\\SQLEXPRESS02;Initial Catalog=dbs_prestamos_deportivos;Integrated Security=True");
    }
}
