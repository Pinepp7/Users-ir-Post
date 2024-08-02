using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users_ir_Post.Models;

namespace Users_ir_Post.Contract
{
    public interface IUserRepository
    {
        void Add(User user);
        void Delete(int id);
        User Get (int id);
        IEnumerable<User> GetAll();

    }
}
