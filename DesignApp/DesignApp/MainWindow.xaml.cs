using System.Windows;
using System.Windows.Input;

namespace DesignApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var mainViewModel = new MainViewModel();

            mainViewModel.Canvas = this.Canvas1;

            DataContext = mainViewModel;
        }

    }
}
