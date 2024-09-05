using LojasMoveis.Models;
using Microsoft.AspNetCore.Mvc;

namespace LojasMoveis.ViewModels
{
    public class PedidoMovelViewModel
    {
       public Pedido Pedido { get; set; }
       public IEnumerable<PedidoDetalhe> PedidoDetalhes { get; set; }
    }
    
}
