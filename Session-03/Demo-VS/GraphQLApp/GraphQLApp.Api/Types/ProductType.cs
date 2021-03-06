using GraphQLApp.Models;
using HotChocolate.Types;

namespace GraphQLApp.Api.Types
{
    public class ProductType : ObjectType<Product>
    {
        protected override void Configure(IObjectTypeDescriptor<Product> descriptor)
        {
            descriptor.Name("GraphQLProduct");
        }
    }

    public class ProductType2 : ObjectType<Product>
    {
        protected override void Configure(IObjectTypeDescriptor<Product> descriptor)
        {
            //descriptor.BindFieldsExplicitly();
            //descriptor.BindFieldsImplicitly(); //default

            descriptor
                .Name("GraphQLProduct2");

            descriptor.Ignore(f => f.SubProducts);

            descriptor
                .Field(f => f.Title)
                .Name("Name")
                .Type<NonNullType<StringType>>();

            descriptor
                .Field("SKU")
                .Type<StringType>()
                .Resolve(context =>
                {
                    return "Pl-348298433";
                });

        }
    }
}
