using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Users_ir_Post.Contract;
using Users_ir_Post.Models;

namespace Users_ir_Post.Repository
{
    public class PostRepository : IPostRepository
    {
        private readonly string connectionString;
        public PostRepository(string connectionString)
        {
            this.connectionString = connectionString;

        }

        public IEnumerable<Post> GetByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        void IPostRepository.Add(Post post)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                string sqlQuery = "InSERT INTO Post (UserId,Title, Content)";
                    db.Execute(sqlQuery, post);
            }
        }

        void IPostRepository.Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                string sqlQuery = "DELETE FROM Posrt WHERE Id = @Id";
                db.Execute(sqlQuery);

            }
        }

        Post IPostRepository.Get(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {

                string sqlQuery = "DELETE FROM Posrt WHERE Id = @Id";
                db.Execute(sqlQuery);
            }
        }

        IEnumerable<Post> IPostRepository.GetAll()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {

                string sqlQuery = "SELECT * FROM Post WHERE UserId =@UserId";
                return db.Query<Post>(sqlQuery, new { UserId = userId });

            }
        }

         public IEnumerable<Post> GetByUserId(int )
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {

                string sqlQuery = "SELECT * FROM Post WHERE UserId =@UserId";
                return db.Query<Post>(sqlQuery, new { UserId = userId });

            }

        }
    }
}
