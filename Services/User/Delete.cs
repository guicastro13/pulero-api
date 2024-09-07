using Entities;
using Repository;

namespace Services;
public class Delete(IUserRepository userRepository)
{
    private readonly IUserRepository _userRepository = userRepository;

    public async Task<User> Execute(int id)
    {
        return await _userRepository.DeleteUser(id);
    }
}