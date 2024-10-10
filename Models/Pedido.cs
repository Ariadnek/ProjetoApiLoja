using System;

namespace LojaAPI.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public int Id_Cliente { get; set; }
        public int Id_Produto { get; set; }
        public DateTime Data_Pedido { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor_Total { get; set; }
    }
}
