using AarekhLabs.AspNetCore.Api.Health.Models;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Net;

namespace AarekhLabs.Memcached.Api.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/health")]
    public class HealthController : Controller
    {
        /// <summary>
        /// Returns application heartbeat status.
        /// </summary>
        /// <remarks>
        /// This API can be used for monitoring the application running status. 
        /// For example, load balancers can use for application monitoring.
        /// </remarks>
        /// <returns>Returns <code> { "heartbeat":"OK"} </code> always.</returns>
        [HttpGet("heartbeat")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [SwaggerResponse(200, typeof(HeartbeatModel), "Returns application heartbeat status.")]
        public IActionResult Heartbeat()
        {            
            return Ok(new HeartbeatModel());
        }
    }
}
