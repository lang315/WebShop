using WebShop.Data.Infrastructure;
using WebShop.Model.Models;

namespace WebShop.Data.Respositories
{
    public interface IPostTagRepository
    {
    }

    public class PostTagRepository : RepositoryBase<PostTag>, IPostTagRepository
    {
        public PostTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}