﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
      
        public IEnumerable<Evento> _evento = new Evento[] {
                new Evento () {
                    EventoId = 1,
                    Tema = "Angular e .NET",
                    Local = "Vitoria da Conquista",
                    Lote = "1 lote",
                    QuantPessoas = 120,
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    ImagemUrl = "aa"
                },
                 new Evento () {
                    EventoId = 2,
                    Tema = "Angular e .NET",
                    Local = "Vitoria da Conquista",
                    Lote = "1 lote",
                    QuantPessoas = 120,
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    ImagemUrl = "aa"
                },
                 new Evento () {
                    EventoId = 3,
                    Tema = "Angular e .NET",
                    Local = "Vitoria da Conquista",
                    Lote = "1 lote",
                    QuantPessoas = 120,
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    ImagemUrl = "aa"
                }
           };

         [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
           return _evento.Where(evento => evento.EventoId == id);
        }

          [HttpGet]
        public IEnumerable<Evento> Get()
        {
           return _evento;
        }

        [HttpPost]
        public string Post() {
            return "exemplo de post";
        }
        [HttpPut("{id}")]
        public string Put(int id) {
            return $"Exemplo de PUT com id = {id}";
        }
        [HttpDelete("{id}")]
        public string Delete(int id) {
            return $"O Evento {id} foi excluido com sucesso";
        }
    }
}
