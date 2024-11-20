namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            // Exemple de traitement
            await DisplayAlert("Votre formulaire soumis avec succès, merci", "OK");
        }
    }
}
