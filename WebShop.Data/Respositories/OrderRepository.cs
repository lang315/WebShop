using WebShop.Data.Infrastructure;
using WebShop.Model.Models;

namespace WebShop.Data.Respositories
{
    public interface IOrderRepository
    {
    }

    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}