using GraphQLApp.Models.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApp.Api.Models.Blog
{
    public class BlogQuery
    {
        public string GetPosts()
        {
            return "blog post 1";
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

            //return new TextPost
            //{
            //    Text = "text post"
            //};
        }
    }
}
