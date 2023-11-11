namespace PTSQL.SQL.Connections
{
    public class ConnectionFactory
    {
        public string ConnectionString { get; set; }

        private ConnectionFactory(string connectionString) =>
            ConnectionString = connectionString;

        public static ConnectionFactory Create(string connectionString) =>
            new ConnectionFactory(connectionString);
    }
}
