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

        public IActionResult List()
        {
            // var moveis = _movelRepository.Moveis;
            // return View(moveis);

            var moveisListViewModel = new MovelListViewModel();
            moveisListViewModel.Moveis = _movelRepository.Moveis;
            moveisListViewModel.CategoriaAtual = "Categoria Atual";

            return View(moveisListViewModel);
        }
    }
}
