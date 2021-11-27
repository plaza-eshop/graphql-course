using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApp.Api.Types.Blog
{

    public class BlogPostType : UnionType
    {
        protected override void Configure(IUnionTypeDescriptor descriptor)
        {
            descriptor
                .Name("BlogPost")
                .Type<TextPostType>()
                .Type<ImagePostType>();
        }
    }
}
