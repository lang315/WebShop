using WebShop.Data.Infrastructure;
using WebShop.Model.Models;

namespace WebShop.Data.Respositories
{
    public interface ITagRepository
    {
    }

    public class TagRepository : RepositoryBase<Tag>, ITagRepository
    {
        public TagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}