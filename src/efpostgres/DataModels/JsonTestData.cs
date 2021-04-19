using System.Collections.Generic;

namespace efpostgres.DataModels
{
  public class JsonTestData
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public List<string> MileStones { get; set; } = new List<string>();
  }
}