﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDRazorPages.DataAccess.Repositories
{
    public abstract class SQLConnection
    {
        private readonly IConfiguration _configuration;
        private const string _connectionStringName = "DefaultConnection";

        public SQLConnection(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(_configuration.GetConnectionString(_connectionStringName));
        }
    }
}
