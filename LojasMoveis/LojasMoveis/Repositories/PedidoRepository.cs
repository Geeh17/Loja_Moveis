using LojasMoveis.Context;
using LojasMoveis.Models;
using LojasMoveis.Repositories.Interfaces;

namespace LojasMoveis.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly CarrinhoCompra _carrinhoCompra;

        public PedidoRepository(AppDbContext appDbContext,
            CarrinhoCompra carrinhoCompra)
        {
            _appDbContext = appDbContext;
            _carrinhoCompra = carrinhoCompra;
        }

        public void CriarPedido(Pedido pedido)
        {
            pedido.PedidoEnviado = DateTime.Now;
            _appDbContext.Pedidos.Add(pedido);
            _appDbContext.SaveChanges();

            // Garante que os itens estejam carregados
            var carrinhoCompraItens = _carrinhoCompra.CarrinhoCompraItens
                ?? _carrinhoCompra.GetCarrinhoCompraItens();

            foreach (var carrinhoItem in carrinhoCompraItens)
            {
                // Verifica estoque antes de registrar o item no pedido
                if (!carrinhoItem.Movel.EmEstoque)
                    throw new InvalidOperationException(
                        $"O móvel '{carrinhoItem.Movel.Nome}' não está disponível em estoque.");

                var pedidoDetail = new PedidoDetalhe
                {
                    Quantidade = carrinhoItem.Quantidade,
                    MovelId = carrinhoItem.Movel.MovelId,
                    PedidoId = pedido.PedidoId,
                    Preco = carrinhoItem.Movel.Preco
                };
                _appDbContext.PedidoDetalhes.Add(pedidoDetail);

                // Marca fora de estoque se esgotado (lógica simples — sem controle de quantidade real)
                // Para controle de estoque por quantidade, adicione a coluna QuantidadeEstoque no modelo Movel.
            }

            _appDbContext.SaveChanges();
        }
    }
}
