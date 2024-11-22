using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class ProduitM
    {
        string id, nom;
        int quantite;
        double prixUnitaire;
        DateTime dateExpiration;
        float volume;

        //string infoProduit;
        public string InfoProduit
        {
            get { return Nom; }
        }


        public string ID
        {
            set { id = value; }
            get { return id; }
        }

        public string Nom
        {
            set { nom = value; }
            get { return nom; }
        }

        public int Quantite
        {
            set { quantite = value; }
            get { return quantite; }
        }

        public double PrixUnitaire
        {
            set { prixUnitaire = value; }
            get { return prixUnitaire; }
        }

        public DateTime DateExpiration
        {
            set { dateExpiration = value; }
            get { return dateExpiration; }
        }

        public float Volume
        {
            set { volume = value; }
            get { return volume; }
        }

        public ProduitM() { }

        public ProduitM(string id, string nom, int quantite, double prixUnitaire, DateTime dateExpiration, float volume)
        {
            this.id = id;
            this.nom = nom;
            this.quantite = quantite;
            this.prixUnitaire = prixUnitaire;
            this.dateExpiration = dateExpiration;
            this.volume = volume;
        }
    }
}
