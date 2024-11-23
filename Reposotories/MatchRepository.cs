using MVC_Project.Models;

public class MatchRepository : IMatchRepository
{
    private readonly AppDbContext _context;

    public MatchRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Match> GetAllMatches()
    {
        return _context.Matches.ToList();
    }

    public Match GetMatchById(int id)
    {
        return _context.Matches.FirstOrDefault(m => m.Match_Id == id);
    }

    public void AddMatch(Match match)
    {
        _context.Matches.Add(match);
    }

    public void UpdateMatch(Match match)
    {
        _context.Matches.Update(match);
    }

    public void DeleteMatch(int id)
    {
        var match = GetMatchById(id);
        if (match != null)
        {
            _context.Matches.Remove(match);
        }
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }

    IEnumerable<System.Text.RegularExpressions.Match> IMatchRepository.GetAllMatches()
    {
        throw new NotImplementedException();
    }

    System.Text.RegularExpressions.Match IMatchRepository.GetMatchById(int id)
    {
        throw new NotImplementedException();
    }

    public void AddMatch(System.Text.RegularExpressions.Match match)
    {
        throw new NotImplementedException();
    }

    public void UpdateMatch(System.Text.RegularExpressions.Match match)
    {
        throw new NotImplementedException();
    }
}
