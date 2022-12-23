using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SL.Controllers
{
    public class MarcaController : ApiController
    {
        // GET: api/Marca
        [HttpGet]
        [Route("Marca/GetAll")]
        public IHttpActionResult GetAllMarca()
        {
            ML.Result result = BL.Marca.MarcaGetAll();
            if (result.Correct)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }

        }
    }
}
