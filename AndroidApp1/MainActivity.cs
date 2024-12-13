using AndroidApp1.pages;
using AndroidApp1.viewModels;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace AndroidApp1;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<Application>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        // Register viewmodels, services, etc.
        builder.Services.AddTransient<ActivityPage>();
        builder.Services.AddTransient<ActivityViewModel>();
        builder.Services.AddTransient<StepInputPage>();
        builder.Services.AddTransient<StepInputViewModel>();
        builder.Services.AddTransient<SettingsPage>();
        builder.Services.AddTransient<SettingsViewModel>();
        builder.Services.AddSingleton<IDataService, DataService>();

        return builder.Build();
    }
}