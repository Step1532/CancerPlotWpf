using CancerPlot.Core.Models;

namespace CancerPlot.Repository.Interfaces;

public interface IPersonalDataRepository
{
    Task<List<Patient>> GetAllPatients();
}