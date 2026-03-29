using LojasMoveis.Models;

namespace LojasMoveis.Repositories.Interfaces
{
    public interface IMovelRepository
    {
        IQueryable<Movel> Moveis { get; }
        IQueryable<Movel> MoveisPreferidos { get; }
        Movel GetMovelById(int movelId);
    }
}
