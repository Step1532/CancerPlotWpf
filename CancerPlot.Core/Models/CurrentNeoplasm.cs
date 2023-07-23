namespace CancerPlot.Core.Models;

public class CurrentNeoplasm
{
    public int Id { get; set; }
    
    public Eye EyeLocalization { get; set; }
    
    public int RefinedLocalizationId { get; set; }
    public RefinedLocalization RefinedLocalization { get; set;  }
    
    public int PatientId { get; set; }
    public Patient Patient { get; set; }
}