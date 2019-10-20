using System.Windows;
using WpfSampleDi.Service;

namespace WpfSampleDi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ILogBase _logBase;

        public MainWindow(ILogBase logBase)
        {
            InitializeComponent();

            _logBase = logBase;

            TestMethod();
        }

        private void TestMethod()
        {
            TextBox1.Text = _logBase.Info("App starting");
        }


    }
}
