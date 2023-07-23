namespace CancerPlot.Core.Models;

public class PersonalData
{
    public int Id { get; set; }
    public string? Surname { get; set; }
    public string? Name { get; set; }
    public string? Patronymic { get; set; }
    public Gender? Gender { get; set; }
    public DateOnly? Birthday { get; set; }
    public string? CardId { get; set; }
    public string? Phone { get; set; }
    public int PatientId { get; set;}
    public Patient Patient { get; set;}

    public PersonalData()
    {
        
    }
}