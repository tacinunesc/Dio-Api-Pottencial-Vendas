using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dio_bootcamp_Pottencial_dotnet.Context;
using Dio_bootcamp_Pottencial_dotnet.Models;

namespace Dio_bootcamp_Pottencial_dotnet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendaController : ControllerBase
    {
        private readonly VendaContext _context;
        public VendaController(VendaContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Registrar(Venda venda)
        {
            _context.Add(venda);
            _context.SaveChanges();
            return Ok(venda);
        }

       [HttpGet("{id}")]
       public IActionResult BuscarPorId(int id)
       {
            var venda = _context.Vendas.Find(id);

            if (venda == null)
                return NotFound();

            return Ok(venda);
       }

       [HttpPut("{id}")]
       public IActionResult Atualizar(int id, Venda venda)
       {
        var vendaBanco = _context.Vendas.Find(id);

        if(vendaBanco == null)
        return NotFound();

        if(venda.Data == DateTime.MinValue)
            return BadRequest(new{Erro = "A data da tarefa não pode ser vazia"});

        vendaBanco.Vendedor = venda.Vendedor;
        vendaBanco.ItensVendidos = venda.ItensVendidos;
        vendaBanco.Status = venda.Status;
        vendaBanco.Data = venda.Data;

        _context.Vendas.Update(vendaBanco);
        _context.SaveChanges();

        return Ok(vendaBanco);
       }
    }
}