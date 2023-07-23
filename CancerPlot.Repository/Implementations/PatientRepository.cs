using CancerPlot.Core.Models;
using CancerPlot.Repository.Interfaces;

namespace CancerPlot.Repository.Implementations;

public class PersonalDataRepository : IPersonalDataRepository
{
    public PersonalDataRepository()
    {
        
    }
    public Task<List<Patient>> GetAllPatients()
    {
        await Thread.Sleep(1000);
        return new List<Patient>()
        {
            new Patient("Иванов", "Иван", "Иванович", Gender.Male, DateOnly.MinValue, "123", "+79851457119"),
            new Patient("Ивasdанов", "Иван", "Иванович", Gender.Male, DateOnly.MinValue, "123", "+79851457119"),
            new Patient("Иванов", "Иван", "Иванович", Gender.Male, DateOnly.MinValue, "123", "+79851457119"),
            new Patient("Ивasdанов", "Ивasdан", "Иванович", Gender.Male, DateOnly.MinValue, "123", "+79851457119"),
            new Patient("Иванов", "Иван", "Иванasdович", Gender.Male, DateOnly.MinValue, "123", "+79851457119"),
        };
    }
}