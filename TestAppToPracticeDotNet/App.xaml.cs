using System.Configuration;
using System.Data;
using System.Windows;
using TestAppToPracticeDotNet.AllAboutThreading;

namespace TestAppToPracticeDotNet
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Threading threading = new Threading();
        }
    }

}
