using GraphQLApp.Models;
using HotChocolate.Types;
using System.Collections.Generic;

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
            descriptor
                .Name("GraphQLProduct2");

            descriptor.Ignore(f => f.SubProducts);
            //descriptor.Ignore(f => f.ProductType);

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

            //descriptor
            //    .Field("OtherBrands")
            //    .Type<ListType<BrandType>>()
            //    .Resolve(context =>
            //    {
            //        return new List<Brand>();
            //    });

            //descriptor
            //    .Field("ProductType")
            //    .Type<ProductTypesType>()
            //    .Resolve(c => null);


        }
    }
}
