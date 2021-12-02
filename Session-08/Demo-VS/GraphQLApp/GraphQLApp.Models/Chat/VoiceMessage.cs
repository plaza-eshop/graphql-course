using System;

namespace GraphQLApp.Models.Chat
{
    public class VoiceMessage : IMessage
    {
        public int Id { get; set; }
        public DateTime SendDate { get; set; }
        public int DurationInSeconds { get; set; }
        public string AudioFileUrl { get; set; }
    }

}
