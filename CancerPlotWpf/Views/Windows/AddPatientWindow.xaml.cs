using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Wpf.Ui.Controls;
using Wpf.Ui.Controls.Interfaces;
using Wpf.Ui.Mvvm.Contracts;

namespace CancerPlotWpf.Views.Windows
{
	/// <summary>
	/// Interaction logic for AddPatientWindow.xaml
	/// </summary>
	public partial class AddPatientWindow : UiWindow
	{
		public ViewModels.AddPatientWindowViewModel ViewModel
		{
			get;
		}
		public AddPatientWindow(ViewModels.AddPatientWindowViewModel viewModel)
		{
			ViewModel = viewModel;
			viewModel.CloseAction = new Action(this.Close);
			DataContext = this;

			InitializeComponent();
		}
	}
}
