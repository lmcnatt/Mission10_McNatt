using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace backendApi.Data
{
  public class EFBowlingRepository : IBowlingRepository
  {
    private BowlingLeagueContext _context;

    public EFBowlingRepository(BowlingLeagueContext temp)
    {
      _context = temp;
    }

    public IEnumerable<Bowler> Bowlers => _context.Bowlers.Include("Team")
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
                                                            Team = _context.Teams
                                                              .FirstOrDefault(t => t.TeamId == b.TeamId)
                                                          });

    public IEnumerable<Team> Teams => _context.Teams.Include("Captain")
                                                    .Select(t => new Team
                                                    {
                                                      TeamId = t.TeamId,
                                                      TeamName = t.TeamName,
                                                      CaptainId = t.CaptainId,
                                                      Captain = _context.Bowlers
                                                        .FirstOrDefault(b => b.BowlerId == t.CaptainId)
                                                    });
  }
}