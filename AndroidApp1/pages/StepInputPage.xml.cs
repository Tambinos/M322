using AndroidApp1.viewModels;

namespace AndroidApp1.pages;

public partial class StepInputPage : ContentPage
{
    public StepInputPage()
    {
        InitializeComponent();
        BindingContext = new StepInputViewModel();
    }
}