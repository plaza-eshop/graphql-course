using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQLApp.Models.Chat
{
    public interface IMessage
    {
        int Id { get; set; }

        DateTime SendDate { get; set; }
    }

}
