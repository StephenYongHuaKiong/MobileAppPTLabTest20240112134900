using System.Net;

namespace MobileAppPTLabTest20240112134900.Views;

public partial class Q3A : ContentPage
{
	public Q3A()
	{
		InitializeComponent();
	}

	private async void Fetch(object sender, EventArgs e)
	{
		string data = await new HttpClient().GetStringAsync("https://jsonplaceholder.typicode.com/posts");
		await DisplayAlert("Fetched", data, "OK");
	}
}