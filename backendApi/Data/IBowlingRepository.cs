namespace backendApi.Data
{
  public interface IBowlingRepository
  {
    IEnumerable<Bowler> Bowlers { get; }
  }
}