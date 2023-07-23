using CancerPlot.Core.Models;

namespace CancerPlot.Repository.Interfaces;

public interface IPatientRepository
{
    Task<IEnumerable<Patient>> GetAllPatients();

    Task<IEnumerable<PersonalData>> GetAllPersonalData();

    Task<IEnumerable<CurrentNeoplasm>> GetCurrentNeoplasms(int patientId);
    
    Task<PreviousDiagnosticData?> GetPreviousDiagnosticData(int patientId);
}