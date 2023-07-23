using CancerPlot.Core.Models;
using CancerPlotWpf.Models;
using CommunityToolkit.Mvvm.Messaging.Messages;

namespace CancerPlotWpf.Messages;

public class SelectedPatientChangedMessage : ValueChangedMessage<PersonalData>
{
    public SelectedPatientChangedMessage(PersonalData value) : base(value)
    {

    }
}