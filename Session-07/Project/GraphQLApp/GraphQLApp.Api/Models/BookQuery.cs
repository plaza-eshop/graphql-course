using GraphQLApp.Api.Types;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApp.Api.Models
{
    public class BookQuery
    {
        public string GetBook()
        {
            return "Book Name";
        }
             
    }

    public class BookQueryType : ObjectType<BookQuery>
    {
        protected override void Configure(IObjectTypeDescriptor<BookQuery> descriptor)
        {
            descriptor
                .Field(f => f.GetBook())
                .Name("GetBook");
        }
    }


    public class BookQueryExtension : ObjectTypeExtension<RootQuery>
    {
        protected override void Configure(IObjectTypeDescriptor<RootQuery> descriptor)
        {
            descriptor
                .Field("BookQuery")
                .Type<BookQueryType>()
                .Resolve(context =>
                {
                    var parent = context.Parent<RootQuery>();
                    return new BookQuery();
                });

        }
    }
}
