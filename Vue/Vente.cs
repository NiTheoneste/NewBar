using Controleur;
using Modele;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vue
{
    public partial class Vente : UserControl
    {
        ArrayList ventes = new ArrayList();
        VenteM ve = null;

        ArrayList clients = new ArrayList();
        ArrayList produits = new ArrayList();

        public Vente()
        {
            InitializeComponent();
            clients = Factory.obtenirTousClients();
            produits = Factory.obtenirTousProduits();
            string nom = comboBoxProduit.Text;
            ProduitM prod = new ProduitM();
            if (nom != "")
            {
                prod = Factory.obtenirPU(nom);

                if (prod != null)
                {
                    textBoxPU.Text = Factory.obtenirPU(nom).PrixUnitaire.ToString();
                }
                else
                {
                    // MessageBox.Show("Produit vide");
                }
            }
        }

        void ChargerClient()
        {
            comboBoxClient.DataSource = clients;
            comboBoxClient.DisplayMember = "infoClient";
        }

        void ChargerProduit()
        {
            comboBoxProduit.DataSource = produits;
            comboBoxProduit.DisplayMember = "infoProduit";

        }

        private void Vente_Load(object sender, EventArgs e)
        {
            ChargerClient();
            ChargerProduit();
        }

        public void afficher()
        {
            ventes = Factory.obtenirTousVentes();
            dataGridView.DataSource = ventes;
        }

        public void reinitialiser()
        {
            textBoxId.Text = "";
            //comboBoxClient.Text = "";
            //comboBoxProduit.Text = "";
            textBoxQuantite.Text = "";
            //textBoxPU.Text = "";
            textBoxPT.Text = "";

            textBoxRechercher.Text = "";
        }

        public void remplirDonneesDansChamps()
        {
            //string client = Factory.obtenirID(comboBoxClient.Text).Nom;
            //string produit = Factory.obtenirPU(comboBoxProduit.Text).Nom;

            string id = textBoxRechercher.Text;
            VenteM ve = Factory.obtenirVenteParId(id);
            textBoxId.Text = ve.Id;
            comboBoxClient.Text = ve.Client;
            comboBoxProduit.Text = ve.Produit;
            textBoxQuantite.Text = ve.Quantite.ToString();
            textBoxPU.Text = ve.PrixUnitaire.ToString();
            textBoxPT.Text = ve.PrixTotal.ToString();
            dateTimePicker.Value = ve.DateOperation;

        }

        public void GestionQuantiteProduit()
        {
            int qte = int.Parse(textBoxQuantite.Text);
            string nom = comboBoxProduit.Text;
            ProduitM pro = new ProduitM();
            if (nom != "")
            {
                pro = Factory.obtenirPU(nom);

                if (pro != null)
                {

                    int quantiteActuelle = Factory.obtenirPU(nom).Quantite;
                    if (quantiteActuelle >= qte)
                    {
                        int quantiteRestante = quantiteActuelle - qte;
                        if (pro != null)
                        {
                            pro.Nom = nom;
                            pro.Quantite = quantiteRestante;

                            Factory.QuantiteRestante(pro);
                        }
                        else
                        {
                            MessageBox.Show(nom + " n'a pas de quantité.\nVeuillez l'ajouter d'abord avec le bouton 'Modifier'", "Erreur : La quantité est vide", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }

                        string id = textBoxId.Text;
                        string client = Factory.obtenirID(comboBoxClient.Text).Id;
                        string produit = Factory.obtenirPU(comboBoxProduit.Text).ID;
                        int quantite = int.Parse(textBoxQuantite.Text);
                        double prixUnitaire = double.Parse(textBoxPU.Text);
                        double prixTotal = double.Parse(textBoxPT.Text);
                        DateTime dateOperation = dateTimePicker.Value;

                        ve = new VenteM(id, client, produit, quantite, prixUnitaire, prixTotal, dateOperation);


                        Factory.AjouterVente(ve);

                        afficher();
                        reinitialiser();

                        if (quantiteRestante == 0)
                        {
                            MessageBox.Show(nom + " vient d'etre épuisé. Il vous reste que " + quantiteRestante + " " + nom + " \nVeuillez donc charger votre produit.", "Produit épuisé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Désolé la quantité est insiffisante pour éffectuer cette vente.\nIl vous reste que " + quantiteActuelle + " " + nom + ".\n \nMerci pour votre compréhension.", "Quantité insuffisante", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        return;
                    }

                }
                else
                {
                    //MessageBox.Show("Produit vide");
                }

            }
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            GestionQuantiteProduit();
        }

        private void buttonAfficher_Click(object sender, EventArgs e)
        {
            afficher();
        }

        private void buttonReinitialiser_Click(object sender, EventArgs e)
        {
            reinitialiser();
        }

        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            if (textBoxRechercher.Text == "")
            {
                MessageBox.Show("Veuillez donner l'identifiant d'une vente pour la rechercher!", "Manque d'identifiant d'une vente", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                ve = Factory.obtenirVenteParId(textBoxRechercher.Text);
                if (ve == null)
                {
                    MessageBox.Show("La vente avec l'identifiant: " + textBoxRechercher.Text + " n'est pas enregistrée. Il faut d'abord l'enregistrer avec le bouton 'Ajouter'.", "Erreur : La vente non trouvée", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    remplirDonneesDansChamps();
                    afficher();
                }
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (ve != null)
            {
                DialogResult R = MessageBox.Show("Voulez-vous vraiment supprimer cette vente dans la liste des ventes?", "Attention suppression d'une vente pour de bon.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    Factory.supprimerVente(ve);
                    afficher();
                    reinitialiser();
                }
            }
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text == "")
            {
                MessageBox.Show("Compléter au moins l'identifiant d'une vente pour modifier (il faut qu'il soit enregistrée)", "l'identifiant d'une vente qui manque", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                ve = Factory.obtenirVenteParId(textBoxId.Text);
                if (ve != null)
                {
                    ve.Client = Factory.obtenirID(comboBoxClient.Text).Id;
                    ve.Produit = Factory.obtenirPU(comboBoxProduit.Text).ID;
                    ve.Quantite = int.Parse(textBoxQuantite.Text);
                    ve.PrixUnitaire = double.Parse(textBoxPU.Text);
                    ve.PrixTotal = double.Parse(textBoxPT.Text);
                    ve.DateOperation = dateTimePicker.Value;

                    Factory.ModifierVente(ve);
                    reinitialiser();
                    afficher();
                }
                else
                {
                    MessageBox.Show("La vente'n'est pas enregistré. Veuillez l'enregistrer d'abord avec le bouton 'Ajouter'", "Erreur : Le produit n'existe pas", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBoxProduit_TextChanged(object sender, EventArgs e)
        {
            string nom = comboBoxProduit.Text;
            ProduitM prod = new ProduitM();
            if (nom != "")
            {
                prod = Factory.obtenirPU(nom);

                if (prod != null)
                {
                    textBoxPU.Text = Factory.obtenirPU(nom).PrixUnitaire.ToString();

                    //int quantiteActuelle = Factory.obtenirPU(nom).Quantite;

                }
                else
                {
                    //MessageBox.Show("Produit vide");
                }

            }
        }

        private void textBoxQuantite_TextChanged(object sender, EventArgs e)
        {
            string qtee = textBoxQuantite.Text;
            if (int.TryParse(qtee, out int qte))
            {
                qte = int.Parse(textBoxQuantite.Text);
                if (qte > 0)
                {
                    double pu = double.Parse(textBoxPU.Text);
                    double pt = qte * pu;
                    textBoxPT.Text = pt.ToString();
                }
                else
                {
                    MessageBox.Show("Tapez un nombre entier supérieur à 0", "Nombre invalide", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                //textBoxPT.Text = "";
                //MessageBox.Show("Entrer un nombre entier valide", "Nombre invalide", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                //return;
            }
        }

        private void comboBoxProduit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
