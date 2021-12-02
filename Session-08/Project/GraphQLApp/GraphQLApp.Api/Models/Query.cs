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
            throw new Exception("Sutome error message");

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

        public GenericResponse<Product> GetProductResponse()
        {
            return new GenericResponse<Product>
            {
                Status = "200",
                Payload = GetProduct()
            };
        }

        public List<IMessage> GetMessages()
        {
            return new List<IMessage>
            {
                new TextMessage
                {
                    Text = "Simple Message",
                    Id = 10
                },
                new DatedMessage
                {
                    Text = "Dated Message",
                    SendDate = DateTime.Now
                }
            };
        }

        public List<object> GetPosts()
        {
            return new List<object>
            {
                new TextContent
                {
                    Text = "text"
                },
                new ImageContent
                {
                    ImageUrl = "http://..."
                }
            };
        }
    }
}
