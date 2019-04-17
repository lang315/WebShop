using WebShop.Data.Infrastructure;
using WebShop.Model.Models;

namespace WebShop.Data.Respositories
{
    public interface IOrderDetailRepository
    {
    }

    public class OrderDetailRepository : RepositoryBase<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}