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
    public partial class Serveur : Form
    {
        public Serveur()
        {
            InitializeComponent();
        }

        private void buttonProduit_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            ProduitServeur produit = new ProduitServeur();
            this.panel.Controls.Add(produit);
        }

        private void buttonVente_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            Vente vente = new Vente();
            this.panel.Controls.Add(vente);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            LogIn log = new LogIn();
            log.Show();
            this.Hide();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
