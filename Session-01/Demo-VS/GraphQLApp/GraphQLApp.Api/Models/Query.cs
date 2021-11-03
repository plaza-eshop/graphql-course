using GraphQLApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApp.Api.Models
{
    public class Query
    {
        public Product GetProduct()
        {
            return new Product
            {
                Brand = new Brand
                {
                    Id = 1,
                    Title = "Samsung"
                },
                Id = 1000,
                Title = "Galaxy S8"
            };
        }
    }
}
