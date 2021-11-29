using GraphQLApp.Api.Models.Chat;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApp.Api.Types.Chat
{
    public class ChatQueryType : ObjectType<ChatQuery>
    {
        protected override void Configure(IObjectTypeDescriptor<ChatQuery> descriptor)
        {
            descriptor
                .Field(f => f.GetMessages())
                .Deprecated("this method is deprecated. please use Getposts method instead.")
                .Name("GetMessages");


            descriptor
                .Field("GetLastMessage")
                .Type<StringType>()
                .Resolve(context => "last message");

            descriptor
                .Field("GetLastMessageAsync")
                .Type<StringType>()
                .Resolve((context, ct) => "last message");
        }
    }
}
