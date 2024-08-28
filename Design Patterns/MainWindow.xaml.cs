using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Design_Patterns;
using DesignPatterns.Factory_Method;

namespace DesignPatterns
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //LoggerMethod("Hello from the button!"); // Pass the desired message to LoggerMethod
            Logistics roadLogistics = new RoadLogistics();
            roadLogistics.PlanDelivery();

            Logistics seaLogistics = new SeaLogistics();
            seaLogistics.PlanDelivery();
        }

        public void LoggerMethod(string message)
        {
            Logger.Instance.Log(message);
        }
    }
}