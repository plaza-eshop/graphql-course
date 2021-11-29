using HotChocolate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApp.Api.Filters
{
    public class CustomErrorFilter : IErrorFilter
    {
        public IError OnError(IError error)
        {
            return new ErrorBuilder()
                .SetMessage(error.Exception.Message)
                .SetCode("my error code")
                .Build();
        }
    }
}
