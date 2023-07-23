using CancerPlot.Core.Models.PreviousDiagnostic;

namespace CancerPlot.Core.Models;

public class PreviousDiagnosticData
{
    public int Id { get; set; }
    public PreviousBiopsyData? PreviousBiopsy { get; set; }
    public PreviousCytologyData? PreviousCytology { get; set; }
    public PreviousDermatoscopyData? PreviousDermatoscopy { get; set; }
    public PreviousOperationsData? PreviousOperations { get; set; }
    public PreviousCytostaticTreatmentData? PreviousCytostaticTreatment { get; set; }

    public PreviousIrradiationData? PreviousIrradiation {get; set; }

    public PreviousAnotherData? PreviousAnother { get; set; }

    public int PatientId { get; set; }
    public Patient Patient { get; set; }
}