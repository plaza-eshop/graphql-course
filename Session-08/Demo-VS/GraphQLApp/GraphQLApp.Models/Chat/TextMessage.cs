using System;

namespace GraphQLApp.Models.Chat
{
    public class TextMessage : IMessage
    {
        public int Id { get; set; }
        public DateTime SendDate { get; set; }
        public string Text { get; set; }

    }

}
