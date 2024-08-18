using LojasMoveis.Models;

namespace LojasMoveis.ViewModels
{
    public class MovelListViewModel
    {
        public IEnumerable<Movel> Moveis { get; set; }
        public string CategoriaAtual { get; set; }

    }
}
