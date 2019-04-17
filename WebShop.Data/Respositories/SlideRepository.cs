using WebShop.Data.Infrastructure;
using WebShop.Model.Models;

namespace WebShop.Data.Respositories
{
    public interface ISlideRepository
    {
    }

    public class SlideRepository : RepositoryBase<Slide>, ISlideRepository
    {
        public SlideRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}