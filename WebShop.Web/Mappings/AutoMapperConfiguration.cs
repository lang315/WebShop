using AutoMapper;
using WebShop.Model.Models;
using WebShop.Web.Models;

namespace WebShop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configurate()
        {
            Mapper.CreateMap<Post, PostViewModel>();
            Mapper.CreateMap<PostCategory, PostCategoryViewModel>();
            Mapper.CreateMap<Tag, TagViewModel>();
            Mapper.CreateMap<ProductCategory, ProductCategoryViewModel>();
            Mapper.CreateMap<Product, ProductViewModel>();
            Mapper.CreateMap<ProductTag, ProductTagViewModel>();
        }
    }
}