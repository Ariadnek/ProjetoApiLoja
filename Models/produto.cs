using System;

namespace LojaAPI.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string? Nome_Produto { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
    }
}

