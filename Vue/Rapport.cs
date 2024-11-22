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
    public partial class Rapport : UserControl
    {
        ArrayList vente = new ArrayList();
        ArrayList ventes = new ArrayList();

        ArrayList produits = new ArrayList();

        public Rapport()
        {
            InitializeComponent();
            produits = Factory.obtenirTousProduits();
            ventes = Factory.obtenirTousVentes();
            //afficher();
        }

        void ChargerProduit()
        {
            comboBoxVente.DataSource = produits;
            comboBoxVente.DisplayMember = "infoProduit";

        }

        void ChargerDate()
        {
            comboBoxDate.DataSource = ventes;
            comboBoxDate.DisplayMember = "infoDate";
        }

        public void afficher()
        {
            string produit = Factory.obtenirPU(comboBoxVente.Text).ID;
            vente = Factory.obtenirTousVentesParProduit(produit);
            dataGridViewReport.DataSource = vente;
        }

        private void comboBoxProduit_SelectedIndexChanged(object sender, EventArgs e)
        {
            //afficher();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Rapport_Load(object sender, EventArgs e)
        {
            ChargerDate();
            ChargerProduit();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            //afficher();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxVente_TextChanged(object sender, EventArgs e)
        {
            //afficher();
        }
    }
}
