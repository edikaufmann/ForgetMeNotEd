using ForgetMeNotEd.ViewModel;
namespace ForgetMeNotEd.View;

public partial class MainPage : ContentPage
{

    private MainViewModel vm = new MainViewModel();
    public MainPage()
	{
        
        BindingContext = vm;
        InitializeComponent();
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        vm.FullName = "Ed Kaufmann";
        base.OnAppearing();
        vm.FavoriteImage = "psteb_16.jpg";
        base.OnAppearing();
        vm.FavImage = "psteb_3.jpg";
    }

}

