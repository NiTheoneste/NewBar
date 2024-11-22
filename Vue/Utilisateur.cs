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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Vue
{
    public partial class Utilisateur : UserControl
    {
        ArrayList utilisateurs = new ArrayList();
        UtilisateurM ut = null;
        public Utilisateur()
        {
            InitializeComponent();
        }

        public void afficher()
        {
            utilisateurs = Factory.obtenirTousUtilisateurs();
            dataGridView.DataSource = utilisateurs;
        }

        public void remplirDonneesDansChamps()
        {
            string matricule = textBoxRechercher.Text;
            UtilisateurM uti = Factory.obtenirUtilisateurParMatricule(matricule);
            textBoxMatricule.Text = uti.Matricule;
            textBoxNom.Text = uti.Nom;
            textBoxPrenom.Text = uti.Prenom;
            textBoxAge.Text = uti.Age.ToString();
            textBoxPhone.Text = uti.Phone;
            textBoxEmail.Text = uti.Email;
            foreach (Control cntrl in groupBoxSexe.Controls)
            {
                if (((RadioButton)cntrl).Checked)
                {
                    ((RadioButton)cntrl).Checked = false;
                    break;
                }
            }
            comboBoxProfil.Text = uti.Profil;
            textBoxUsername.Text = uti.Username;
            textBoxPassword.Text = uti.Password;
            textBoxAdresse.Text = uti.Adresse;
        }

        public void reinitialiser()
        {
            textBoxMatricule.Text = "";
            textBoxNom.Text = "";
            textBoxPrenom.Text = "";
            textBoxAge.Text = "";
            textBoxPhone.Text = "";
            textBoxEmail.Text = "";
            foreach (Control cntrl in groupBoxSexe.Controls)
            {
                if (((RadioButton)cntrl).Checked)
                {
                    ((RadioButton)cntrl).Checked = false;
                    break;
                }
            }
            comboBoxProfil.Text = "";
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxAdresse.Text = "";
            textBoxRechercher.Text = "";
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (textBoxMatricule.Text == ""|| textBoxNom.Text == "")
            {
                MessageBox.Show("Veillez compléter au moins le matricule du l'utilisateur pour l'enregistrement !", "Le matricule non complété", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (Factory.obtenirUtilisateurParMatricule(textBoxMatricule.Text) != null)
            {
                MessageBox.Show("Un utilisateur avec matricule : \'" + textBoxMatricule.Text + "\'existe déjà. Vous ne pouvez que le modifier avec le bouton \'Modifier\' ou le supprimer avec le bouton \'Supprimer\'.", "Erreur : L'utilisateur existe déjà!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                string matricule = textBoxMatricule.Text;
                string nom = textBoxNom.Text;
                string prenom = textBoxPrenom.Text;
                //int age = int.Parse(textBoxAge.Text);
                // Vérifier que l'âge est un nombre valide et supérieur à 0
                if (!int.TryParse(textBoxAge.Text, out int age) || age <= 0)
                {
                    MessageBox.Show("Veuillez entrer un âge valide et supérieur à zéro.", "Age invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string phone = textBoxPhone.Text;
                string email = textBoxEmail.Text;
                string sexe = "";
                foreach (Control cntrl in groupBoxSexe.Controls)
                {
                    if (((RadioButton)cntrl).Checked)
                    {
                        sexe = ((RadioButton)cntrl).Text;
                        break;
                    }
                }
                string profil = comboBoxProfil.Text;
                string username = textBoxUsername.Text;
                string password = textBoxPassword.Text;
                string adresse = textBoxAdresse.Text;



                ut = new UtilisateurM(nom, prenom, phone, adresse, sexe, matricule, email, profil, username, password, age);
                textBoxSalaire.Text = ut.Salaire.ToString();


                Factory.AjouterUtilisateur(ut);

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
                MessageBox.Show("Veuillez donner le matricule de l'utilisateur pour le rechercher!", "Manque du matricule d'utilisateur", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                ut = Factory.obtenirUtilisateurParMatricule(textBoxRechercher.Text);
                if (ut == null)
                {
                    MessageBox.Show("L'utilisateur avec le matricule: " + textBoxRechercher.Text + " n'est pas enregistré. Il faut d'abord l'enregistrer avec le bouton 'Ajouter'.", "Erreur : L'utilisateur non trouvé", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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
            /*string matricule = textBoxMatricule.Text;
            string nom = textBoxNom.Text;
            string prenom = textBoxPrenom.Text;
            int age = int.Parse(textBoxAge.Text);
            string phone = textBoxPhone.Text;
            string email = textBoxEmail.Text;
            string sexe = "";
            foreach (Control cntrl in groupBoxSexe.Controls)
            {
                if (((RadioButton)cntrl).Checked)
                {
                    sexe = ((RadioButton)cntrl).Text;
                }
            }
            string profil = comboBoxProfil.Text;
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string adresse = textBoxAdresse.Text;

            ut = new UtilisateurM(nom,prenom,phone,adresse,sexe,matricule,email,profil,username,password,age);*/
            if (ut != null)
            {
                DialogResult R = MessageBox.Show("Voulez-vous vraiment supprimer " + ut.Nom + " " + ut.Prenom + " dans la liste des utilisateurs?", "Attention suppression d'un utilisateur pour de bon.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    Factory.supprimerUtilisateur(ut);
                    afficher();
                    reinitialiser();
                }
            }
        }

        //UtilisateurM uti = null;

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (textBoxMatricule.Text == "")
            {
                MessageBox.Show("Compléter au moins le matricule du l'utilisateur pour modifier (il faut qu'il soit enregistré)", "le matricule de l'utilisateur qui manque", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                ut = Factory.obtenirUtilisateurParMatricule(textBoxMatricule.Text);
                if (ut != null)
                {
                    ut.Nom = textBoxNom.Text;
                    ut.Prenom = textBoxPrenom.Text;
                    ut.Age = int.Parse(textBoxAge.Text);
                    ut.Phone = textBoxPhone.Text;
                    ut.Email = textBoxEmail.Text;
                    ut.Sexe = "";
                    foreach (Control cntrl in groupBoxSexe.Controls)
                    {
                        if (((RadioButton)cntrl).Checked)
                        {
                            ut.Sexe = cntrl.Text;
                            break;
                        }
                    }
                    ut.Profil = comboBoxProfil.Text;
                    ut.Username = textBoxUsername.Text;
                    ut.Password = textBoxPassword.Text;
                    ut.Adresse = textBoxAdresse.Text;

                    Factory.ModifierUtilisateur(ut);
                    reinitialiser();
                    afficher();
                }
                else
                {
                    MessageBox.Show("L'utilisateur avec le matricule : '" + textBoxMatricule.Text + "'n'est pas enregistré. Veuillez l'enregistrer d'abord avec le bouton 'Ajouter'", "Erreur : L'utilisateur n'existe pas", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBoxProfil_TextChanged(object sender, EventArgs e)
        {
            double salaire = 0;
            if (comboBoxProfil.Text == "Gérant") salaire = 1000000;
            else if (comboBoxProfil.Text == "Comptable") salaire = 800000;
            else if (comboBoxProfil.Text == "Réceptioniste") salaire = 600000;
            else if (comboBoxProfil.Text == "Serveur") salaire = 400000;
            else if (comboBoxProfil.Text == "Veternaire") salaire = 300000;
            //return salaire;

            textBoxSalaire.Text = salaire.ToString();
        }
    }
}
