using BR;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CatalogoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        ProductosBR objBR = new ProductosBR();
        Categorias entCategoria = new Categorias();
        Productos entProducto = new Productos();

        // GET: api/<ProductosController>
        [HttpGet]
        public List<Productos> Get()
        {
            DataTable dt = objBR.ProductosCrud("LISTAR", entProducto);
            List<Productos> list = new List<Productos>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Productos
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    Nombre = dr["Nombre"].ToString(),
                    Descripcion = dr["Descripcion"].ToString(),
                    Categoria = dr["Categoria"].ToString(),
                    Id_Categoria = Convert.ToInt32(dr["Id_Categoria"]),
                    Imagen = dr["Imagen"].ToString(),
                    Stock = Convert.ToInt32(dr["Stock"]),
                    Precio = Convert.ToInt32(dr["Precio"]),
                    Estado = Convert.ToBoolean(dr["Estado"])
                });
            }
            return list;
        }

        // GET: api/<ProductosController>/ddl
        [HttpGet]
        [Route("ddl")]
        public List<Categorias> GetDdl()
        {
            DataSet ds = objBR.CargarDdl_Productos();
            DataTable dt = ds.Tables[0];
            List<Categorias> list = new List<Categorias>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Categorias
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    Valor = dr["Valor"].ToString()
                });
            }
            return list;
        }

        // GET api/<ProductosController>
        [HttpGet("{parametroBusqueda}")]
        public List<Productos> Get(string parametroBusqueda)
        {
            entProducto.Nombre = parametroBusqueda;
            entProducto.Descripcion = parametroBusqueda;
            entProducto.Categoria = parametroBusqueda;
            DataTable dt = objBR.ProductosCrud("BUSCAR", entProducto);
            List<Productos> list = new List<Productos>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Productos
                {
                    //Id = Convert.ToInt32(dr["Id"]),
                    Nombre = dr["Nombre"].ToString(),
                    Descripcion = dr["Descripcion"].ToString(),
                    Categoria = dr["Categoria"].ToString(),
                    Imagen = dr["Imagen"].ToString(),
                    Stock = Convert.ToInt32(dr["Stock"]),
                    Precio = Convert.ToInt32(dr["Precio"]),
                    Estado = Convert.ToBoolean(dr["Estado"])
                });
            }
            return list;
        }

        // POST api/<ProductosController>/
        [HttpPost]
        public string Post([FromBody] Productos entProducto)
        {
            string msg = string.Empty;
            try
            {
                DataTable dt = new DataTable();
                dt = objBR.ProductosCrud("INSERTAR", entProducto);
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["SW"].ToString() != "0")
                    {
                        return msg = (dt.Rows[0]["Mensaje"].ToString());
                    }
                    msg = (dt.Rows[0]["Mensaje"].ToString());
                }
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }

        // PUT api/<ProductosController>/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] Productos entProducto)
        {
            string msg = string.Empty;
            try
            {
                entProducto.Id = id;
                DataTable dt = new DataTable();
                dt = objBR.ProductosCrud("ACTUALIZAR", entProducto);
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["SW"].ToString() != "0")
                    {
                        return msg = (dt.Rows[0]["Mensaje"].ToString());
                    }
                    msg = (dt.Rows[0]["Mensaje"].ToString());
                }
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }

        // DELETE api/<ProductosController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            string msg = string.Empty;
            try
            {
                entProducto.Id = id;
                DataTable dt = new DataTable();
                dt = objBR.ProductosCrud("ELIMINAR", entProducto);
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["SW"].ToString() != "0")
                    {
                        return msg = (dt.Rows[0]["Mensaje"].ToString());
                    }
                    msg = (dt.Rows[0]["Mensaje"].ToString());
                }
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }
    }
}
