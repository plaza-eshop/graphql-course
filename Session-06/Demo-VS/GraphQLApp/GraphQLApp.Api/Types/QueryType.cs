using GraphQLApp.Api.Models;
using GraphQLApp.Api.Types.Blog;
using HotChocolate.Types;

namespace GraphQLApp.Api.Types
{
    public class QueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            //descriptor
            //    .Field(f => f.GetPosts())
            //    .Type<BlogPostType>();
        }
    }
}
