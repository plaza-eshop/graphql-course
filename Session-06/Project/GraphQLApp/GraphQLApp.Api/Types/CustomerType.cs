using GraphQLApp.Models;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApp.Api.Types
{
    public class CustomerType : InterfaceType<CustomerBase>
    {

    }

    public class CompanyType : ObjectType<Company>
    {
        protected override void Configure(IObjectTypeDescriptor<Company> descriptor)
        {
            descriptor
                .Implements<CustomerType>();
        }
    }

    public class PersonType : ObjectType<Person>
    {
        protected override void Configure(IObjectTypeDescriptor<Person> descriptor)
        {
            descriptor
                .Implements<CustomerType>();
        }
    }
}
