using System.Collections.Generic;

namespace SweetOrSavory.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Flavor flavor { get; set; }
    public List<TreatFlavor> JoinEntities { get; set; }
  }
}