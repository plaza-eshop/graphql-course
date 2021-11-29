using System;

namespace GraphQLApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public Brand Brand { get; set; }
    }
}
