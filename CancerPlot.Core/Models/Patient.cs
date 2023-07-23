namespace CancerPlot.Core.Models;

public class Patient
{
    public int Id { get; set; }
    
    public PersonalData PersonalData { get; set; }

    public List<CurrentNeoplasm>? CurrentNeoplasms { get; set; }

    public PreviousDiagnosticData PreviousDiagnostic { get; set; }
    public Patient()
    {
        
    }
}