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

        public Etudiant(string name, string prenom, DateTime dateNaissance, string email)
        {
            Nom = name;
            Prenom = prenom;
            DateNaissance = dateNaissance;
            Email = email;
        }
    }
}
