using Entities;
using Repository;

namespace Services
{
    public class GetUsers(IUserRepository userRepository)
    {
        private readonly IUserRepository _userRepository = userRepository;

        public async Task<IEnumerable<User>> Execute()
        {
            return await _userRepository.GetUsers();
        }
    }
}