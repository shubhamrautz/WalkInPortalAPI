using WalkInPortalAPI.Models;

namespace WalkInPortalAPI.DataAccess
{
    public interface IPrefetchData
    {
        public Task<PrefetchDataModel> Prefetch();
    }
}
