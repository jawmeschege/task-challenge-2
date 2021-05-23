using System;
using System.ComponentModel.DataAnnotations;


namespace Challenge2.Resources
{
    public class AddProductCategoryResource
    {
        
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    
    }
}
