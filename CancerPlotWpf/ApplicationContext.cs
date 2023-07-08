using CancerPlotWpf.Models;
using Microsoft.EntityFrameworkCore;

namespace CancerPlotWpf;

public class ApplicationContext : DbContext
{
	public DbSet<Patient> Patients { get; set; } = null!;
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlite("Data Source=CancerPlot.db");
	}
}