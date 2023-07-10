using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using CancerPlotWpf.Models;
using CancerPlotWpf.Views.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore;
using Wpf.Ui.Common.Interfaces;
using Wpf.Ui.Controls;
using Wpf.Ui.Mvvm.Services;

namespace CancerPlotWpf.ViewModels
{
	public partial class DashboardViewModel : ObservableObject, INavigationAware
	{
		[ObservableProperty] 
		private ObservableCollection<Patient> _patients = new ObservableCollection<Patient>
		{
			new Patient("Иванов", "Иван", "Иванович", Gender.Male, DateOnly.MinValue, "123", "+79851457119"),
			new Patient("Иванов", "Иван", "Иванович", Gender.Male, DateOnly.MinValue, "123", "+79851457119"),
			new Patient("Иванов", "Иван", "Иванович", Gender.Male, DateOnly.MinValue, "123", "+79851457119"),
			new Patient("Иванов", "Иван", "Иванович", Gender.Male, DateOnly.MinValue, "123", "+79851457119"),
			new Patient("Иванов", "Иван", "Иванович", Gender.Male, DateOnly.MinValue, "123", "+79851457119"),
		};

		[ObservableProperty]
		private Patient _selectedPatient;


		ApplicationContext db = new ApplicationContext();

		public DashboardViewModel()
		{
			//db.Database.EnsureCreated();
			//db.Patients.Load();
			//Patients = db.Patients.Local.ToList();
		}

		public void OnNavigatedTo()
		{

		}

		public void OnNavigatedFrom()
		{
		}

		[RelayCommand]
		private void AddPatientCommand()
		{
			var viewModel = new AddPatientWindowViewModel();
			var w = new AddPatientWindow(viewModel);
			w.ShowDialog();

			if (viewModel.PatientData != null)
			{
				_patients.Add(viewModel.PatientData);
			}
		}
	}
}
