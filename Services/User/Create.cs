using Entities;
using Repository;

namespace Services;
public class Create(IUserRepository userRepository)
{
    private readonly IUserRepository _userRepository = userRepository;

    public async Task<User> Execute(User user)
    {
        var _user = new User
        {
            Name = user.Name,
            Email = user.Email,
            Password = user.Password
        };
        return await _userRepository.CreateUser(_user);
    }
}