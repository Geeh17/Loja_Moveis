using LojasMoveis.Models;

namespace LojasMoveis.ViewModels
{
    public class MovelListViewModel
    {
        public IEnumerable<Movel> Moveis { get; set; } = Enumerable.Empty<Movel>();
        public string CategoriaAtual { get; set; } = string.Empty;
    }
}
