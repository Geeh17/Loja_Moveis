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
                moveis = _movelRepository.Moveis
                    .Where(l => l.Categoria.CategoriaNome.Equals(categoria, StringComparison.OrdinalIgnoreCase))
                    .OrderBy(l => l.Nome);

                categoriaAtual = categoria;
            }

            var moveisListViewModel = new MovelListViewModel
            {
                Moveis = moveis,
                CategoriaAtual = categoriaAtual
            };

            return View(moveisListViewModel);
        }

        public IActionResult Details(int movelId)
        {
            var movel = _movelRepository.Moveis.FirstOrDefault(l => l.MovelId == movelId);
            return View(movel);
        }
        public ViewResult Search(string searchString)
        {
            IEnumerable<Movel> moveis;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(searchString))
            {
                moveis = _movelRepository.Moveis.OrderBy(p => p.MovelId);
                categoriaAtual = "Todos os Móveis";
            }
            else
            {
                moveis = _movelRepository.Moveis
                          .Where(p => p.Nome.ToLower().Contains(searchString.ToLower()));

                if (moveis.Any())
                    categoriaAtual = "Móveis";
                else
                    categoriaAtual = "Nenhum móvel foi encontrado";
            }

            return View("~/Views/Movel/List.cshtml", new MovelListViewModel
            {
                Moveis = moveis,
                CategoriaAtual = categoriaAtual
            });
        }

    }
}