using GraphQLApp.Api.Models;
using HotChocolate.Types;

namespace GraphQLApp.Api.Types
{
    public class QueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {

            //descriptor.BindFieldsExplicitly();

            //descriptor
            //    .Description("this is the root query of demo project");

            //descriptor
            //    .Field(f => f.GetProduct())



        }
    }
}
