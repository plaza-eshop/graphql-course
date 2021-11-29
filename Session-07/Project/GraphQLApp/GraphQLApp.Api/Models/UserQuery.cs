using HotChocolate.Types;

namespace GraphQLApp.Api.Models
{
    public class UserQuery
    {
        public string GetUser()
        {
            return "User Name";
        }

    }

    public class UserQueryType : ObjectType<UserQuery>
    {

    }


    public class UserQueryExtension : ObjectTypeExtension<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor
                .Field("Users")
                .Type<UserQueryType>()
                .Resolve(context =>
                {
                    var parent = context.Parent<Query>();
                    return new UserQuery();
                });

        }
    }
}
