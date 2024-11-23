using System.Text.RegularExpressions;

public interface IMatchRepository
{
    IEnumerable<Match> GetAllMatches();
    Match GetMatchById(int id);
    void AddMatch(Match match);
    void UpdateMatch(Match match);
    void DeleteMatch(int id);
    void SaveChanges();
}
