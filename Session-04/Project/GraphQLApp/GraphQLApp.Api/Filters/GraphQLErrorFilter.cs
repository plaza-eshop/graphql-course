using HotChocolate;
using HotChocolate.Language;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApp.Api.Filters
{
    public class GraphQLErrorFilter : IErrorFilter
    {
        public IError OnError(IError error)
        {
            var extensions = new Dictionary<string, object>();
            extensions.Add("My Code", "My Code Value");
            extensions.Add(nameof(error.Code), "Code Value");

            var graphQLError = new ErrorBuilder()
                .SetMessage(error.Exception.Message)
                .SetCode("My Code")
                .Build()
                .WithExtensions(extensions);
            return graphQLError;
        }
    }

}
