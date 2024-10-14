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
using Design_Patterns.CreationalPatterns.BuilderPattern;
using Design_Patterns.CreationalPatterns.FactoryMethod;
using Design_Patterns.CreationalPatterns.Singleton;

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

            //LoggerMethod("Hello from the button!"); // singleton

            Console.WriteLine("Enter the type of pizza you want to order: (Sucuklu, Margherita, Pepperoni, Veggie)");
            string pizzaType = Console.ReadLine();

            try
            {
                Pizza pizza = PizzaFactory.CreatePizza(pizzaType);
                pizza.Prepare();
                pizza.Bake();
                pizza.Cut();
                pizza.Box();

                Console.WriteLine($"{pizzaType} Pizza is ready to be served!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.ReadLine();
        }

        public void LoggerMethod(string message)
        {
            Logger.Instance.Log(message);
        }

        private void btnFactory_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBuilder_Click(object sender, RoutedEventArgs e)
        {
            // set values to builder class
            var oneStoryHouse = new HouseBuilder().SetStoryHt(1).SetDoorType("Single Door").SetRoofType("Pointy Roof").Build();
            var twoStoryHouse = new HouseBuilder().SetStoryHt(2).SetDoorType("Double Door").SetRoofType("Flat Roof").Build();
        }
    }
}