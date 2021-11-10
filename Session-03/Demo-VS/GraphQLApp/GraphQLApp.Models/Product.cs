using System;
using System.Collections.Generic;

namespace GraphQLApp.Models
{
    public class Product
    {
        public int Id { get; set; }

        public Guid UniqueId { get; set; } = Guid.NewGuid();

        public string Title { get; set; }

        public Brand Brand { get; set; }

        public ProductTypes ProductType { get; set; }

        public List<Product> SubProducts { get; set; }
    }

    public enum ProductTypes: byte
    {
        Simple = 1,
        Complex = 2
    }
}
