using WebShop.Data.Infrastructure;
using WebShop.Model.Models;

namespace WebShop.Data.Respositories
{
    public interface IPostRepository
    {
    }

    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}