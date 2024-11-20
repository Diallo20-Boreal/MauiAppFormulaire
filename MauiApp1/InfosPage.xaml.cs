using MauiApp1.Models;

namespace MauiApp1;

public partial class InfosPage : ContentPage
{
    
        Etudiant etd;

        // Constructeur sans param�tres
        public InfosPage()
        {
            InitializeComponent();
        }

        // Constructeur avec un objet Etudiant
        public InfosPage(Etudiant etudiant)
        {
            InitializeComponent();

            this.etd = etudiant;

            // Mise � jour des donn�es sur l'interface
            introLabel.Text = $"Bienvenue {etd.Nom} {etd.Prenom}";
            dateNaissanceLabel.Text = $"Votre date de naissance est le �{etd.DateNaissance.ToString("yyyy-MM-dd")}";
            emailLabel.Text = $"Votre email est {etd.Email}";
        }

        // Gestionnaire d'�v�nements pour le bouton
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync(); // Retour � la page pr�c�dente
        }
    
}