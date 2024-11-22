namespace NewBar
{
    partial class Form
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonDeconnexion = new System.Windows.Forms.Button();
            this.buttonVentes = new System.Windows.Forms.Button();
            this.buttonUtilisateur = new System.Windows.Forms.Button();
            this.buttonAccuei = new System.Windows.Forms.Button();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonProduit = new System.Windows.Forms.Button();
            this.panelView = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.buttonDeconnexion);
            this.panelMenu.Controls.Add(this.buttonVentes);
            this.panelMenu.Controls.Add(this.buttonUtilisateur);
            this.panelMenu.Controls.Add(this.buttonAccuei);
            this.panelMenu.Controls.Add(this.buttonClient);
            this.panelMenu.Controls.Add(this.buttonProduit);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.White;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(201, 581);
            this.panelMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 34);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "NewBar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NewBar.Properties.Resources.beer;
            this.pictureBox1.Location = new System.Drawing.Point(0, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonDeconnexion
            // 
            this.buttonDeconnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeconnexion.FlatAppearance.BorderSize = 0;
            this.buttonDeconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeconnexion.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeconnexion.Location = new System.Drawing.Point(0, 546);
            this.buttonDeconnexion.Name = "buttonDeconnexion";
            this.buttonDeconnexion.Size = new System.Drawing.Size(201, 32);
            this.buttonDeconnexion.TabIndex = 1;
            this.buttonDeconnexion.Text = "Se Deconnecter";
            this.buttonDeconnexion.UseVisualStyleBackColor = false;
            // 
            // buttonVentes
            // 
            this.buttonVentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonVentes.FlatAppearance.BorderSize = 0;
            this.buttonVentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVentes.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVentes.Location = new System.Drawing.Point(0, 340);
            this.buttonVentes.Name = "buttonVentes";
            this.buttonVentes.Size = new System.Drawing.Size(201, 32);
            this.buttonVentes.TabIndex = 1;
            this.buttonVentes.Text = "Ventes";
            this.buttonVentes.UseVisualStyleBackColor = false;
            this.buttonVentes.Click += new System.EventHandler(this.buttonVentes_Click);
            // 
            // buttonUtilisateur
            // 
            this.buttonUtilisateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonUtilisateur.FlatAppearance.BorderSize = 0;
            this.buttonUtilisateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUtilisateur.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUtilisateur.Location = new System.Drawing.Point(0, 378);
            this.buttonUtilisateur.Name = "buttonUtilisateur";
            this.buttonUtilisateur.Size = new System.Drawing.Size(201, 32);
            this.buttonUtilisateur.TabIndex = 1;
            this.buttonUtilisateur.Text = "Utilisateurs";
            this.buttonUtilisateur.UseVisualStyleBackColor = false;
            this.buttonUtilisateur.Click += new System.EventHandler(this.buttonUtilisateur_Click);
            // 
            // buttonAccuei
            // 
            this.buttonAccuei.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAccuei.FlatAppearance.BorderSize = 0;
            this.buttonAccuei.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccuei.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccuei.Location = new System.Drawing.Point(0, 216);
            this.buttonAccuei.Name = "buttonAccuei";
            this.buttonAccuei.Size = new System.Drawing.Size(201, 32);
            this.buttonAccuei.TabIndex = 1;
            this.buttonAccuei.Text = "Accueil";
            this.buttonAccuei.UseVisualStyleBackColor = false;
            this.buttonAccuei.Click += new System.EventHandler(this.buttonAccuei_Click);
            // 
            // buttonClient
            // 
            this.buttonClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonClient.FlatAppearance.BorderSize = 0;
            this.buttonClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClient.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClient.Location = new System.Drawing.Point(0, 292);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(201, 32);
            this.buttonClient.TabIndex = 1;
            this.buttonClient.Text = "Clients";
            this.buttonClient.UseVisualStyleBackColor = false;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonProduit
            // 
            this.buttonProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonProduit.FlatAppearance.BorderSize = 0;
            this.buttonProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProduit.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProduit.Location = new System.Drawing.Point(0, 254);
            this.buttonProduit.Name = "buttonProduit";
            this.buttonProduit.Size = new System.Drawing.Size(201, 32);
            this.buttonProduit.TabIndex = 1;
            this.buttonProduit.Text = "Produits";
            this.buttonProduit.UseVisualStyleBackColor = false;
            this.buttonProduit.Click += new System.EventHandler(this.buttonProduit_Click);
            // 
            // panelView
            // 
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(201, 0);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(1071, 581);
            this.panelView.TabIndex = 1;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 581);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form";
            this.Text = "NewBar Management system";
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonAccuei;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonProduit;
        private System.Windows.Forms.Button buttonDeconnexion;
        private System.Windows.Forms.Button buttonUtilisateur;
        private System.Windows.Forms.Button buttonVentes;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

