using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuraCheckIn.API.Data
{
    public interface ICheckInRepository
    {
        void Add<T>(T entityy) where T:class;
        void Delete<T>(T entity) where T:class;
        Task<bool> SaveAll();
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int id);
    }
}
                                                              