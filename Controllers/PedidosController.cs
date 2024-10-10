using LojaAPI.Data;
using LojaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System; 

[Route("api/[controller]")]
[ApiController]
public class PedidosController : ControllerBase
{
    private readonly LojaContext _context;

    public PedidosController(LojaContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult PostPedidos([FromBody] List<Pedido> pedidos)
    {
        try
        {
            foreach (var pedido in pedidos)
            {
                _context.Pedidos.Add(pedido);
            }
            _context.SaveChanges();
            return Ok(pedidos);
        }
        catch (Exception ex)
        {
        
            return StatusCode(500, new { error = ex.Message, stackTrace = ex.StackTrace });
        }
    }
}
