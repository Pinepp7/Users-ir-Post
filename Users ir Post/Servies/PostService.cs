using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users_ir_Post.Contract;
using Users_ir_Post.Models;

namespace Users_ir_Post.Servies
{
    public class PostService
    {
        private readonly IPostRepository _postRepository;
        public PostService (IPostRepository postRepository)
        {

           _postRepository = postRepository;
        }

        public void AddPost(Post post)
        {

            _postRepository.Add(post);
        }
        public void DelletePost (int id)
        {
            _postRepository.Delete(id);
        }
        public Post GetPost(int id)
        {
            return _postRepository.Get(id);  
        }
  
    }

}
