using System.Windows.Controls;
using WpfSampleDi.Service;

namespace WpfSampleDi
{
    /// <summary>
    /// Interaction logic for UserControlExample2.xaml
    /// </summary>
    public partial class UserControlExample2 : UserControl
    {
        private readonly ILogBase _logBase;

        public UserControlExample2()
        {
            InitializeComponent();

            if (MainWindow.AppWindow?.LogBase != null)
                _logBase = MainWindow.AppWindow.LogBase;

            TestMethod();
        }

        private void TestMethod()
        {
            TextBox1.Text = _logBase.Info("App starting");
        }

    }
}
