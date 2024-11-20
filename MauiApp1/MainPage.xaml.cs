using MauiApp1.Models;

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
            Etudiant etudiant = new Etudiant();
            etudiant.Nom = nomEntry.Text;
            etudiant.Prenom = PrenomEntry.Text;
            etudiant.Email = emailEntry.Text;
            etudiant.DateNaissance = dateNaisPicker.Date;

            await Navigation.PushAsync(new InfosPage(etudiant));
            
        }
    }
}
