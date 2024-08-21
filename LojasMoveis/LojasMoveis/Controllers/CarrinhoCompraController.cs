using LojasMoveis.Models;
using LojasMoveis.Repositories.Interfaces;
using LojasMoveis.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LojasMoveis.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private readonly IMovelRepository _movelRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoCompraController(IMovelRepository movelRepository,
            CarrinhoCompra carrinhoCompra)
        {
            _movelRepository = movelRepository;
            _carrinhoCompra = carrinhoCompra;
        }

        public IActionResult Index()
        {
            var itens = _carrinhoCompra.GetCarrinhoCompraItens();
            _carrinhoCompra.CarrinhoCompraItens = itens;

            var carrinhoCompraVM = new CarrinhoCompraViewModel
            {
                CarrinhoCompra = _carrinhoCompra,
                CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal()
            };

            return View(carrinhoCompraVM);
        }
        public IActionResult AdicionarItemNoCarrinhoCompra(int movelId)
        {
            var movelSelecionado = _movelRepository.Moveis
                                    .FirstOrDefault(p => p.MovelId == movelId);

            if (movelSelecionado != null)
            {
                _carrinhoCompra.AdicionarAoCarrinho(movelSelecionado);
            }
            return RedirectToAction("Index");
        }

        public IActionResult RemoverItemDoCarrinhoCompra(int movelId)
        {
            var movelSelecionado = _movelRepository.Moveis
                                    .FirstOrDefault(p => p.MovelId == movelId);

            if (movelSelecionado != null)
            {
                _carrinhoCompra.RemoverDoCarrinho(movelSelecionado);
            }
            return RedirectToAction("Index");
        }
    }
}
