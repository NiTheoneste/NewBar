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
    public partial class ProduitServeur : UserControl
    {
        ArrayList produits = new ArrayList();
        ProduitM pro = null;
        public ProduitServeur()
        {
            InitializeComponent();
        }

        public void afficher()
        {
            produits = Factory.obtenirTousProduits();
            dataGridView.DataSource = produits;
        }

        private void buttonAfficher_Click(object sender, EventArgs e)
        {
            afficher();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
