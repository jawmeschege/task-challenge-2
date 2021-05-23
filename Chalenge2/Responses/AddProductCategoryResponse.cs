using Challenge2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge2.Responses
{
    public class AddProductCategoryResponse : BaseResponses
    {
        public ProductCategory Category { get; private set; }

        private AddProductCategoryResponse(bool success, string message, ProductCategory category) : base(success, message)
        {
            Category = category;
        }

        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="category">Saved category.</param>
        /// <returns>Response.</returns>
        public AddProductCategoryResponse(ProductCategory category) : this(true, string.Empty, category)
        { }
        
        /// <summary>
        /// Creates am error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public AddProductCategoryResponse(string message) : this(false, message, null)
        { }
    }
}
