using System;
using System.Collections.Generic;
using Challenge2.Services;
using Challenge2.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Challenge2.Resources;
using Challenge2.Helpers;

namespace Challenge2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoriesController : ControllerBase
    {
        private readonly ProductCategoryService _categoryService;
        private readonly IMapper _mapper;

        public ProductCategoriesController(ProductCategoryService categoryService, IMapper mapper)
        {
        
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductCategoryResource>> GetAllAsync()
        {
            var categories = await _categoryService.ListAsync();
            var resources = _mapper.Map<IEnumerable<ProductCategory>, IEnumerable<ProductCategoryResource>>(categories);

            return resources;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] AddProductCategoryResource resource)
        {
            if(!ModelState.IsValid)

          return BadRequest(ModelState.GetErrorMessages());
            var category = _mapper.Map<AddProductCategoryResource, ProductCategory>(resource);

            var result = await _categoryService.SaveAsync(category);

            if (!result.Success)
                return BadRequest(result.Message);

            var categoryResource = _mapper.Map<ProductCategory, ProductCategoryResource>(result.Category);
            return Ok(categoryResource);
        }
    }
}
