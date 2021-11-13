using GraphQLApp.Api.Models;
using HotChocolate.Types;

namespace GraphQLApp.Api.Types
{
    public class QueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor
                .Field(f => f.GetProduct())
                .Type<ProductType2>();

            descriptor
                .Field(f => f.GetProductById(default))
                .Argument("brand", a => a.Type<NonNullType<BrandInputType>>());

            //descriptor
            //    .Field("GetBrandResponse")
            //    .Type<ResponseType<BrandType>>();
            
        }
    }
}
