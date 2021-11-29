using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQLApp.Models
{
    public interface IMessage
    {
        public string Text { get; set; }
    }

    public class TextMessage : IMessage
    {
        public string Text { get; set; }

        public int Id { get; set; }
    }

    public interface IDatedMessage : IMessage
    {
        public DateTime SendDate { get; set; }
    }

    public class DatedMessage : IMessage
    {
        public DateTime SendDate { get; set; }
        public string Text { get; set; }
    }
}
