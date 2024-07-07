using DatingApp.WebAPI.Entities;

namespace DatingApp.WebAPI.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
