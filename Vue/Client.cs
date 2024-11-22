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
using Modele;
using Controleur;

namespace Vue
{
    public partial class Client : UserControl
    {
        ArrayList clients = new ArrayList();
        ClientM cli = null;
        public Client()
        {
            InitializeComponent();
        }

        public void afficher()
        {
            clients = Factory.obtenirTousClients();
            dataGridView.DataSource = clients;
        }

        public void reinitialiser()
        {
            textBoxID.Text = "";
            textBoxNom.Text = "";
            textBoxPrenom.Text = "";
            textBoxPhone.Text = "";
            textBoxAdresse.Text = "";
            comboBoxNationalite.Text = "";
            foreach (Control cntrl in groupBoxSexe.Controls)
            {
                if (((RadioButton)cntrl).Checked)
                {
                    ((RadioButton)cntrl).Checked = false;
                    break;
                }
            }          
            textBoxRechercher.Text = "";
        }

        public void remplirDonneesDansChamps()
        {
            string id = textBoxRechercher.Text;
            ClientM cli = Factory.obtenirClientParId(id);
            textBoxID.Text = cli.Id;
            textBoxNom.Text = cli.Nom;
            textBoxPrenom.Text = cli.Prenom;
            textBoxPhone.Text = cli.Phone;
            textBoxAdresse.Text = cli.Adresse;
            comboBoxNationalite.Text = cli.Nationalite;
            foreach (Control cntrl in groupBoxSexe.Controls)
            {
                if (((RadioButton)cntrl).Checked)
                {
                    ((RadioButton)cntrl).Checked = false;
                    break;
                }
            }
            
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "")
            {
                MessageBox.Show("Veillez compléter au moins l'identifiant du client pour l'enregistrement !", "L'identifiant non complété", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (Factory.obtenirClientParId(textBoxID.Text) != null)
            {
                MessageBox.Show("Un utilisateur avec matricule : \'" + textBoxID.Text + "\'existe déjà. Vous ne pouvez que le modifier avec le bouton \'Modifier\' ou le supprimer avec le bouton \'Supprimer\'.", "Erreur : L'utilisateur existe déjà!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                string id = textBoxID.Text;
                string nom = textBoxNom.Text;
                string prenom = textBoxPrenom.Text;
                string phone = textBoxPhone.Text;
                string adresse = textBoxAdresse.Text;
                string nationalite = comboBoxNationalite.Text;
                string sexe = "";
                foreach (Control cntrl in groupBoxSexe.Controls)
                {
                    if (((RadioButton)cntrl).Checked)
                    {
                        sexe = ((RadioButton)cntrl).Text;
                        break;
                    }
                }



                cli = new ClientM(nom, prenom, phone, adresse, sexe, id, nationalite);


                Factory.AjouterClient(cli);

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
                MessageBox.Show("Veuillez donner l'identifiant du client pour le rechercher!", "Manque d'identifiant du client", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                cli = Factory.obtenirClientParId(textBoxRechercher.Text);
                if (cli == null)
                {
                    MessageBox.Show("Le client avec l'identifiant: " + textBoxRechercher.Text + " n'est pas enregistré. Il faut d'abord l'enregistrer avec le bouton 'Ajouter'.", "Erreur : Le client non trouvé", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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
            /*string id = textBoxID.Text;
            string nom = textBoxNom.Text;
            string prenom = textBoxPrenom.Text;
            string phone = textBoxPhone.Text;
            string adresse = textBoxAdresse.Text;
            string nationalite = comboBoxNationalite.Text;
            string sexe = "";
            foreach (Control cntrl in groupBoxSexe.Controls)
            {
                if (((RadioButton)cntrl).Checked)
                {
                    sexe = ((RadioButton)cntrl).Text;
                }
            }

            cli = new ClientM(nom, prenom, phone, adresse, sexe, id, nationalite);
            if (cli != null)
            {
                DialogResult R = MessageBox.Show("Voulez-vous vraiment supprimer " + cli.Nom + " " + cli.Prenom + " dans la liste des client?", "Attention suppression d'un client pour de bon.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    Factory.supprimerClient(cli);
                    afficher();
                    reinitialiser();
                }
            }*/
            if (cli != null)
            {
                DialogResult resultat;
                if (cli.Sexe == "Homme")
                {
                    resultat = MessageBox.Show("Vous êtes sûr de supprimer le client "+ cli.Nom + " " + cli.Prenom + "?", "Suppression du client!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
                else
                {
                    resultat = MessageBox.Show("Vous êtes sûr de supprimer la cliente " + cli.Nom + " " + cli.Prenom + "?", "Suppression du client!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }

                if (resultat == DialogResult.Yes)
                {
                    Factory.supprimerClient(cli);
                    reinitialiser();
                    afficher();
                }
            }
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "")
            {
                MessageBox.Show("Compléter au moins l'identifiant du client pour modifier (il faut qu'il soit enregistré)", "l'identifiant du client qui manque", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                cli = Factory.obtenirClientParId(textBoxID.Text);
                if (cli != null)
                {
                    cli.Nom = textBoxNom.Text;
                    cli.Prenom = textBoxPrenom.Text;
                    cli.Phone = textBoxPhone.Text;
                    cli.Adresse = textBoxAdresse.Text;
                    cli.Nationalite = comboBoxNationalite.Text;
                    cli.Sexe = "";
                    foreach (Control cntrl in groupBoxSexe.Controls)
                    {
                        if (((RadioButton)cntrl).Checked)
                        {
                            cli.Sexe = cntrl.Text;
                            break;
                        }
                    }

                    Factory.ModifierClient(cli);
                    reinitialiser();
                    afficher();
                }
                else
                {
                    MessageBox.Show("Le client avec l'identifiant : '" + textBoxID.Text + "'n'est pas enregistré. Veuillez l'enregistrer d'abord avec le bouton 'Ajouter'", "Erreur : Le client n'existe pas", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }
    }
}
