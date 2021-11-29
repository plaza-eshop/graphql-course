using GraphQLApp.Api.Models;
using GraphQLApp.Api.Models.Blog;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApp.Api.Types.Blog
{
    public class BlogQueryType : ObjectType<BlogQuery>
    {

    }


    public class BlogQueryExtension : ObjectTypeExtension<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor
                .Field("BlogPostQuery")
                .Type<BlogQueryType>()
                .Resolve(context => new BlogQuery());
        }
    }
}
