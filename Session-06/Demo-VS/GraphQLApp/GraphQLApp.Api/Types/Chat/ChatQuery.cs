using GraphQLApp.Models.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApp.Api.Types.Chat
{
    public class ChatQuery
    {
        public List<IMessage> GetMessages()
        {
            return new List<IMessage>{
                new TextMessage
                {
                    Id = 1,
                    SendDate = DateTime.Now,
                    Text = "test message ..."
                },
                new VoiceMessage
                {
                    Id = 2,
                    SendDate = DateTime.Now,
                    DurationInSeconds = 30,
                    AudioFileUrl = "http://www.google.com"
                }
            };
        }
    }
}
