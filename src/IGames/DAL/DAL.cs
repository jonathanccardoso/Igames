﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace IGames.DAL
{
    public class DAL
    {
        protected string connectionString;
        protected SqlConnection connection;
        public DAL(){
            connectionString = ConfigurationManager.ConnectionStrings["iGamesConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }
    }
}