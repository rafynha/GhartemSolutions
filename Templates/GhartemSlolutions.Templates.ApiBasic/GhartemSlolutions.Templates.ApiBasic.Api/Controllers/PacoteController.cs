using GhartemSolutions.Templates.ApiBasic.Domain.Business;
using GhartemSolutions.Templates.ApiBasic.Domain.Model.Pacote;
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
    [RoutePrefix("Pacote")]
    public class PacoteController : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        private IPacote _pacoteBusiness { get; set; }
        /// <summary>
        /// Construtor
        /// </summary>
        public PacoteController(IPacote pacoteBusiness)
        {
            this._pacoteBusiness = pacoteBusiness;
        }

        /// <summary>
        /// Buscar pacote
        /// </summary>
        /// <returns></returns>
        [Route("{id}/Rastreio")]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(List<Pacote>), Description = "Buscar por id de rastreio")]
        public IHttpActionResult Get(string id)
        {
            if (ModelState.IsValid)
            {
                //log.Trace("Iniciando método CondicaoComercial");
                var retorno = _pacoteBusiness.Rastrear(id);
                return Ok(retorno);
            }
            else
            {
                return BadRequest(ModelState);
            }
            
        }
    }
}
