using CancerPlotWpf.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;

namespace CancerPlotWpf.ViewModels;

public partial class AddPatientWindowViewModel : ObservableObject
{

	public Action CloseAction { get; set; }
	public Patient? PatientData { get; set; }

	[ObservableProperty] private Patient _patient = new Patient();

	[RelayCommand]
	private void SaveAndClose()
	{
		CloseAction();
		PatientData = _patient;
	}
}