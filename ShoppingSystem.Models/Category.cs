namespace ShoppingSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using ShoppingSystem.Common;

    public class Category
    {
        public string Id { get; set; }

        public Category()
        {
            this.Id = Tools.GenerateId();
            this.Products = new HashSet<Product>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
