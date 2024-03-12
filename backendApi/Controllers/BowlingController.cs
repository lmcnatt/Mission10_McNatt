using backendApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backendApi.Controllers
{
  [Route("[controller]")]
  [ApiController]
  public class BowlingController : ControllerBase
  {
    private IBowlingRepository _bowlingRepo;
    public BowlingController(IBowlingRepository temp)
    {
      _bowlingRepo = temp;
    }

    [HttpGet("Bowlers", Name = "GetBowlers")]
    public IEnumerable<Bowler> GetBowlers()
    {
      var bowlerData = _bowlingRepo.Bowlers.ToArray();

      return bowlerData;
    }

    [HttpGet("Teams", Name = "GetTeams")]
    public IEnumerable<Team> GetTeams()
    {
      var teamData = _bowlingRepo.Teams.ToArray();

      return teamData;
    }
  }
}