using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class PaginaInicioController : Controller
    {
        // GET: PaginaInicio
        public ActionResult Index()
        {
           
            //List<ML.Promocion> seccionPromocion = new List<ML.Promocion>();
            //List<ML.Producto> seccion2Productos = new List<ML.Producto>();

       
            //using (var client = new HttpClient())
            //{
            //    client.BaseAddress = new Uri("http://localhost:13107/");

            //    var responseTask = client.GetAsync("/Producto/GetMostrar");
            //    responseTask.Wait();

            //    var result = responseTask.Result;

            //    if (result.IsSuccessStatusCode)
            //    {
            //        var readTask = result.Content Content.ReadAsAsync<ML.Result>();
            //        readTask.Wait();

            //        foreach (var resultItem in readTask.Result.Objects)
            //        {
            //            ML.Materia resultItemList = Newtonsoft.Json.JsonConvert.DeserializeObject<ML.Materia>(resultItem.ToString());
            //            resultMateria.Objects.Add(resultItemList);
            //        }
            //    }
            //    materia.Materias = resultMateria.Objects;
            //}

            return View();
        }
        //public JsonResult SeccionMostrar()
        //{
        //    List<ML.Producto> seccionMostrar = new List<ML.Producto>();

        //    var jsonResult = JsonConvert.SerializeObject(seccionMostrar);

        //    return Json{ jsonResult,JsonRequestBehavior.AllowGet };
        //}
    }
}