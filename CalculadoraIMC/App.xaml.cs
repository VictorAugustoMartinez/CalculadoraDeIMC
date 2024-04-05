using CalculadoraIMC.Pages;

namespace CalculadoraIMC
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Home();
        }
    }
}
