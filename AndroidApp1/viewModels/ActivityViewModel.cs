using System.ComponentModel;

namespace AndroidApp1.pages;

public class ActivityViewModel : INotifyPropertyChanged
{
    public int DailySteps { get; set; } = 8000;
    public int DailyGoal { get; set; } = 10000;
    public int Calories { get; set; } = 300;
    public double Distance { get; set; } = 5.2; // km

    public Command GoToStepInputCommand => new Command(async () => await Shell.Current.GoToAsync("stepinput"));
    public Command GoToSettingsCommand => new Command(async () => await Shell.Current.GoToAsync("settings"));

    public event PropertyChangedEventHandler PropertyChanged;
}