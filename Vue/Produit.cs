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
    public partial class Produit : UserControl
    {
        ArrayList produits = new ArrayList();
        ProduitM pro = null;
        public Produit()
        {
            InitializeComponent();
        }

        public void afficher()
        {
            produits = Factory.obtenirTousProduits();
            dataGridView.DataSource = produits;
        }

        public void reinitialiser()
        {
            textBoxID.Text = "";
            textBoxNom.Text = "";
            textBoxQuantite.Text = "";
            textBoxPU.Text = "";
            textBoxVolume.Text = "";
            dateTimePicker.Text = "";
           
            textBoxRechercher.Text = "";
        }

        public void remplirDonneesDansChamps()
        {
            string id = textBoxRechercher.Text;
            ProduitM pro = Factory.obtenirProduitParId(id);
            textBoxID.Text = pro.ID;
            textBoxNom.Text = pro.Nom;
            textBoxQuantite.Text = pro.Quantite.ToString();
            textBoxPU.Text = pro.PrixUnitaire.ToString();
            textBoxVolume.Text = pro.Volume.ToString();
            dateTimePicker.Value = pro.DateExpiration;

        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "")
            {
                MessageBox.Show("Veillez compléter au moins l'identifiant du produit pour l'enregistrement !", "L'identifiant non complété", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (Factory.obtenirProduitParId(textBoxID.Text) != null)
            {
                MessageBox.Show("Un produit avec identifiant : \'" + textBoxID.Text + "\'existe déjà. Vous ne pouvez que le modifier avec le bouton \'Modifier\' ou le supprimer avec le bouton \'Supprimer\'.", "Erreur : Le produit existe déjà!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                string id = textBoxID.Text;
                string nom = textBoxNom.Text;
                int quantite = int.Parse(textBoxQuantite.Text);
                double prixUnitaire = double.Parse(textBoxPU.Text);
                float volume = float.Parse(textBoxVolume.Text);
                DateTime dateExpiration = dateTimePicker.Value;



                pro = new ProduitM(id, nom, quantite, prixUnitaire, dateExpiration, volume);


                Factory.AjouterProduit(pro);

                afficher();
                reinitialiser();
            }
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
                MessageBox.Show("Veuillez donner l'identifiant du produit pour le rechercher!", "Manque d'identifiant du produit", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                pro = Factory.obtenirProduitParId(textBoxRechercher.Text);
                if (pro == null)
                {
                    MessageBox.Show("Le produit avec l'identifiant: " + textBoxRechercher.Text + " n'est pas enregistré. Il faut d'abord l'enregistrer avec le bouton 'Ajouter'.", "Erreur : Le produit non trouvé", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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
            if (pro != null)
            {
                DialogResult R = MessageBox.Show("Voulez-vous vraiment supprimer " + pro.Nom + " dans la liste des produits?", "Attention suppression d'un produit pour de bon.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    Factory.supprimerProduit(pro);
                    afficher();
                    reinitialiser();
                }
            }
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "")
            {
                MessageBox.Show("Compléter au moins l'identifiant du produit pour modifier (il faut qu'il soit enregistré)", "l'identifiant du produit qui manque", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                pro = Factory.obtenirProduitParId(textBoxID.Text);
                if (pro != null)
                {
                    pro.Nom = textBoxNom.Text;
                    pro.Quantite = int.Parse(textBoxQuantite.Text);
                    pro.PrixUnitaire = double.Parse(textBoxPU.Text);
                    pro.Volume = float.Parse(textBoxVolume.Text);
                    pro.DateExpiration = dateTimePicker.Value;

                    Factory.ModifierProduit(pro);
                    reinitialiser();
                    afficher();
                }
                else
                {
                    MessageBox.Show("Le produit avec l'identifiant : '" + textBoxID.Text + "'n'est pas enregistré. Veuillez l'enregistrer d'abord avec le bouton 'Ajouter'", "Erreur : Le produit n'existe pas", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }
    }
}
