using CancerPlot.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace CancerPlot.Repository;

public class ApplicationContext : DbContext
{
	public DbSet<Patient> Patients { get; set; } = null!;

    public DbSet<PersonalData> PersonalData { get; set; } = null!;

    public DbSet<CurrentNeoplasm> CurrentNeoplasms { get; set; } = null!;
    public DbSet<RefinedLocalization> RefinedLocalizations { get; set; } = null!;

    public DbSet<PreviousDiagnosticData> PreviousDiagnosticData { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlite("Data Source=CancerPlot.db");
	}
}