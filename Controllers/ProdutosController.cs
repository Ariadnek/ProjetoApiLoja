using LojaAPI.Data;
using LojaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

[Route("api/[controller]")]
[ApiController]
public class ProdutosController : ControllerBase
{
    private readonly LojaContext _context;

    public ProdutosController(LojaContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult PostProdutos([FromBody] List<Produto> produtos)
    {
        try
        {
            foreach (var produto in produtos)
            {
                _context.Produtos.Add(produto);
            }
            _context.SaveChanges();
            return Ok(produtos);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
}


