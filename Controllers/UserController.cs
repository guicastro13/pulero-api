using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace pulero_back
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        public Services.Create CreateUser { get; set; }
        public Services.GetUsers GetUsers { get; set; }
        //public Services.GetUser GetUser { get; set; }
        // public Services.UpdateUser UpdateUser { get; set; }
        // public Services.DeleteUser DeleteUser { get; set; }
        
        public UserController(Services.Create createUser, Services.GetUsers getUsers)
        {
            CreateUser = createUser;
            GetUsers = getUsers;
            // GetUser = getUser;
            // UpdateUser = updateUser;
            // DeleteUser = deleteUser;
        }
        

        [HttpGet]
        public async Task<IEnumerable<Entities.User>> CGetUsers()
        {
            return await GetUsers.Execute();
        }

        [HttpPost]
        public async Task<Entities.User> CCreateUser([FromBody] Entities.User user)
        {
            return await CreateUser.Execute(user);
        }

        
    }
}