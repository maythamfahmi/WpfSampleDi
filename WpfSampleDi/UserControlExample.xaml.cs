using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace WpfSampleDi
{
    /// <summary>
    /// Interaction logic for UserControlExample.xaml
    /// </summary>
    public partial class UserControlExample : UserControl
    {
        public UserControlExample()
        {
            InitializeComponent();
        }

        private void SetButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.WebFrame.Source = new Uri(this.UserSource.Text, UriKind.Absolute);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void WebFrame_Navigated(object sender, NavigationEventArgs e)
        {
        }
    }
}
