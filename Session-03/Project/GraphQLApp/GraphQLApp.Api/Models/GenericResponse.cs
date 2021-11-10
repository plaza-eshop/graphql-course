using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApp.Api.Models
{
    public class GenericResponse<TPayload>
    {
        public string Status { get; set; }
        public TPayload Payload { get; set; }
    }
}
