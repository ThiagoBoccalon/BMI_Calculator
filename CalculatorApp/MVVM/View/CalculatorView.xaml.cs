using CalculatorApp.MVVM.ViewModel;

namespace CalculatorApp.MVVM.View;

public partial class CalculatorView : ContentPage
{
	public CalculatorView()
	{
		InitializeComponent();
        BindingContext = new BMIViewModel();
    }
}