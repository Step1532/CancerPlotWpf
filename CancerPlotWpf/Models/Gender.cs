using System.ComponentModel;

namespace CancerPlotWpf.Models;

public enum Gender
{
	[Description("М")]
	[DefaultValue("Мужской")]
	Male,
	[Description("Ж")]
	[DefaultValue("Женский")]
	Female
}