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
        Productos entProducto = new Productos();
        ProductosBR objBR = new ProductosBR();
        string message = string.Empty;

        // GET: api/<ProductosController>
        [HttpGet]
        public List<Productos> Get()
        {
            DataTable ds = objBR.ProductosCrud("LISTAR", entProducto);
            List<Productos> list = new List<Productos>();
            foreach (DataRow dr in ds.Rows)
            {
                list.Add(new Productos
                {
                    Id = Convert.ToInt32(dr["Id"]),
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

        // GET api/<ProductosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductosController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
