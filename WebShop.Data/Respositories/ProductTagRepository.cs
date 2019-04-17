using WebShop.Data.Infrastructure;
using WebShop.Model.Models;

namespace WebShop.Data.Respositories
{
    public interface IProductTagRepository
    {
    }

    public class ProductTagRepository : RepositoryBase<ProductTag>, IProductTagRepository
    {
        public ProductTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}