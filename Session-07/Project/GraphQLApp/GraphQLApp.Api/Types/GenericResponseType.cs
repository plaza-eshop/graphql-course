using GraphQLApp.Api.Models;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApp.Api.Types
{
    public class GenericResponseType<TSchemaType> : ObjectType<GenericResponse<TSchemaType>> 
        where TSchemaType : class, IOutputType
    {
        protected override void Configure(IObjectTypeDescriptor<GenericResponse<TSchemaType>> descriptor)
        {
            descriptor
                .Field(f => f.Payload)
                .Type<TSchemaType>();
        }
    }


}
