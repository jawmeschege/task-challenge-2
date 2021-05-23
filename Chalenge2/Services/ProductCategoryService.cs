using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge2.Models;
using Challenge2.Repositories;
using Challenge2.Responses;
using Challenge2.Services;

namespace Challenge2.Services
{
    public class ProductCategoryService
    {
        private readonly IProductCategoryRepository _categoryRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProductCategoryService(IProductCategoryRepository categoryRepository, IUnitOfWork unitOfWork)
        {
            _categoryRepository = categoryRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<ProductCategory>> ListAsync()
        {
            return await _categoryRepository.ListAsync();
        }

        public async Task<AddProductCategoryResponse> SaveAsync(ProductCategory category)
        {
            try
            {
                await _categoryRepository.AddAsync(category);
                await _unitOfWork.CompleteAsync();

                return new AddProductCategoryResponse(category);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new AddProductCategoryResponse($"An error occurred when saving the category: {ex.Message}");
            }
        }

    }
}
