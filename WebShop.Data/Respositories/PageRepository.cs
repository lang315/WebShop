using WebShop.Data.Infrastructure;
using WebShop.Model.Models;

namespace WebShop.Data.Respositories
{
    public interface IPageRepository
    {
    }

    public class PageRepository : RepositoryBase<Page>, IPageRepository
    {
        public PageRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}