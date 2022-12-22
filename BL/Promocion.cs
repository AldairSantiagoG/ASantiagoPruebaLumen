using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Promocion
    {
        public ML.Result PromocionGetAllActiva()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.ASantiagoEvalucacionTecnicaLumenEntities context = new DL.ASantiagoEvalucacionTecnicaLumenEntities())
                {
                    var get = context.PromocionGetAllActiva().ToList();
                    result.Objects = new List<object>();
                    if (get != null)
                    {
                        foreach (var obj in get)
                        {
                            ML.Promocion promocion = new ML.Promocion();
                            promocion.IdPromocion = obj.IdPromocion;
                            promocion.NombrePromocion = obj.NombrePromocion;
                            promocion.FechaInicio = obj.FechaInicio.Value;
                            promocion.FechaTermino = obj.FechaTermino.Value;

                            result.Objects.Add(promocion);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }

            return result;
        }
    }
}
