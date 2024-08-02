using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users_ir_Post.Contract;
using Users_ir_Post.Models;

namespace Users_ir_Post.Servies
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void AddUser(User user)
        {

            _userRepository.Add(user);
        }
        public void DeleetUser(int id)
        {

            _userRepository.Delete(id);
        }
        public User GetUser(int id)
        {
            return _userRepository.Get(id);
        }
    }
}
