using LojasMoveis.Repositories.Interfaces;
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
            var moveis = _movelRepository.Moveis;
            return View(moveis);
        }
    }
}
