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
    public partial class MenuForm : Form
    {

        private Timer timer;
        public MenuForm()
        {
            InitializeComponent();

            // Initialise la minuterie pour actualiser l'heure et la date chaque seconde
            timer = new Timer();
            timer.Interval = 1000; // Interval en millisecondes (une seconde)
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Force le panneau à se redessiner à chaque tic de la minuterie
            panelDateHeure.Invalidate();
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAccueil_Click(object sender, EventArgs e)
        {
            this.panelViewMenu.Controls.Clear();
            Accueil accueil = new Accueil();
            this.panelViewMenu.Controls.Add(accueil);
        }

        private void buttonProduit_Click(object sender, EventArgs e)
        {
            this.panelViewMenu.Controls.Clear();
            Produit produit = new Produit();
            this.panelViewMenu.Controls.Add(produit);
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            this.panelViewMenu.Controls.Clear();
            Client client = new Client();
            this.panelViewMenu.Controls.Add(client);
        }

        private void buttonVente_Click(object sender, EventArgs e)
        {
            this.panelViewMenu.Controls.Clear();
            Vente vente = new Vente();
            this.panelViewMenu.Controls.Add(vente);
        }

        private void buttonUtilisateur_Click(object sender, EventArgs e)
        {
            this.panelViewMenu.Controls.Clear();
            Utilisateur utilisateur = new Utilisateur();
            this.panelViewMenu.Controls.Add(utilisateur);
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            LogIn log = new LogIn();
            log.Show();
            this.Hide();
        }

        private void buttonRapports_Click(object sender, EventArgs e)
        {
            this.panelViewMenu.Controls.Clear();
            Rapport rapport = new Rapport();
            this.panelViewMenu.Controls.Add(rapport);
        }

        private void panelDateHeure_Paint(object sender, PaintEventArgs e)
        {
            // Créez une police et une brosse pour le texte
            using (Font font = new Font("Arial", 12))
            using (Brush brush = new SolidBrush(Color.Black))
            {
                // Obtenez la date et l'heure actuelles
                string dateHeure = DateTime.Now.ToString("dd/MM/yyyy   HH:mm:ss");

                // Obtenez la taille du texte
                SizeF size = e.Graphics.MeasureString(dateHeure, font);

                // Calculez la position pour centrer le texte dans le panneau
                float x = (panelDateHeure.Width - size.Width) / 2;
                float y = (panelDateHeure.Height - size.Height) / 2;

                // Dessinez le texte dans le panneau
                e.Graphics.DrawString(dateHeure, font, brush, x, y);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
