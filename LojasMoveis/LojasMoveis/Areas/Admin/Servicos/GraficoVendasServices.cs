using LojasMoveis.Context;
using LojasMoveis.Models;

namespace LojasMoveis.Areas.Admin.Servicos
{
    public class GraficoVendasService
    {
        private readonly AppDbContext context;

        public GraficoVendasService(AppDbContext context)
        {
            this.context = context;
        }

        public List<MovelGrafico> GetVendasMoveis(int dias = 360)
        {
            var data = DateTime.Now.AddDays(-dias);

            var moveis = (from pd in context.PedidoDetalhes
                           join l in context.Moveis on pd.MovelId equals l.MovelId
                           where pd.Pedido.PedidoEnviado >= data
                           group pd by new { pd.MovelId, l.Nome }
                           into g
                           select new
                           {
                               MovelNome = g.Key.Nome,
                               MoveisQuantidade = g.Sum(q => q.Quantidade),
                               MoveisValorTotal = g.Sum(a => a.Preco * a.Quantidade)
                           });

            var lista = new List<MovelGrafico>();

            foreach (var item in moveis)
            {
                var movel = new MovelGrafico();
                movel.MovelNome = item.MovelNome;
                movel.MoveisQuantidade = item.MoveisQuantidade;
                movel.MoveisValorTotal = item.MoveisValorTotal;
                lista.Add(movel);
            }
            return lista;
        }
    }
}
