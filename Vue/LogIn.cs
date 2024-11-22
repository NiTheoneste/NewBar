using Controleur;
using Modele;
using System;
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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        UtilisateurM uti = null;

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            uti = new UtilisateurM();
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
     
            uti = Factory.userLogin(username, password);
            if (uti != null )
            {
                if (uti.Profil == "Gérant")
                {
                    string nomGerant = uti.Nom + " " + uti.Prenom;
                    MenuForm menu = new MenuForm();
                    menu.Show();
                    this.Hide();
                }
                else if (uti.Profil == "Serveur")
                {
                    string nomServeur = uti.Nom + " " + uti.Prenom;
                    Serveur serveur = new Serveur();
                    serveur.Show();
                    //MessageBox.Show("Je suis " + nomServeur + ", réceptioniste.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Votre nom d'utilisateur ou mot de passe est incorrect.", "Echec d'authentification",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
