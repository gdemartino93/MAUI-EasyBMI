using MAUI_EasyBMI.MVVM.Views;

namespace MAUI_EasyBMI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new BMIView();
        }
    }
}
