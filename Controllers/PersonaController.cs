using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RiadaLite.Models;
using RiadaLite.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RiadaLite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly AppDBContext _context;
        public PersonaController(AppDBContext context)
        {
            _context = context;
        }
        // GET: api/<PersonaController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Persona>>> Get()
        {
            return await _context.Persona.ToListAsync();
        }

        // GET api/<PersonaController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Persona>>  GetPerona(int id)
        {
            var persona = await _context.Persona.FindAsync(id);
            if (persona == null)
            {
            return NotFound();
            }

            return persona;
        }

        // POST api/<PersonaController>
        [HttpPost]
        public async Task<ActionResult<Persona>> Post(Persona persona)
        {
            _context.Persona.Add(persona);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Post", new { id = persona.Id }, persona);
        }

        // PUT api/<PersonaController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Persona persona)
        {
            if (id!= persona.Id)
            {
                return BadRequest();
            }
            _context.Entry(persona).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException)
            {
                if (!PersonaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
                
            }
            return NoContent();
        }

        // DELETE api/<PersonaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        private bool PersonaExists(int id)
        {
            return _context.Persona.Any(e => e.Id == id);
        }
    }
}
