using System.Collections.Generic;

namespace SweetOrSavory.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<TreatFlavor> JoinEntities { get; set; }

    public Treat treat { get; set; }
  }
}