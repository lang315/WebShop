using WebShop.Data.Infrastructure;
using WebShop.Model.Models;

namespace WebShop.Data.Respositories
{
    public interface IMenuGroupRepository
    {
    }

    public class MenuGroupRepository : RepositoryBase<MenuGroup>, IMenuGroupRepository
    {
        public MenuGroupRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}