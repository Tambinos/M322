namespace AndroidApp1.pages;

public partial class ActivityPage : ContentPage
{
    public ActivityPage()
    {
        InitializeComponent();
        BindingContext = new ActivityViewModel();
    }
}