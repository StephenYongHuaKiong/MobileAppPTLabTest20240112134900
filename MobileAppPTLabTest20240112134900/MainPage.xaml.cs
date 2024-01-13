using MobileAppPTLabTest20240112134900.Views;

namespace MobileAppPTLabTest20240112134900
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private async void GotoQuestion1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Question1());
        }

        private async void GotoQuestion2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Question2());
        }

        private async void GotoQ3A(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Q3A());
        }
    }
}