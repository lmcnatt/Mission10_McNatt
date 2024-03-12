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

    public IEnumerable<Bowler> Bowlers => _context.Bowlers.Include(b => b.Team).Include(b => b.BowlerScores)
                                                          .Where(b => b.Team.TeamName == "Marlins" || b.Team.TeamName == "Sharks")
                                                          .Select(b => new Bowler
                                                          {
                                                            BowlerId = b.BowlerId,
                                                            BowlerFirstName = b.BowlerFirstName,
                                                            BowlerMiddleInit = b.BowlerMiddleInit,
                                                            BowlerLastName = b.BowlerLastName,
                                                            BowlerAddress = b.BowlerAddress,
                                                            BowlerCity = b.BowlerCity,
                                                            BowlerState = b.BowlerState,
                                                            BowlerZip = b.BowlerZip,
                                                            BowlerPhoneNumber = b.BowlerPhoneNumber,
                                                            TeamId = b.TeamId,
                                                            Team = b.Team,
                                                            BowlerScores = b.BowlerScores
                                                          });
  }
}