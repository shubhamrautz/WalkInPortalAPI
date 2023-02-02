using WalkInPortalAPI.Helper;
using Dapper;
using WalkInPortalAPI.Models;

namespace WalkInPortalAPI.DataAccess
{
    public class PrefetchData : IPrefetchData
    {

        private readonly DatabaseConnection _DbConnection;
        public PrefetchData(DatabaseConnection DbConnection)
        {
            _DbConnection = DbConnection;
        }

        public async Task<PrefetchDataModel> Prefetch()
        {
            PrefetchDataModel Result = new PrefetchDataModel();
            var sql = "call prefetch()";
            using (var conn = _DbConnection.CreateConn())
            {
                var results = await conn.QueryMultipleAsync(sql);
                Result.Roles = await results.ReadAsync<Role>();
                Result.Qualifications = await results.ReadAsync<Qualification>();
                Result.Streams = await results.ReadAsync<QualificationStream>();
                Result.Colleges = await results.ReadAsync<College>();
                Result.Technologies = await results.ReadAsync<Technology>();
            }
            return Result;
        }
    }
}
