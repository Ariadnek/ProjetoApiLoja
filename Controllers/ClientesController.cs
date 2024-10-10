using LojaAPI.Data;
using LojaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

[Route("api/[controller]")]
[ApiController]
public class ClientesController : ControllerBase
{
    private readonly LojaContext _context;

    public ClientesController(LojaContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult PostClientes([FromBody] List<Cliente> clientes)
    {
        try
        {
            foreach (var cliente in clientes)
            {
                _context.Clientes.Add(cliente);
            }
            _context.SaveChanges();
            return Ok(clientes);
        }
        catch (Exception ex)
        {
        
            return StatusCode(500, new { error = ex.Message, stackTrace = ex.StackTrace });
        }
    }
}
