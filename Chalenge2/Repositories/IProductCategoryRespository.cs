using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Challenge2.Models;
using Challenge2.Responses;

namespace Challenge2.Repositories
{
    public class IProductCategoryRespository 
    {

    }
    public interface IProductCategoryRepository
    {
        Task<IEnumerable<ProductCategory>> ListAsync();
        Task AddAsync(ProductCategory category);

    }

   
}