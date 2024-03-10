using backendApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backendApi.Controllers
{
  [Route("[controller]")]
  [ApiController]
  public class BowlingController : ControllerBase
  {
    private IBowlerRepository _bowlerRepo;
    public BowlingController(IBowlerRepository temp)
    {
      _bowlerRepo = temp;
    }

    [HttpGet]
    public IEnumerable<Bowler> Get()
    {
      var bowlerData = _bowlerRepo.Bowlers.ToArray();

      return bowlerData;
    }
  }
}