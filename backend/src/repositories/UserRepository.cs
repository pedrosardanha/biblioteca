using backend.src.infrastructure;
using backend.src.models;

namespace backend.src.repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();

        public void Add(User user)
        {
            _context.Add(user);
            _context.SaveChanges();
        }

        List<User> IUserRepository.Get()
        {
            return _context.Users.ToList();
        }
    }
}