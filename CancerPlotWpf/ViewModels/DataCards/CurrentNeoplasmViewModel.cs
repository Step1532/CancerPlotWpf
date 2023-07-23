using System.Collections.ObjectModel;
using System.Linq;
using CancerPlot.Core.Models;
using CancerPlot.Repository.Interfaces;
using CancerPlotWpf.Messages;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;

namespace CancerPlotWpf.ViewModels;

public partial class CurrentNeoplasmViewModel : ObservableRecipient,
    IRecipient<SelectedPatientChangedMessage>
{
    [ObservableProperty] private ObservableCollection<CurrentNeoplasm>? _neoplasms;

    private IPatientRepository _patientRepository;

    public CurrentNeoplasmViewModel(IPatientRepository patientRepository)
    {
        _patientRepository = patientRepository;
        IsActive = true;
    }

    public async void Receive(SelectedPatientChangedMessage message)
    {
        var neoplasms = await _patientRepository.GetCurrentNeoplasms(message.Value.PatientId);
        var currentNeoplasms = neoplasms.ToList();
        Neoplasms = !currentNeoplasms.Any() ? null : new ObservableCollection<CurrentNeoplasm>(currentNeoplasms);
    }
}