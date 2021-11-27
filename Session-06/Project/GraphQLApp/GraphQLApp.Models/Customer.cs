using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQLApp.Models
{
    public abstract class CustomerBase
    {
        public int Id { get; set; }
    }

    public class Company: CustomerBase
    {
        public string Name { get; set; }
    }

    public class Person : CustomerBase
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }
    }


}
