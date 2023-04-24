using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Xml.Linq;

namespace ForgetMeNotEd.ViewModel;

[ObservableObject]
public partial class MainViewModel
{
    [ObservableProperty]
    private string fullName;
    [ObservableProperty]
    private string favoriteImage;
    [ObservableProperty]
    private string favImage;
    [ObservableProperty]
    private bool imageIsVisible = true;
    
    [RelayCommand]
    private void ImageTapped()
    {
        ImageIsVisible = !ImageIsVisible;
    }
    
   
}


