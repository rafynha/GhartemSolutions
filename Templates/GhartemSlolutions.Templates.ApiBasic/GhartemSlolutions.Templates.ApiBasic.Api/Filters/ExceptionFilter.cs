using Autofac.Integration.WebApi;
using GhartemSolutions.Templates.ApiBasic.Domain.Exception;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Filters;

namespace GhartemSolutions.Templates.ApiBasic.Api.Filters
{
    /// <summary>
    /// 
    /// </summary>
    public class ExceptionFilter : ExceptionFilterAttribute, IAutofacExceptionFilter
    {
        private static readonly ILogger log = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Override do OnException
        /// </summary>
        /// <param name="actionExecutedContext"></param>
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            string message = FormatarMensagem(actionExecutedContext);

            if (actionExecutedContext.Exception is NaoEncontradoException)
            {
                //log.Info(actionExecutedContext.Exception, message);
                actionExecutedContext.Response = actionExecutedContext.Request.CreateErrorResponse(HttpStatusCode.NotFound, actionExecutedContext.Exception.Message);
            }
            else if (actionExecutedContext.Exception is ParametrosInvalidosException)
            {
                //log.Warn(actionExecutedContext.Exception, message);
                actionExecutedContext.Response = actionExecutedContext.Request.CreateErrorResponse(HttpStatusCode.BadRequest, actionExecutedContext.Exception.Message);
            }
            else if (actionExecutedContext.Exception is AcessoNegadoException)
            {
                //log.Warn(actionExecutedContext.Exception, message);
                actionExecutedContext.Response = actionExecutedContext.Request.CreateErrorResponse(HttpStatusCode.Forbidden, actionExecutedContext.Exception.Message);
            }
            else
            {
                //log.Error(actionExecutedContext.Exception, message);
                actionExecutedContext.Response = actionExecutedContext.Request.CreateErrorResponse(HttpStatusCode.InternalServerError, actionExecutedContext.Exception.Message);
            }
        }

        #pragma warning disable CS0114
        /// <summary>
        /// 
        /// </summary>
        /// <param name="actionExecutedContext"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task OnExceptionAsync(HttpActionExecutedContext actionExecutedContext, CancellationToken cancellationToken)
        #pragma warning restore CS0114
        {
            OnException(actionExecutedContext);
            return Task.FromResult(0);
        }

        private static string FormatarMensagem(HttpActionExecutedContext actionExecutedContext)
        {
            return string.Format("{0} - {1}", actionExecutedContext.Request.GetID(), actionExecutedContext.Exception.Message);
        }

    }
}