using LojasMoveis.Context;
using LojasMoveis.Models;
using LojasMoveis.Repositories.Interfaces;

namespace LojasMoveis.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;

    }
}
