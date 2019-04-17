using WebShop.Data.Infrastructure;
using WebShop.Model.Models;

namespace WebShop.Data.Respositories
{
    public interface ISystemConfigRepository
    {
    }

    public class SystemConfigRepository : RepositoryBase<SystemConfig>, ISystemConfigRepository
    {
        public SystemConfigRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}