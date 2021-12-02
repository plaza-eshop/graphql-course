using GraphQLApp.Models;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApp.Api.Models
{
    public class CustomerQuery
    {
        public List<CustomerBase> GetCustomers()
        {
            return new List<CustomerBase>
            {
                new Company
                {
                    Id = 1,
                    Name = "Plaza"
                },
                new Person
                {
                    Id = 2,
                    FirstName = "Ali",
                    LastName = "Fasih",
                    DateOfBirth = DateTime.Now
                }
            };
        }
    }

    public class CustomerQueryType: ObjectType<CustomerQuery>
    {
        protected override void Configure(IObjectTypeDescriptor<CustomerQuery> descriptor)
        {
            descriptor
                .Field(f => f.GetCustomers())
                .Name("GetCustomers");
        }
    }

    public class CustomerQueryExtension : ObjectTypeExtension<RootQuery>
    {
        protected override void Configure(IObjectTypeDescriptor<RootQuery> descriptor)
        {
            descriptor
                .Field("CustomerQuery")
                .Type<CustomerQueryType>()
                .Resolve(context => new CustomerQuery());
        }
    }
}
