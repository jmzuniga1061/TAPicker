using zunigaSem3.views;

namespace zunigaSem3;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new inicio());
    }
}