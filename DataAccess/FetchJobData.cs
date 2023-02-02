using Dapper;
using WalkInPortalAPI.Helper;
using WalkInPortalAPI.Models;

namespace WalkInPortalAPI.DataAccess
{
    public class FetchJobData : IFetchJobData
    {
        private readonly DatabaseConnection _DbConnection;
        public FetchJobData(DatabaseConnection DbConnection)
        {
            _DbConnection = DbConnection;
        }

        public async Task<dynamic> FetchJob()
        {
            var sql = "call FetchJobsData()";
            using (var conn = _DbConnection.CreateConn())
            {
                dynamic results = await conn.QueryAsync(sql);
                return results;
            }
        }

        public async Task<dynamic> FetchJob(int id)
        {
            var sql = $"call FetchJobData({id})";
            //FetchJobDataModel Result = new FetchJobDataModel();

            using (var conn = _DbConnection.CreateConn())
            {
                dynamic Result = await conn.QuerySingleAsync(sql);

                return Result;
            }
        }



    }
}