using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class ClientM : Personne
    {
        string id, nationalite;

        string infoClient;
        public string InfoClient
        {
            get { return Nom; }
        }

        public string Id { get { return id; } set { id = value; } }

        public string Nationalite { get { return nationalite; } set { nationalite = value; } }

        public ClientM() { }

        public ClientM(string nom, string prenom, string phone, string adresse, string sexe, string id, string nationalite) :
            base(nom, prenom, phone, adresse, sexe)
        {
            this.id = id;
            this.nationalite = nationalite;
        }
    }
}
