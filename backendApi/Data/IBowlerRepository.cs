namespace backendApi.Data
{
  public interface IBowlerRepository
  {
    IEnumerable<Bowler> Bowlers { get; }
  }
}