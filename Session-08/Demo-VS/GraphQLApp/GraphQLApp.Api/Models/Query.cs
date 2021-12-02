using GraphQLApp.Models.Chat;
using HotChocolate;
using HotChocolate.Resolvers;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GraphQLApp.Api.Models
{
    public class Query
    {
        private readonly IChatRepository repository;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IResolverContext resolverContext;

        public string Token { get; set; }


        public Query(IChatRepository repository, IHttpContextAccessor httpContextAccessor, IResolverContext resolverContext)
        {
            this.repository = repository;
            this.httpContextAccessor = httpContextAccessor;
            this.resolverContext = resolverContext;
        }


        private List<TextMessage> GetMessages()
        {
            return new List<TextMessage>()
                {
                    new TextMessage
                    {
                        Id = 1,
                        SendDate = DateTime.Now,
                        Text = "text message 1"
                    },
                    new TextMessage
                    {
                        Id = 2,
                        SendDate = DateTime.Now,
                        Text = "text message 2"
                    },
                    new TextMessage
                    {
                        Id = 3,
                        SendDate = DateTime.Now,
                        Text = "text message 3"
                    }
                };
        }

        public List<TextMessage> GetMessagesAsync(int chatId)
        {
            return repository.GetMessages(chatId);
        }

    }
}
