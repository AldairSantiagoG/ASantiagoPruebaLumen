using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SL.Controllers
{
    
    public class ProductoController : ApiController
    {
        // GET: api/Producto
        [HttpGet]
        [Route("Producto/GetMostrar")]
        public IHttpActionResult ProductoGetAllMostrar()
        {
            ML.Result result = BL.Producto.ProductoGetAllMostrar();
            if (result.Correct)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
           
        }

        [HttpGet]
        public IHttpActionResult ProductoGetAll()
        {
            ML.Result result = BL.Producto.ProductoGetAll();
            if (result.Correct)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpGet]
        public IHttpActionResult ProductoGetByMarca(int id)
        {
            ML.Result result = BL.Producto.ProductoGetAll();
            if (result.Correct)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpGet]
        public IHttpActionResult ProductoGetByNombre(string nombreProducto)
        {
            ML.Result result = BL.Producto.ProductoGetByNombre(nombreProducto);
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
