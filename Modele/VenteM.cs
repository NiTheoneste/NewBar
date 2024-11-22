using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class VenteM
    {
        string id, client, produit;
        int quantite;
        double prixUnitaire, prixTotal;
        DateTime dateOperation;

        /*string infoVente;
        public string InfoVente
        {
            get { return DateOperation.ToString(); }
        }*/


        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Client
        {
            get { return client; }
            set { client = value; }
        }

        public string Produit
        {
            get { return produit; }
            set { produit = value; }
        }
        public int Quantite
        {
            get { return quantite; }
            set { quantite = value; }
        }
        public double PrixUnitaire
        {
            get { return prixUnitaire; }
            set { prixUnitaire = value; }
        }
        public double PrixTotal
        {
            get { return prixTotal; }
            set { prixTotal = value; }
        }
        public DateTime DateOperation
        {
            get { return dateOperation; }
            set { dateOperation = value; }
        }



        public VenteM() { }

        public VenteM(string id, string client, string produit, int quantite, double prixUnitaire, double prixTotal, DateTime dateOperation)
        {
            this.id = id;
            this.client = client;
            this.produit = produit;
            this.quantite = quantite;
            this.prixUnitaire = prixUnitaire;
            this.prixTotal = prixTotal;
            this.dateOperation = dateOperation;
        }
    }
}
