using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Marca
    {
        public static ML.Result MarcaGetAll()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.ASantiagoEvalucacionTecnicaLumenEntities context = new DL.ASantiagoEvalucacionTecnicaLumenEntities())
                {
                    var get = context.MarcaGetAll().ToList();
                    result.Objects = new List<object>();
                    if (get != null)
                    {
                        foreach (var obj in get)
                        {
                            ML.Marca marca = new ML.Marca();
                            marca.IdMarca = obj.IdMarca;
                            marca.NombreMarca = obj.NombreMarca;
                            marca.MarcaMostrarEnElHome = obj.MarcaMostrarEnElHome.Value;
                            
                            result.Objects.Add(marca);
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
