using CancerPlot.Core.Models;

namespace CancerPlot.Core;

public class PatientBuilder
{
    private Patient patient;
    public PatientBuilder()
    {
        patient = new Patient();
    }
    public PatientBuilder SetPersonalData(PersonalData data)
    {
        patient.PersonalData = data;
        return this;
    }
    public PatientBuilder WithCurrentNeoplasms(CurrentNeoplasm neoplasm)
    {
        if (patient.CurrentNeoplasms == null)
        {
            patient.CurrentNeoplasms = new List<CurrentNeoplasm>();
        }
        patient.CurrentNeoplasms.Add(neoplasm);
        return this;
    }
    public PatientBuilder SetPreviousDiagnostic(PreviousDiagnosticData data)
    {
        patient.PreviousDiagnostic = data;
        return this;
    }
    public static implicit operator Patient(PatientBuilder builder)
    {
        return builder.patient;
    }
}