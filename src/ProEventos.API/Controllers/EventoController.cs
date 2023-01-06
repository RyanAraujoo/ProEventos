using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly DataContext _context;
        public EventoController(DataContext context) {
            this._context = context;
        }

         [HttpGet("{id}")]
        public Evento GetById(int id)
        {
           return this._context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
        }

          [HttpGet]
        public IEnumerable<Evento> Get()
        {
           return this._context.Eventos;
        }

        [HttpPost("evento")]
        public string Post() {
            return "exemplo de post";
        }
        [HttpPut("{id, evento}")]
        public string Put(int id, Evento evento) {
         //  _evento.Where(evento => evento.EventoId == id) = evento;
            return $"O evento {id} foi editado com sucesso";
        }
        [HttpDelete("{id}")]
        public Evento Delete(int id) {
            return this._context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
        }
    }
}
