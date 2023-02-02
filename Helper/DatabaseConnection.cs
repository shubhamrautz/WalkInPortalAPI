using System.Data;
using MySqlConnector;

namespace WalkInPortalAPI.Helper
{
    public class DatabaseConnection
    {
        private readonly IConfiguration _conf;
        private readonly string _connString;

        public DatabaseConnection(IConfiguration conf)
        {
            _conf = conf;
            _connString = _conf.GetConnectionString("Sql");
        }

        public IDbConnection CreateConn() => new MySqlConnection(_connString);
    }
}