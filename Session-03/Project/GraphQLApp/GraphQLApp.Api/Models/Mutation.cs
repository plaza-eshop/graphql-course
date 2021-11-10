using GraphQLApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApp.Api.Models
{
    public class Mutation
    {
        public Product Add(int id, string productnName)
        {
            return new Product
            {
                Id = id,
                Title = productnName
            };
        }
    }
}
