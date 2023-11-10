using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSQL.SQL.Connections
{
    public class Connection
    {

        private SqlConnection SQLConnection;

        private Connection(string connectionString) => 
            new SqlConnection(connectionString);

        public static Connection Instance(string connectionString) =>
            new Connection(connectionString);

        public async Task Open() => 
            await SQLConnection.OpenAsync();

        public SqlCommand CreateCommand() =>
            SQLConnection.CreateCommand();

        public void Dispose() => 
            SQLConnection.Dispose();
    }
}
