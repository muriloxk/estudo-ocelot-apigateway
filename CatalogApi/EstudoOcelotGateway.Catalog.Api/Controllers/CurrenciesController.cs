using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace EstudoOcelotGateway.Catalog.Api.Controllers
{
    [Route("api/currencies")]
    [ApiController]
    public class CurrenciesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "usd", "inr", "jpy" };
        }
    }
}
