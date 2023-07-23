using System;
using System.Collections.ObjectModel;
using CancerPlot.Core.Models;
using CancerPlot.Repository.Interfaces;
using CancerPlotWpf.Messages;
using CancerPlotWpf.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

namespace CancerPlotWpf.ViewModels
{
	public partial class DashboardViewModel : ObservableRecipient
	{
		[ObservableProperty] private ObservableCollection<PersonalData> _personalData;

		[ObservableProperty]
        [NotifyPropertyChangedRecipients]
        private PersonalData _selectedPatient;

        private IPatientRepository _patientRepository;

		public DashboardViewModel(IPatientRepository repository)
        {
            _patientRepository = repository;

			this.Load();
			//db.Database.EnsureCreated();
			//db.Patients.Load();
			//Patients = db.Patients.Local.ToList();
		}

		partial void OnSelectedPatientChanged(PersonalData personalData)
        {
            WeakReferenceMessenger.Default.Send(new SelectedPatientChangedMessage(personalData));
        }

        public async void Load()
        {
            var personalData = await _patientRepository.GetAllPersonalData();
            PersonalData = new ObservableCollection<PersonalData>(personalData);
        }
		public async void OnNavigatedTo()
		{
			
		}

		public async void OnNavigatedFrom()
		{
		
		}

		[RelayCommand]
		private void AddPatientCommand()
		{
			//var w = new AddPatientWindow();
			//w.ShowDialog();

			//	_personalData.Add(new Patient());
		}
	}
}
