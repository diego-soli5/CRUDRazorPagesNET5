﻿using CRUDRazorPages.DataAccess.Contracts.ISQL;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDRazorPages.DataAccess
{
    public class SQLHelper : ConnectionSQL, ISqlHelper
    {
        public SQLHelper(IConfiguration configuration)
            : base(configuration)
        {

        }

        public async Task<int> ExecuteNonQueryAsync(string transactionSQL, List<SqlParameter> parameters)
        {
            using (var connection = GetConnection())
            {
                await connection.OpenAsync();

                using (var command = new SqlCommand(transactionSQL, connection))
                {
                    parameters.ForEach(p => command.Parameters.Add(p));

                    int result = await command.ExecuteNonQueryAsync();

                    return result;
                }
            }
        }

        public async Task<DataTable> ExecuteReaderAsync(string transactionSQL, List<SqlParameter> parameters = null)
        {
            using (var connection = GetConnection())
            {
                await connection.OpenAsync();

                using (var command = new SqlCommand(transactionSQL, connection))
                {
                    if(parameters != null) parameters.ForEach(p => command.Parameters.Add(p));

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        using (var table = new DataTable())
                        {
                            table.Load(reader);

                            return table;
                        }
                    }
                }
            }
        }

    }
}
