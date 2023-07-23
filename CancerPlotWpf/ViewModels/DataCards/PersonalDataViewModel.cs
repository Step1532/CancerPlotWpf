using CancerPlot.Core.Models;
using CancerPlotWpf.Messages;
using CancerPlotWpf.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

namespace CancerPlotWpf.ViewModels;

public partial class PersonalDataViewModel : ObservableRecipient, 
    IRecipient<SelectedPatientChangedMessage>
{
    [ObservableProperty]
    private PersonalData _patient;

    [ObservableProperty] private bool _isEditorActivated;

    public PersonalDataViewModel()
    {
        IsActive = true;
    }

    public void Receive(SelectedPatientChangedMessage message)
    {
        Patient = message.Value;
    }

    [RelayCommand]
    public void EditorMode() => IsEditorActivated = !IsEditorActivated;
}