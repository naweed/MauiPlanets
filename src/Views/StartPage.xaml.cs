namespace MauiPlanets.Views;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
	}

    async void ExploreNow_Clicked(System.Object sender, System.EventArgs e)
		=> await Navigation.PushAsync(new PlanetsPage());

}
