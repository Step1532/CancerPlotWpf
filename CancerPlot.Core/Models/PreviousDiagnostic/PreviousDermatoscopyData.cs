namespace CancerPlot.Core.Models.PreviousDiagnostic;

public class PreviousDermatoscopyData
{
    public int Id { get; set; }

    public DateOnly Date { get; set; }

    public string Conclusion { get; set; }
}