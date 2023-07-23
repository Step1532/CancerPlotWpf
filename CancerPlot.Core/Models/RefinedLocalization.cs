using System.ComponentModel.DataAnnotations;

namespace CancerPlot.Core.Models;

public class RefinedLocalization
{
    [Key]
    public string Name { get; set; }

    public RefinedLocalization(string name)
    {
        Name = name;
    }
}