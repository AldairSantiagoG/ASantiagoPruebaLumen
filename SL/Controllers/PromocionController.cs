using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SL.Controllers
{
    public class PromocionController : ApiController
    {
        // GET: api/Promocion
        [HttpGet]
        [Route("Promocion/PromocionActiva")]
        public IHttpActionResult PromocionGetAllActiva()
        {
            ML.Result result = BL.Promocion.PromocionGetAllActiva();
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
