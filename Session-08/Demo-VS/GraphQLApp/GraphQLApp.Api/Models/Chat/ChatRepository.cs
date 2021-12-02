using GraphQLApp.Models.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApp.Api.Models.Chat
{
    public class ChatRepository : IChatRepository
    {
        public List<TextMessage> GetMessages(int chatId)
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
    }
}
