using GraphQLApp.Models.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApp.Api.Types.Blog
{
    public class BlogQuery
    {
        public object GetPosts()
        {
            //return new List<object>
            //{
            //    new TextPost
            //    {
            //        Text = "text post"
            //    },
            //    new ImagePost
            //    {
            //        ImageUrl = "http://www.google.com"
            //    }
            //};

            return new TextPost
            {
                Text = "text post"
            };
        }
    }
}
