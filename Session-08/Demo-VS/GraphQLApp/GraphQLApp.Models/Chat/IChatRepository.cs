using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQLApp.Models.Chat
{
    public interface IChatRepository
    {
        List<TextMessage> GetMessages(int chatId);
    }
}
