using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
     public class Personne
    {
        string nom, prenom, phone, adresse, sexe;

        public string Nom { get { return nom; } set { nom = value; } }

        public string Prenom { get { return prenom; } set {  prenom = value; } }

        public string Phone { get { return phone; } set { phone = value; } }
        
        public string Adresse { get {  return adresse; } set {  adresse = value; } }

        public string Sexe { get {  return sexe; } set {  sexe = value; } }

        public Personne() { }

        public Personne(string nom, string prenom, string phone, string adresse, string sexe)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.phone = phone;
            this.adresse = adresse;
            this.sexe = sexe;
        }
    }
}
