using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Producto
    {   
        public static ML.Result ProductoGetAllMostrar()
        {
            ML.Result result = new ML.Result();

            try
            {
                using(DL.ASantiagoEvalucacionTecnicaLumenEntities context = new DL.ASantiagoEvalucacionTecnicaLumenEntities())
                {
                    var get = context.ProductoGetAllMostrar().ToList();
                    result.Objects = new List<object>();
                    if(get!= null)
                    {
                        foreach(var obj in get)
                        {
                            ML.Producto producto = new ML.Producto();
                            producto.Sku = obj.Sku;
                            producto.NombreProducto = obj.NombreProducto;
                            producto.Precio = obj.Precio.Value;
                            producto.Marca = new ML.Marca();
                            producto.Marca.IdMarca = obj.IdMarca;
                            producto.Marca.NombreMarca = obj.NombreMarca;
                            producto.ProductoMostrarEnElHome = obj.ProductoMostrarEnElHome.Value;

                            result.Objects.Add(producto);
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
        public static ML.Result ProductoGetAll()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.ASantiagoEvalucacionTecnicaLumenEntities context = new DL.ASantiagoEvalucacionTecnicaLumenEntities())
                {
                    var get = context.ProductoGetAll().ToList();
                    result.Objects = new List<object>();
                    if (get != null)
                    {
                        foreach (var obj in get)
                        {
                            ML.Producto producto = new ML.Producto();
                            producto.Sku = obj.Sku;
                            producto.NombreProducto = obj.NombreProducto;
                            producto.Precio = obj.Precio.Value;
                            producto.Marca = new ML.Marca();
                            producto.Marca.IdMarca = obj.IdMarca;
                            producto.Marca.NombreMarca = obj.NombreMarca;
                            producto.ProductoMostrarEnElHome = obj.ProductoMostrarEnElHome.Value;

                            result.Objects.Add(producto);
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
        public static ML.Result ProductoGetByMarca(int idMarca)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.ASantiagoEvalucacionTecnicaLumenEntities context = new DL.ASantiagoEvalucacionTecnicaLumenEntities())
                {
                    var get = context.ProductoGetByMarca(idMarca).ToList();
                    result.Objects = new List<object>();
                    if (get != null)
                    {
                        foreach (var obj in get)
                        {
                            ML.Producto producto = new ML.Producto();
                            producto.Sku = obj.Sku;
                            producto.NombreProducto = obj.NombreProducto;
                            producto.Precio = obj.Precio.Value;
                            producto.Marca = new ML.Marca();
                            producto.Marca.IdMarca = obj.IdMarca;
                            producto.Marca.NombreMarca = obj.NombreMarca;
                            producto.ProductoMostrarEnElHome = obj.ProductoMostrarEnElHome.Value;

                            result.Objects.Add(producto);
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
        public static ML.Result ProductoGetByNombre(string nombreProducto)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.ASantiagoEvalucacionTecnicaLumenEntities context = new DL.ASantiagoEvalucacionTecnicaLumenEntities())
                {
                    var get = context.ProductoGetByNombre(nombreProducto).ToList();
                    result.Objects = new List<object>();
                    if (get != null)
                    {
                        foreach (var obj in get)
                        {
                            ML.Producto producto = new ML.Producto();
                            producto.Sku = obj.Sku;
                            producto.NombreProducto = obj.NombreProducto;
                            producto.Precio = obj.Precio.Value;
                            producto.Marca = new ML.Marca();
                            producto.Marca.IdMarca = obj.IdMarca;
                            producto.Marca.NombreMarca = obj.NombreMarca;
                            producto.ProductoMostrarEnElHome = obj.ProductoMostrarEnElHome.Value;

                            result.Objects.Add(producto);
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
