namespace ControlBindingTest.ViewModels;

public partial class MainViewModel : BaseViewModel
{
    [ObservableProperty]
    private string _input = "";

    [RelayCommand]
    private void ClickMe()
    {
        Input = "Clicked!";
    }
}
