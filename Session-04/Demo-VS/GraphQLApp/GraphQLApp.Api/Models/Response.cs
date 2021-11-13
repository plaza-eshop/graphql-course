using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApp.Api.Models
{
    public class Response<T>
    {
        public string State { get; set; }

        public T Payload { get; set; }
    }
}
