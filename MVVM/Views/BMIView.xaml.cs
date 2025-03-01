using MAUI_EasyBMI.MVVM.ViewModels;

namespace MAUI_EasyBMI.MVVM.Views;

public partial class BMIView : ContentPage
{
	public BMIView()
	{
		InitializeComponent();
		BindingContext = new BMIViewModel();
	}
}