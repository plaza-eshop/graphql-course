using GraphQLApp.Models;
using HotChocolate.Types;

namespace GraphQLApp.Api.Types
{
    public class ProductType : ObjectType<Product>
    {
        protected override void Configure(IObjectTypeDescriptor<Product> descriptor)
        {
            descriptor.Name("MyProduct");
        }
    }
}
