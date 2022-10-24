using System;
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
        public IEnumerable<Evento> _evento = new Evento[]{ 
                new Evento{
         
                EventoId = 1,
                Tema = "Angular 11 e .NET 5",
                local = "Belo Horizonte",
                Lote = "1ª lote",
                QtdPessoas = 250,
                DataEvento =DateTime.Now.AddDays(2).ToString("dd/mm/yyyy"),
                ImagemURL ="foto.png"


                },

                new Evento{
         
                EventoId = 1,
                Tema = "Angular e suas Novidades",
                local = "São Paulo",
                Lote = "2ª lote",
                QtdPessoas = 350,
                DataEvento =DateTime.Now.AddDays(3).ToString("dd/mm/yyyy"),
                ImagemURL ="foto1.png"
                
                }

            };
        

        
       
        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento; 
            
            
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById( int id)
        {
            return _evento.Where(Evento => Evento.EventoId ==id); 
            
            
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

        
    }
}

