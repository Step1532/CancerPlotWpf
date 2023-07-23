using System.Windows.Controls;
using CancerPlotWpf.ViewModels;

namespace CancerPlotWpf.Views.DataCards
{
    /// <summary>
    /// Interaction logic for CurrentNeoplasmView.xaml
    /// </summary>
    public partial class CurrentNeoplasmView : UserControl
    {
        public ViewModels.CurrentNeoplasmViewModel ViewModel
        {
            get;
        }
        public CurrentNeoplasmView()
        {
            ViewModel = App.GetService<CurrentNeoplasmViewModel>();
            DataContext = this;
            InitializeComponent();
        }
    }
}
