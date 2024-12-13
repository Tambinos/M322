using System.ComponentModel;

namespace AndroidApp1.viewModels;

public class SettingsViewModel : INotifyPropertyChanged
{
    private bool _standortgriff;
    private bool _mitteilungen;
    private bool _cookies;

    public bool Standortgriff
    {
        get => _standortgriff;
        set
        {
            _standortgriff = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Standortgriff)));
        }
    }

    public bool Mitteilungen
    {
        get => _mitteilungen;
        set
        {
            _mitteilungen = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Mitteilungen)));
        }
    }

    public bool Cookies
    {
        get => _cookies;
        set
        {
            _cookies = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Cookies)));
        }
    }

    public Command ConfirmCommand => new Command(async () =>
    {
        // Save settings logic here
        await Shell.Current.GoToAsync("..");
    });

    public Command CancelCommand => new Command(async () => { await Shell.Current.GoToAsync(".."); });

    public event PropertyChangedEventHandler? PropertyChanged;
}