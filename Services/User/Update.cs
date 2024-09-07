using Entities;
using Repository;

namespace Services;
public class Update(IUserRepository userRepository)
{
    private readonly IUserRepository _userRepository = userRepository;

    public async Task<User> Execute(User user)
    {
        var _user = new User
        {
            Id = user.Id,
            Name = user.Name,
            Email = user.Email,
            Password = user.Password
        };
        return await _userRepository.UpdateUser(_user);
    }
}