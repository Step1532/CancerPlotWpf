using System;
using System.Collections.Generic;
using System.Linq;
using CancerPlotWpf.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore;
using Wpf.Ui.Common.Interfaces;

namespace CancerPlotWpf.ViewModels
{
	public partial class DashboardViewModel : ObservableObject, INavigationAware
	{
		[ObservableProperty] 
		private List<Patient> _patients = new List<Patient>
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

		public void OnNavigatedTo()
		{
			//db.Database.EnsureCreated();
			//db.Patients.Load();
			//Patients = db.Patients.Local.ToList();
		}

		public void OnNavigatedFrom()
		{
		}

		[RelayCommand]
		private void OnCounterIncrement()
		{
		}
	}
}
