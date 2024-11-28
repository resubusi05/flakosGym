﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flakosGym.Repositories
{
    public abstract class RepositoryBase
    {
        private readonly string _connectionString;

        public RepositoryBase()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["flakosGym.Properties.Settings.flakosGymConnectionString"].ConnectionString;
        }

        protected SqlConnection GetConnection() 
        {
            return new SqlConnection(_connectionString);
        }

    }
}
