
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public class Etudiant
    {
        

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Email { get; set; }
        public Etudiant() { }
        public Etudiant(string nom,string prenom ,string email,DateTime dateNaissance) 
        {
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
            Email = email;

        }
    }
}
