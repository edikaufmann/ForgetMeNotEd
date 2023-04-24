using CommunityToolkit.Maui.Behaviors;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ForgetMeNotEd.ViewModel
{
    [ObservableObject]
    internal partial class LoginViewModel
    {
        [ObservableProperty] private string name;
        [ObservableProperty] private string password;
        [ObservableProperty] private string submitCommand;
        [ObservableProperty] private bool activityIndicatorIsRunning = true;
    }
    [RelayCommand]
    private async void Submit()
    {
        for (var i = 0.0; i < 1.0; i += 0.1)
        {
            await LoginPage.LoginProgressBar.ProgressTo(i, 500, Easing.Linear);
        }
        await Application.Current.MainPage.DisplayAlert(
        "Submit",
        $"You entered {Name} and {Password}",
        "OK");

    }
}
