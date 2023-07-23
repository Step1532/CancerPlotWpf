using CancerPlotWpf.ViewModels;
using System.Windows.Controls;

namespace CancerPlotWpf.Views.DataCards;

public partial class PreviousDiagnosticView : UserControl
{
    public ViewModels.PreviousDiagnosticViewModel ViewModel
    {
        get;
    }

    public PreviousDiagnosticView()
    {
        this.InitializeComponent();
        ViewModel = App.GetService<PreviousDiagnosticViewModel>();
        this.DataContext = this;
    }

}