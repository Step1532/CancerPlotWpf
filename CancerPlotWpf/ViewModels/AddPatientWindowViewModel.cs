using CancerPlotWpf.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;

namespace CancerPlotWpf.ViewModels;

public partial class AddPatientWindowViewModel : ObservableObject
{

	public Action CloseAction { get; set; }
	public Patient? PatientData { get; set; }

    [ObservableProperty] public string? _surname;
    [ObservableProperty] public string? _name;
    [ObservableProperty] public string? _patronymic;
    [ObservableProperty] public Gender _gender = Gender.None;
    [ObservableProperty] public DateTime? _birthday;
    [ObservableProperty] public string _cardId;
    [ObservableProperty] public string? _phone;

    //[ObservableProperty] private Patient _patient = new Patient();

	[RelayCommand]
	private void SaveAndClose()
    {
        CloseAction();
        if (Birthday != null)
        {
            PatientData = new Patient(Surname, Name, Patronymic, Gender, DateOnly.FromDateTime(Birthday.Value), CardId, Phone);
        }
        else
        {
            PatientData = new Patient(Surname, Name, Patronymic, Gender, null, CardId, Phone);
        }
    }
}