using System.ComponentModel;

namespace CancerPlotWpf.Models;

public enum Gender
{
    [Description("")]
    [DefaultValue("")]
    None,
	[Description("М")]
	[DefaultValue("Мужской")]
	Male,
	[Description("Ж")]
	[DefaultValue("Женский")]
	Female
}