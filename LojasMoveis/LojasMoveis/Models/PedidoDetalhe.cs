﻿using LojasMoveis.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojasMoveis.Models
{
    public class PedidoDetalhe
    {
        public int PedidoDetalheId { get; set; }
        public int PedidoId { get; set; }
        public int MovelId { get; set; }
        public int Quantidade { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }

        public virtual Movel Movel { get; set; }
        public virtual Pedido Pedido { get; set; }
    }
}
