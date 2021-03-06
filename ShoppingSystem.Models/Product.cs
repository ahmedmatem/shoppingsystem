﻿namespace ShoppingSystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using ShoppingSystem.Common;
    using ShoppingSystem.Common.Types;

    public class Product
    {
        public string Id { get; set; }

        public Product()
        {
            this.Id = Tools.GenerateId();
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public decimal Weight { get; set; }

        public decimal RealWeight { get; set; }

        public Measure Measure { get; set; }

        public DateTime ProducedDate { get; set; }

        public DateTime ExpiredDate { get; set; }

        public string Description { get; set; }


        public Guid CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
