using LojasMoveis.Models;

namespace LojasMoveis.Repositories.Interfaces
{
    public interface IMovelRepository
    {
        IEnumerable<Movel> Moveis { get; }
        IEnumerable<Movel> MoveisPreferidos { get; }
        Movel GetMovelById(int movelId);


    }
}
