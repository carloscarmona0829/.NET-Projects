
using apiUsuarios.Context;
using apiUsuarios.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apiUsuarios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly AppDbContext context;
        public UsuariosController(AppDbContext context)
        {
            this.context = context; 
        }

        // GET: api/<UsuariosController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.users.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<UsuariosController>/5
        [HttpGet("{id}", Name = "GetUsuario")]
        public ActionResult Get(int id)
        {
            try
            {
                var usuario = context.users.FirstOrDefault(g => g.id == id);
                return Ok(usuario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<UsuariosController>
        [HttpPost]
        public ActionResult Post([FromBody] Usuarios usuario)
        {
            try
            {
                context.users.Add(usuario);
                context.SaveChanges();
                //GetGestro es el Name asignado al metodo Get que lo estamos reutilizando
                return CreatedAtRoute("GetUsuario", new { id = usuario.id }, usuario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<UsuariosController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Usuarios usuario)
        {
            try
            {
                if (usuario.id == id)
                {
                    context.Entry(usuario).State = EntityState.Modified;
                    context.SaveChanges();
                    //GetGestro es el Name asignado al metodo Get que lo estamos reutilizando
                    return CreatedAtRoute("GetUsuario", new { id = usuario.id }, usuario);
                }
                else 
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<UsuariosController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var usuario = context.users.FirstOrDefault(g => g.id == id);
                if (usuario != null)
                {
                    context.users.Remove(usuario);
                    context.SaveChanges();
                    return Ok(id);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
