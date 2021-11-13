using GraphQLApp.Api.Models;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApp.Api.Types
{
    public class ResponseType<TPayload> : ObjectType<Response<TPayload>>
        where TPayload: class, IObjectType
    {
        protected override void Configure(IObjectTypeDescriptor<Response<TPayload>> descriptor)
        {
            descriptor
                .Field(f => f.Payload)
                .Type<TPayload>();
        }
    }
}
