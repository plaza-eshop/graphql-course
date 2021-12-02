using GraphQLApp.Api.Models;
using GraphQLApp.Api.Models.Chat;
using GraphQLApp.Models.Chat;
using HotChocolate.Types;

namespace GraphQLApp.Api.Types
{
    public class QueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor
                .Field(f => f.GetMessagesAsync(default))
                .Name("GetMessagesAsync");

            descriptor
                .Field("GetMessagesFromService")
                .Argument("chatId",a => a.Type<IntType>())
                .Resolve(context =>
                {
                    var chatId = context.ArgumentValue<int>("chatId");
                    var repository = context.Service<IChatRepository>();
                    var query = context.Parent<Query>();
                    var token = query.Token;

                    return repository.GetMessages(chatId);
                });

            descriptor
                .Field("GetMessagesWithService")
                .Argument("chatId", a => a.Type<IntType>())
                .Argument("userId", a => a.Type<StringType>())
                .ResolveWith<ChatService>(s => s.GetMessages(default));
        }
    }
}
