using System.IO;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using WpfSampleDi.Service;

namespace WpfSampleDi
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider _serviceProvider;

        public App()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            _serviceProvider = serviceCollection.BuildServiceProvider();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ILogBase>(provider => new LogBase(new FileInfo(@"c:\temp\log.txt")));
            services.AddSingleton<MainWindow>();
        }

        private void AppOnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = _serviceProvider.GetService<MainWindow>();
            mainWindow?.Show();
        }
    }
}
