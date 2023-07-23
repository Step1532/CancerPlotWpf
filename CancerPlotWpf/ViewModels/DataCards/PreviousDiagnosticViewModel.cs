using CancerPlot.Core.Models;
using CancerPlot.Repository.Interfaces;
using CancerPlotWpf.Messages;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

namespace CancerPlotWpf.ViewModels;

public partial class PreviousDiagnosticViewModel : ObservableRecipient,
    IRecipient<SelectedPatientChangedMessage>
{
    [ObservableProperty]
    private PreviousDiagnosticData? _diagnosticData;

    private readonly IPatientRepository _patientRepository;

    public PreviousDiagnosticViewModel(IPatientRepository patientRepository)
    {
        IsActive = true;
        _patientRepository = patientRepository;
    }

    public async void Receive(SelectedPatientChangedMessage message)
    {
        var data = await _patientRepository.GetPreviousDiagnosticData(message.Value.PatientId);
        DiagnosticData = data;
    }
}
