using GraphQLApp.Models.Chat;
using HotChocolate.Types;

namespace GraphQLApp.Api.Types.Chat
{
    public class TextMessageType : ObjectType<TextMessage>
    {
        protected override void Configure(IObjectTypeDescriptor<TextMessage> descriptor)
        {
            descriptor
                .Implements<MessageType>();
        }
    }
}
