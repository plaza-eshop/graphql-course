using GraphQLApp.Models.Chat;
using HotChocolate.Types;

namespace GraphQLApp.Api.Types.Chat
{
    public class VoiceMessageType : ObjectType<VoiceMessage>
    {
        protected override void Configure(IObjectTypeDescriptor<VoiceMessage> descriptor)
        {
            descriptor
                .Implements<MessageType>();
        }
    }
}
