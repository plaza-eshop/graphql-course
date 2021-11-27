using GraphQLApp.Models;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApp.Api.Types
{
    public class MessageType : InterfaceType<IMessage>
    {
        protected override void Configure(IInterfaceTypeDescriptor<IMessage> descriptor)
        {
            descriptor
                .Name("Message");
        }
    }

    public class TextMessageType : ObjectType<TextMessage>
    {
        protected override void Configure(IObjectTypeDescriptor<TextMessage> descriptor)
        {
            descriptor
                .Name("TextMessage");

            descriptor
                .Implements<MessageType>();
        }
    }

    public class DatedMessageType : ObjectType<DatedMessage>
    {
        protected override void Configure(IObjectTypeDescriptor<DatedMessage> descriptor)
        {
            descriptor
                .Implements<MessageType>();
        }
    }
}
