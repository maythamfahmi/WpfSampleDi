using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using WpfSampleDi.Service;

namespace WpfSampleDi
{
    /// <summary>
    /// Interaction logic for UserControlExample.xaml
    /// </summary>
    public partial class UserControlExample : UserControl
    {
        private readonly ILogBase _logBase;

        public UserControlExample()
        {
            InitializeComponent();

            if (MainWindow.AppWindow?.LogBase != null)
                _logBase = MainWindow.AppWindow.LogBase;
        }

        private void SetButton_Click(object sender, RoutedEventArgs e)
        {
            _logBase.Info($"User url visit request");

            try
            {
                var uri = new Uri(this.UserSource.Text, UriKind.Absolute);
                _logBase.Debug($"User try visiting {uri}");
                this.WebFrame.Source = uri;
            }
            catch (Exception error)
            {
                _logBase.Error(error, error.Message);
            }
        }

        private void WebFrame_Navigated(object sender, NavigationEventArgs e)
        {
        }
    }
}
