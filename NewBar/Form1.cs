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
using Vue;
namespace NewBar
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void buttonProduit_Click(object sender, EventArgs e)
        {
            this.panelView.Controls.Clear();
            Produit pro = new Produit();
            this.panelView.Controls.Add(pro);
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            this.panelView.Controls.Clear();
            Client cli = new Client();
            this.panelView.Controls.Add(cli);
        }

        private void buttonVentes_Click(object sender, EventArgs e)
        {
            this.panelView.Controls.Clear();
            Vente ve = new Vente();
            this.panelView.Controls.Add((ve));
        }

        private void buttonUtilisateur_Click(object sender, EventArgs e)
        {
            this.panelView.Controls.Clear();
            Utilisateur ut = new Utilisateur();
            this.panelView.Controls.Add(ut);
        }

        private void buttonAccuei_Click(object sender, EventArgs e)
        {
            this.panelView.Controls.Clear();
            Accueil accueil = new Accueil();
            this.panelView.Controls.Add(accueil);
        }
    }
}
