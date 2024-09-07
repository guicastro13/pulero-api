using Entities;

namespace Repository.InMemory;
public class InMemoryUserRepository: IUserRepository
{
    private List<User> _users;
    public InMemoryUserRepository()
    {
        _users = new List<User>{};
    }

    public async Task<User> CreateUser(User user)
    {
        _users.Add(user);
        return user;
    }

    public async Task<User> DeleteUser(int id)
    {
        var user = _users.FirstOrDefault(u => u.Id == id);
        if (user != null)
        {
            _users.Remove(user);
        }
        return user;
    }

    public async Task<User> GetUser(int id)
    {
        return _users.FirstOrDefault(u => u.Id == id);
    }

    public async Task<User> GetUser(string email)
    {
        return _users.FirstOrDefault(u => u.Email == email);
    }

    public async Task<IEnumerable<User>> GetUsers()
    {
        return _users;
    }

    public async Task<User> UpdateUser(User user)
    {
        var existingUser = _users.FirstOrDefault(u => u.Id == user.Id);
        if (existingUser != null)
        {
            existingUser.Name = user.Name;
            existingUser.Email = user.Email;
            existingUser.Password = user.Password;
        }
        return existingUser;
    }
}