namespace MauiPlanets.Views;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
	}

	async void ExploreNow_Clicked(System.Object sender, System.EventArgs e)
		=> Application.Current.MainPage = new NavigationPage(new PlanetsPage());

}
