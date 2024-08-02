using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users_ir_Post.Models;

namespace Users_ir_Post.Contract
{
    public interface IPostRepository
    {
        void Add(Post post);
        void Delete(int id);
        Post Get(int id);
        IEnumerable<Post> GetAll ();
        IEnumerable<Post> GetByUserId (int userId);
    }
}
