using GraphQLApp.Api.Filters;
using GraphQLApp.Api.Models;
using GraphQLApp.Api.Models.Chat;
using GraphQLApp.Api.Types;
using GraphQLApp.Models.Chat;
using HotChocolate.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GraphQLApp.Api
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddHttpContextAccessor();
            services
                .AddSingleton<IChatRepository, ChatRepository>();


            services
                .AddGraphQLServer()
                .AddQueryType<QueryType>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints
                    .MapGraphQL()
                    .WithOptions(new GraphQLServerOptions
                    {
                        Tool =
                        {
                            Enable = false
                        }
                    });

                endpoints
                    .MapBananaCakePop("/graphql-ui")
                    .WithOptions(new GraphQLToolOptions
                    {
                        Enable = env.IsDevelopment()
                    });
            });
        }
    }
}
