using LojasMoveis.Context;
using LojasMoveis.Models;
using LojasMoveis.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LojasMoveis.Repositories
{
    public class MovelRepository : IMovelRepository
    {
        private readonly AppDbContext _context;

        public MovelRepository(AppDbContext contexto)
        {
            _context = contexto;
        }
        public IEnumerable<Movel> Moveis => _context.Moveis.Include(c => c.Categoria);

        public IEnumerable<Movel> MoveisPreferidos => _context.Moveis.
                                       Where(m => m.IsMovelPreferido).
                                       Include(c => c.Categoria);


        public Movel GetMovelById(int movelId)
        {
            return _context.Moveis.FirstOrDefault(m => m.MovelId == movelId);

        }
    }
}
