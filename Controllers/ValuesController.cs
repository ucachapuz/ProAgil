using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProAgil.WebAPI.Data;
using ProAgil.WebAPI.Model;

namespace ProAgil.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController
    {
        public readonly DataContext _context;

        public ValuesController(DataContext  context)
        {
            _context = context;
        } 

        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Produto>>> GetProdutos()
        public async Task <ActionResult<IEnumerable<Evento>>>  Get()
        {
            try
            { 
                
                return await _context.Eventos.ToListAsync();
                
            }
            catch (System.Exception)
            {                
                throw;
            }
             
             
        }
        [HttpGet("{id}")]
        public ActionResult<Evento> Get(int id)
        {

            return _context.Eventos.FirstOrDefault(x => x.EventoId == id) ;
        }

    }
}