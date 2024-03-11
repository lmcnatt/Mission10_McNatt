using Microsoft.EntityFrameworkCore;

namespace backendApi.Data
{
  public class EFBowlingRepository : IBowlingRepository
  {
    private BowlingLeagueContext _context;

    public EFBowlingRepository(BowlingLeagueContext temp)
    {
      _context = temp;
    }

    public IEnumerable<Bowler> Bowlers => _context.Bowlers.Include("Teams");
  }
}