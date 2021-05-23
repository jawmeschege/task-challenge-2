using AutoMapper;
using Challenge2.Models;
using Challenge2.Resources;


namespace Challenge2.Mapping
{
    public class Model : Profile
    {
        public Model()
        {
            CreateMap<AddProductCategoryResource, ProductCategory>();
        }
    }
}
