using Challenge2.Models;
using Challenge2.Resources;
using AutoMapper;


namespace Challenge2.Mapping
{
    public class Resource : Profile
    {
        public Resource()
        {
            CreateMap<ProductCategory, ProductCategoryResource>();
        }
    }
}

