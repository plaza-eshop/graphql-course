using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQLCourse.Domain
{
    public class Product
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public Brand Brand { get; set; }
    }
}
