
using WalkInPortalAPI.Models;
namespace WalkInPortalAPI.Register
{
    public interface IRegisterData
    {
        public Task<dynamic> Register(CreateUser user);
    }
}