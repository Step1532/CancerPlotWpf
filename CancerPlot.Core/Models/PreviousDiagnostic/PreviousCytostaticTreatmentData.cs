namespace CancerPlot.Core.Models.PreviousDiagnostic;

public class PreviousCytostaticTreatmentData
{
    public int Id { get; set; }

    public DateOnly Year { get; set; }

    public string Conclusion { get; set; }
}