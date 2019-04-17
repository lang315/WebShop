using WebShop.Data.Infrastructure;
using WebShop.Model.Models;

namespace WebShop.Data.Respositories
{
    public interface ISupportOnlineRepository
    {
    }

    public class SupportOnlineRepository : RepositoryBase<SupportOnline>, ISupportOnlineRepository
    {
        public SupportOnlineRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}