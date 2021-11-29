using GraphQLApp.Models.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApp.Api.Models.Chat
{
    public class ChatQuery
    {
        public List<string> GetMessages()
        {
            return new List<string>{
                "message 1",
                "message 2"
            };
        }


        public async Task<List<string>> GetPostsAsync()
        {

            return new List<string>{
                "message 1",
                "message 2"
            };
        }
    }
}
