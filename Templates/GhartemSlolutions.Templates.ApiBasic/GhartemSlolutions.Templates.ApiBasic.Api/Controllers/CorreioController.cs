using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GhartemSolutions.Templates.ApiBasic.Api.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [SwaggerResponse(HttpStatusCode.BadRequest, Description = "Requisição inválida")]
    [SwaggerResponse(HttpStatusCode.InternalServerError, Description = "Erro interno de servidor")]
    [SwaggerResponse(HttpStatusCode.NotFound, Description = "A página requerida é inexistente")]
    [RoutePrefix("Correio")]
    public class CorreioController : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(string), Description = "Buscar por id")]
        //[Route("{id}")]
        public IHttpActionResult Get()
        {
            return Ok("Sucesso");
        }
    }
}
