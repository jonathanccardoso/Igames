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
        protected string connectionString = ConfigurationManager.ConnectionStrings["iGamesConnectionString"].ConnectionString;
        protected SqlConnection connection;
        public DAL(){
            connection = new SqlConnection(connectionString);
        }
    }
}