using LojasMoveis.Models;
using LojasMoveis.Repositories.Interfaces;
using LojasMoveis.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LojasMoveis.Controllers
{
    public class MovelController : Controller
    {
        private readonly IMovelRepository _movelRepository;
        public MovelController(IMovelRepository movelRepository)
        {
            _movelRepository = movelRepository;
        }

        public IActionResult List(string categoria)
        {
            IEnumerable<Movel> moveis;
            string categoriaAtual = string.Empty;
            if (string.IsNullOrEmpty(categoria))
            {
                moveis = _movelRepository.Moveis.OrderBy(l => l.MovelId);
                categoriaAtual = "Todos os móveis";
            }
            else
            {
                if (string.Equals("planejados", categoria, StringComparison.OrdinalIgnoreCase))
                {
                    moveis = _movelRepository.Moveis
                        .Where(l => l.Categoria.CategoriaNome.Equals("planejados"))
                        .OrderBy(l => l.Nome);
                }
                else
                {
                    moveis = _movelRepository.Moveis
                      .Where(l => l.Categoria.CategoriaNome.Equals("escritório"))
                      .OrderBy(l => l.Nome);
                }
                categoriaAtual = categoria;

            }

            var moveisListViewModel = new MovelListViewModel
            {
                Moveis = moveis,
                CategoriaAtual = categoriaAtual
            };

            return View(moveisListViewModel);
        }
    }
}