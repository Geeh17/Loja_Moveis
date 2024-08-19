using LojasMoveis.Models;
using LojasMoveis.Repositories.Interfaces;
using LojasMoveis.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LojasMoveis.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMovelRepository _movelRepository;

        public HomeController(IMovelRepository movelRepository)
        {
            _movelRepository = movelRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                MoveisPreferidos = _movelRepository.MoveisPreferidos
            };

            return View(homeViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}