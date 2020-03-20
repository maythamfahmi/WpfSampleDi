using System.Windows;
using WpfSampleDi.Service;

namespace WpfSampleDi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public readonly ILogBase LogBase;

        public static MainWindow AppWindow;

        public MainWindow(ILogBase logBase)
        {
            AppWindow = this;
            LogBase = logBase;

            InitializeComponent();
        }

    }
}
