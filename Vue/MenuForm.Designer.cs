namespace Vue
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTitre = new System.Windows.Forms.Panel();
            this.labelExit = new System.Windows.Forms.Label();
            this.labelTitre = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelDateHeure = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelViewMenu = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonUtilisateur = new System.Windows.Forms.Button();
            this.buttonRapports = new System.Windows.Forms.Button();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonVente = new System.Windows.Forms.Button();
            this.buttonAccueil = new System.Windows.Forms.Button();
            this.buttonProduit = new System.Windows.Forms.Button();
            this.panelTitre.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelViewMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitre
            // 
            this.panelTitre.BackColor = System.Drawing.Color.CadetBlue;
            this.panelTitre.Controls.Add(this.labelExit);
            this.panelTitre.Controls.Add(this.labelTitre);
            this.panelTitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitre.ForeColor = System.Drawing.Color.White;
            this.panelTitre.Location = new System.Drawing.Point(0, 0);
            this.panelTitre.Name = "panelTitre";
            this.panelTitre.Size = new System.Drawing.Size(1276, 31);
            this.panelTitre.TabIndex = 0;
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExit.Location = new System.Drawing.Point(1248, 8);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(16, 16);
            this.labelExit.TabIndex = 1;
            this.labelExit.Text = "X";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.Color.White;
            this.labelTitre.Location = new System.Drawing.Point(511, 5);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(244, 20);
            this.labelTitre.TabIndex = 0;
            this.labelTitre.Text = "NewBar Management System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panelDateHeure);
            this.panel2.Controls.Add(this.buttonLogOut);
            this.panel2.Controls.Add(this.buttonUtilisateur);
            this.panel2.Controls.Add(this.buttonRapports);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.buttonClient);
            this.panel2.Controls.Add(this.buttonVente);
            this.panel2.Controls.Add(this.buttonAccueil);
            this.panel2.Controls.Add(this.buttonProduit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 533);
            this.panel2.TabIndex = 1;
            // 
            // panelDateHeure
            // 
            this.panelDateHeure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelDateHeure.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDateHeure.Location = new System.Drawing.Point(0, 40);
            this.panelDateHeure.Name = "panelDateHeure";
            this.panelDateHeure.Size = new System.Drawing.Size(200, 31);
            this.panelDateHeure.TabIndex = 0;
            this.panelDateHeure.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDateHeure_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 40);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "NewBar";
            // 
            // panelViewMenu
            // 
            this.panelViewMenu.Controls.Add(this.pictureBox2);
            this.panelViewMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelViewMenu.Location = new System.Drawing.Point(200, 31);
            this.panelViewMenu.Name = "panelViewMenu";
            this.panelViewMenu.Size = new System.Drawing.Size(1076, 533);
            this.panelViewMenu.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Vue.Properties.Resources.acceuil;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1076, 533);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Vue.Properties.Resources.beer;
            this.pictureBox1.Location = new System.Drawing.Point(0, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLogOut.BackgroundImage = global::Vue.Properties.Resources.Open_Pane;
            this.buttonLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLogOut.FlatAppearance.BorderSize = 0;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOut.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.Location = new System.Drawing.Point(0, 506);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(200, 27);
            this.buttonLogOut.TabIndex = 7;
            this.buttonLogOut.Text = "Se déconnecter";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonUtilisateur
            // 
            this.buttonUtilisateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonUtilisateur.BackgroundImage = global::Vue.Properties.Resources.User;
            this.buttonUtilisateur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonUtilisateur.FlatAppearance.BorderSize = 0;
            this.buttonUtilisateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUtilisateur.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUtilisateur.Location = new System.Drawing.Point(0, 429);
            this.buttonUtilisateur.Name = "buttonUtilisateur";
            this.buttonUtilisateur.Size = new System.Drawing.Size(200, 39);
            this.buttonUtilisateur.TabIndex = 4;
            this.buttonUtilisateur.Text = "Utilisateurs";
            this.buttonUtilisateur.UseVisualStyleBackColor = false;
            this.buttonUtilisateur.Click += new System.EventHandler(this.buttonUtilisateur_Click);
            // 
            // buttonRapports
            // 
            this.buttonRapports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRapports.BackgroundImage = global::Vue.Properties.Resources.Graph_Report;
            this.buttonRapports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonRapports.FlatAppearance.BorderSize = 0;
            this.buttonRapports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRapports.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRapports.Location = new System.Drawing.Point(0, 384);
            this.buttonRapports.Name = "buttonRapports";
            this.buttonRapports.Size = new System.Drawing.Size(200, 39);
            this.buttonRapports.TabIndex = 6;
            this.buttonRapports.Text = "Rapports";
            this.buttonRapports.UseVisualStyleBackColor = false;
            this.buttonRapports.Click += new System.EventHandler(this.buttonRapports_Click);
            // 
            // buttonClient
            // 
            this.buttonClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonClient.BackgroundImage = global::Vue.Properties.Resources.Account;
            this.buttonClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonClient.FlatAppearance.BorderSize = 0;
            this.buttonClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClient.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClient.Location = new System.Drawing.Point(0, 297);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(200, 39);
            this.buttonClient.TabIndex = 3;
            this.buttonClient.Text = "Clients";
            this.buttonClient.UseVisualStyleBackColor = false;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonVente
            // 
            this.buttonVente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonVente.BackgroundImage = global::Vue.Properties.Resources.Cost;
            this.buttonVente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonVente.FlatAppearance.BorderSize = 0;
            this.buttonVente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVente.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVente.Location = new System.Drawing.Point(0, 342);
            this.buttonVente.Name = "buttonVente";
            this.buttonVente.Size = new System.Drawing.Size(200, 39);
            this.buttonVente.TabIndex = 6;
            this.buttonVente.Text = "Ventes";
            this.buttonVente.UseVisualStyleBackColor = false;
            this.buttonVente.Click += new System.EventHandler(this.buttonVente_Click);
            // 
            // buttonAccueil
            // 
            this.buttonAccueil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAccueil.BackgroundImage = global::Vue.Properties.Resources.House;
            this.buttonAccueil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAccueil.FlatAppearance.BorderSize = 0;
            this.buttonAccueil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccueil.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccueil.Location = new System.Drawing.Point(0, 218);
            this.buttonAccueil.Name = "buttonAccueil";
            this.buttonAccueil.Size = new System.Drawing.Size(200, 39);
            this.buttonAccueil.TabIndex = 2;
            this.buttonAccueil.Text = "Accueil";
            this.buttonAccueil.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAccueil.UseVisualStyleBackColor = false;
            this.buttonAccueil.Click += new System.EventHandler(this.buttonAccueil_Click);
            // 
            // buttonProduit
            // 
            this.buttonProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonProduit.BackgroundImage = global::Vue.Properties.Resources.Clear_Shopping_Cart;
            this.buttonProduit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonProduit.FlatAppearance.BorderSize = 0;
            this.buttonProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProduit.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProduit.Location = new System.Drawing.Point(0, 252);
            this.buttonProduit.Name = "buttonProduit";
            this.buttonProduit.Size = new System.Drawing.Size(200, 39);
            this.buttonProduit.TabIndex = 5;
            this.buttonProduit.Text = "Produits";
            this.buttonProduit.UseVisualStyleBackColor = false;
            this.buttonProduit.Click += new System.EventHandler(this.buttonProduit_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 564);
            this.Controls.Add(this.panelViewMenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.panelTitre.ResumeLayout(false);
            this.panelTitre.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelViewMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitre;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAccueil;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonUtilisateur;
        private System.Windows.Forms.Button buttonProduit;
        private System.Windows.Forms.Button buttonVente;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonRapports;
        private System.Windows.Forms.Panel panelDateHeure;
        private System.Windows.Forms.Panel panelViewMenu;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}