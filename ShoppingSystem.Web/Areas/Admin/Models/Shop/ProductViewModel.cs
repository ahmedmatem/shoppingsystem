namespace ShoppingSystem.Web.Areas.Admin.Models.Shop
{
    using System;
    
    using ShoppingSystem.Common;
    using ShoppingSystem.Common.Types;

    public class ProductViewModel
    {
        public ProductViewModel()
        {
            this.Id = Tools.GenerateId();
            this.IsActive = true;
        }
        public string Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public decimal Weight { get; set; }

        public decimal RealWeight { get; set; }

        public Measure Measure { get; set; }

        public DateTime ProducedDate { get; set; }

        public DateTime ExpiredDate { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }
    }
}
