using System.Threading.Tasks;

namespace SuraCheckIn.API.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);
        Task<User> Login(string email, string password);
        Task<bool> UserExists(string email);

    }
}