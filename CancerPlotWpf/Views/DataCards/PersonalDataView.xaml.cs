using System.Windows.Controls;
using CancerPlotWpf.ViewModels;

namespace CancerPlotWpf.Views.DataCards;

public partial class PersonalDataView : UserControl
{
    public ViewModels.PersonalDataViewModel ViewModel
    {
        get;
    }

    public PersonalDataView()
    {
        this.InitializeComponent();
        ViewModel = App.GetService<PersonalDataViewModel>();
        this.DataContext = this;
    }

    //public PersonalDataView(ViewModels.PersonalDataViewModel viewModel)
    //{
    //    ViewModel = viewModel;
    //    DataContext = this;
    //    InitializeComponent();
    //}
}