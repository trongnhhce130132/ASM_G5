using ASMLibrary.Management.IService;
using ASMLibrary.Management.Sevice;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ASMWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ServiceProvider serviceProvider;
        //public App()
        //{
        //    ServiceCollection service = new ServiceCollection();
        //    ConfigureServices(service);
        //    serviceProvider = service.BuildServiceProvider();

        //}
        //private void ConfigureServices(ServiceCollection services)
        //{
        //    //  services.AddSingleton(typeof(IMonAnService), typeof(IMonAnService));
        //    services.AddSingleton(typeof(IMonAnService), typeof(MonAnService));
        //    services.AddSingleton<MonAnForm>();
        //}
        //private void OnStartup(Object sender, StartupEventArgs e)
        //{
        //    var mainWindow = serviceProvider.GetService<MonAnForm>();
        //    mainWindow.Show();
        //}
    }
}
