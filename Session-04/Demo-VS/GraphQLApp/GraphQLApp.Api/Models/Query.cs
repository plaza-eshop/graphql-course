using GraphQLApp.Models;
using System;
using System.Collections.Generic;

namespace GraphQLApp.Api.Models
{
    public class Query
    {
        public Product GetProductById(int id)
        {
            //return new Product
            //{
            //    Id = id,
            //    Title = "Galaxy S8",
            //};

            throw new Exception("My Custom Error");
        }


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
                Title = "Galaxy S8",
                ProductType = ProductTypes.Simple,
                SubProducts = new List<Product>
                {
                    new Product
                    {
                        Id = 1000,
                        Title = "Galaxy S8 Cover",
                    },
                     new Product
                    {
                        Id = 1000,
                        Title = "Galaxy S8 Glass",
                    }
                }
            };
        }

        public Response<Product> GetResponse()
        {
            return new Response<Product>
            {
                State = "200",
                Payload = new Product
                {
                    Brand = new Brand
                    {
                        Id = 1,
                        Title = "Samsung"
                    },
                    Id = 1000,
                    Title = "Galaxy S8",
                    ProductType = ProductTypes.Simple,
                    SubProducts = new List<Product>
                    {
                        new Product
                        {
                            Id = 1000,
                            Title = "Galaxy S8 Cover",
                        },
                         new Product
                        {
                            Id = 1000,
                            Title = "Galaxy S8 Glass",
                        }
                    }
                }
            };
        }
    }
}
