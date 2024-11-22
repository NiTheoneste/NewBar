using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class UtilisateurM : Personne
    {
        string matricule, email, profil, username, password;
        int age;
        double salaire;

        public string Matricule {  get { return matricule; } set {  matricule = value; } }

        public string Email { get { return email; } set { email = value; } }

        public string Profil { get {  return profil; } set {  profil = value; } }

        public string Username { get { return username; } set { username = value; } }

        public string Password { get { return password; } set { password = value; } }

        public int Age { get { return age; } set { age = value; } }

        public double Salaire {
            get
            {
                salaire = 0;
                if (profil == "Gérant") salaire = 1000000;
                else if (profil == "Comptable") salaire = 800000;
                else if (profil == "Réceptioniste") salaire = 600000;
                else if (profil == "Serveur") salaire = 400000;
                else if (profil == "Veternaire") salaire = 300000;
                return salaire;
            }
        }

        public UtilisateurM() { }

        public UtilisateurM(string nom, string prenom, string phone, string adresse, string sexe, string matricule, string email, string profil, string username, string password, int age):
            base(nom, prenom, phone, adresse, sexe)
        {
            this.matricule = matricule;
            this.age = age;
            //this.salaire = salaire; this.matricule = matricule;
            this.email = email;
            this.profil = profil;
            this.username = username;
            this.password = password;
        }


    }
}
