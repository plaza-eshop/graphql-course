using GraphQLApp.Api.Models;
using GraphQLApp.Api.Models.Chat;
using HotChocolate.Types;

namespace GraphQLApp.Api.Types.Chat
{
    public class ChatQueryExtension : ObjectTypeExtension<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor
                .Field("ChatQuery")
                .Type<ChatQueryType>()
                .Resolve(context => new ChatQuery());
        }
    }
}
