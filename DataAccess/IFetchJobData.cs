
namespace WalkInPortalAPI.DataAccess
{
    public interface IFetchJobData
    {
        public Task<dynamic> FetchJob();
        public Task<dynamic> FetchJob(int id);

    }
}