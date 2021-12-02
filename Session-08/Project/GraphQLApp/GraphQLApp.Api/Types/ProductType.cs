using GraphQLApp.Models;
using HotChocolate.Types;

namespace GraphQLApp.Api.Types
{
    public class ProductType2 : ObjectType<Product>
    {
        protected override void Configure(IObjectTypeDescriptor<Product> descriptor)
        {
            descriptor.Name("MyProduct2");
        }
    }

    public class ProductType3 : ObjectType<Product>
    {
        protected override void Configure(IObjectTypeDescriptor<Product> descriptor)
        {
            descriptor.Name("MyProduct3");
        }
    }
}
