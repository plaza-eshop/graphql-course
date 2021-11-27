using GraphQLApp.Models;
using HotChocolate.Types;

namespace GraphQLApp.Api.Types
{
    public class TextContentType : ObjectType<TextContent>
    {

    }

    public class ImageContentType : ObjectType<ImageContent>
    {

    }

    public class PostContentType : UnionType
    {
        protected override void Configure(IUnionTypeDescriptor descriptor)
        {
            descriptor
                .Name("PostContent")
                .Type<TextContentType>()
                .Type<ImageContentType>();

        }
    }
}
