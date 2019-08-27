using Autofac;
using Autofac.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using appIn = GhartemSolutions.Templates.ApiBasic.Domain.Business;
using app = GhartemSolutions.Templates.ApiBasic.App;
using repoIn = GhartemSolutions.Templates.ApiBasic.Domain.Infrastructure;
using repo = GhartemSolutions.Templates.ApiBasic.Insfrastructure;

namespace GhartemSolutions.Templates.ApiBasic.Api
{
    /// <summary>
    /// 
    /// </summary>
    public class AutofacConfig
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        public static void Register(HttpConfiguration config)
        {
            var builder = new ContainerBuilder();

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .AsImplementedInterfaces();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterWebApiFilterProvider(config);

            BusinessBuilder(builder);
            InfrastructureBuilder(builder);

            builder.RegisterType<Filters.ExceptionFilter>()
                .AsWebApiExceptionFilterFor<ApiController>()
                .SingleInstance();

            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        private static void BusinessBuilder(ContainerBuilder builder)
        {
            builder.RegisterType<app.Pacote>().As<appIn.IPacote>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        private static void InfrastructureBuilder(ContainerBuilder builder)
        {
            builder.RegisterType<repo.Pacote>().As<repoIn.IPacote>();
        }       
    }
}