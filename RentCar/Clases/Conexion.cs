using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace RentCar.Clases
{
     class Conexion
    {
       static string connectionStr = ConfigurationManager.ConnectionStrings["RentCar.Properties.Settings.RentCarConnectionString"].ConnectionString;

       public static SqlConnection getSqlConexion()
        {
            //SqlConnection con;
            //con = new SqlConnection(connectionStr);
            return new SqlConnection(connectionStr);
        }
    }
}
