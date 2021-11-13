using GraphQLApp.Models;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApp.Api.Types
{
    public class BrandType : ObjectType<Brand>
    {
    }

    public class BrandInputType : InputObjectType<Brand>
    {
    }
}
