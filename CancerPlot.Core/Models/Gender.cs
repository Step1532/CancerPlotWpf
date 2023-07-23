using System.ComponentModel;

namespace CancerPlot.Core.Models;

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