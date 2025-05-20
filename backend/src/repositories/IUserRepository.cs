using backend.src.models;

namespace backend.src.repositories
{
    public interface IUserRepository
    {
        void Add(User user);

        List<User> Get();
    }
}