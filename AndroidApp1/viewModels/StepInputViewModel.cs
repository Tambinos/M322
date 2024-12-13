using System.ComponentModel;

namespace AndroidApp1.viewModels;

public class StepInputViewModel : INotifyPropertyChanged
{
    private int _stepValue;
    public int StepValue
    {
        get => _stepValue;
        set
        {
            _stepValue = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(StepValue)));
        }
    }

    public Command ConfirmCommand => new Command(async () => 
    {
        // Perform logic to update daily steps
        await Shell.Current.GoToAsync("..");
    });

    public Command CancelCommand => new Command(async () =>
    {
        await Shell.Current.GoToAsync("..");
    });

    public event PropertyChangedEventHandler? PropertyChanged;
}