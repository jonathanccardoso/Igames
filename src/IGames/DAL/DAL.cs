using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace IGames.DAL
{
    public class DAL
    {
        protected static string connectionString =ConfigurationManager.ConnectionStrings["iGamesConnectionString"].ConnectionString;
        protected static SqlConnection connection;
        public DAL()
        {
                
        }
    }
}