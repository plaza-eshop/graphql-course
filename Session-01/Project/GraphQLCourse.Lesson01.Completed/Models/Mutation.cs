using GraphQLCourse.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLCourse.Lesson03.Completed.Models
{
    public class Mutation
    {
        public Product AddProduct(string product, string brand) =>
            new Product
            {
                Brand = new Brand
                {
                    Id = 5,
                    Title = brand
                },
                Id = 1005,
                Title = product
            };
    }
}
