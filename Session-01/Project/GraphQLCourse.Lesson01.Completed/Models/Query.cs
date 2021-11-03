using GraphQLCourse.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLCourse.Lesson03.Completed.Models
{
    public class Query
    {
        public Product GetProduct() =>
            new Product
                {
                    Brand = new Brand
                    {
                        Id = 1,
                        Title = "Samsung"
                    },
                    Id = 1000,
                    Title = "Galaxy S21 Ultra"
                };

        public Product GetProduct2(int id) =>
            new Product
            {
                Brand = new Brand
                {
                    Id = 1,
                    Title = "Samsung"
                },
                Id = 1000,
                Title = "Galaxy S21 Ultra"
            };

        public Product GetProduct3(string title) =>
            new Product
            {
                Brand = new Brand
                {
                    Id = 1,
                    Title = "Samsung"
                },
                Id = 1000,
                Title = "Galaxy S21 Ultra"
            };

        
    }
}
