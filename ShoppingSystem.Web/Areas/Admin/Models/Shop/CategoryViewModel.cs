namespace ShoppingSystem.Web.Areas.Admin.Models.Shop
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using ShoppingSystem.Common;

    public class CategoryViewModel
    {
        public CategoryViewModel()
        {
            this.Id = Tools.GenerateId();
        }

        public string Id { get; set; }

        [Required]
        [Display(Name="Product Name")]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
