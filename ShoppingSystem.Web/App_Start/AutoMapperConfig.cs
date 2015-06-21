namespace ShoppingSystem.Web
{
    using ShoppingSystem.Models;
    using ShoppingSystem.Web.Areas.Admin.Models.Shop;

    public static class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            AutoMapper.Mapper.CreateMap<Category, CategoryViewModel>().ReverseMap();
        }
    }
}
