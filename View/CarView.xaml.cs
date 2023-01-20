using MVVMTest.ViewModel;

namespace MVVMTest.View;

public partial class CarView : ContentPage
{
	public CarViewModel viewModel;
	public CarView(CarViewModel carView)
	{
		InitializeComponent();
		viewModel = carView;
		BindingContext= viewModel;	
	}
}