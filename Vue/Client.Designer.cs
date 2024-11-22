namespace Vue
{
    partial class Client
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.groupBoxSexe = new System.Windows.Forms.GroupBox();
            this.radioButtonAutre = new System.Windows.Forms.RadioButton();
            this.radioButtonFemme = new System.Windows.Forms.RadioButton();
            this.radioButtonHomme = new System.Windows.Forms.RadioButton();
            this.labelNationalite = new System.Windows.Forms.Label();
            this.comboBoxNationalite = new System.Windows.Forms.ComboBox();
            this.textBoxRechercher = new System.Windows.Forms.TextBox();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonReinitialiser = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonAfficher = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBoxSexe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 37);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(402, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion des clients";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(110, 62);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(18, 13);
            this.labelId.TabIndex = 1;
            this.labelId.Text = "ID";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(110, 104);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(29, 13);
            this.labelNom.TabIndex = 2;
            this.labelNom.Text = "Nom";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(110, 142);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(43, 13);
            this.labelPrenom.TabIndex = 3;
            this.labelPrenom.Text = "Prénom";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(110, 179);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(58, 13);
            this.labelPhone.TabIndex = 4;
            this.labelPhone.Text = "Téléphone";
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Location = new System.Drawing.Point(452, 62);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(45, 13);
            this.labelAdresse.TabIndex = 5;
            this.labelAdresse.Text = "Adresse";
            // 
            // textBoxID
            // 
            this.textBoxID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxID.Location = new System.Drawing.Point(186, 55);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(197, 20);
            this.textBoxID.TabIndex = 6;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(186, 97);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(197, 20);
            this.textBoxNom.TabIndex = 7;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(186, 135);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(197, 20);
            this.textBoxPrenom.TabIndex = 8;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(186, 172);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(197, 20);
            this.textBoxPhone.TabIndex = 9;
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(525, 55);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(197, 20);
            this.textBoxAdresse.TabIndex = 10;
            // 
            // groupBoxSexe
            // 
            this.groupBoxSexe.Controls.Add(this.radioButtonAutre);
            this.groupBoxSexe.Controls.Add(this.radioButtonFemme);
            this.groupBoxSexe.Controls.Add(this.radioButtonHomme);
            this.groupBoxSexe.Location = new System.Drawing.Point(455, 135);
            this.groupBoxSexe.Name = "groupBoxSexe";
            this.groupBoxSexe.Size = new System.Drawing.Size(267, 57);
            this.groupBoxSexe.TabIndex = 11;
            this.groupBoxSexe.TabStop = false;
            this.groupBoxSexe.Text = "Sexe";
            // 
            // radioButtonAutre
            // 
            this.radioButtonAutre.AutoSize = true;
            this.radioButtonAutre.Location = new System.Drawing.Point(202, 19);
            this.radioButtonAutre.Name = "radioButtonAutre";
            this.radioButtonAutre.Size = new System.Drawing.Size(50, 17);
            this.radioButtonAutre.TabIndex = 2;
            this.radioButtonAutre.TabStop = true;
            this.radioButtonAutre.Text = "Autre";
            this.radioButtonAutre.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemme
            // 
            this.radioButtonFemme.AutoSize = true;
            this.radioButtonFemme.Location = new System.Drawing.Point(98, 19);
            this.radioButtonFemme.Name = "radioButtonFemme";
            this.radioButtonFemme.Size = new System.Drawing.Size(59, 17);
            this.radioButtonFemme.TabIndex = 1;
            this.radioButtonFemme.TabStop = true;
            this.radioButtonFemme.Text = "Femme";
            this.radioButtonFemme.UseVisualStyleBackColor = true;
            // 
            // radioButtonHomme
            // 
            this.radioButtonHomme.AutoSize = true;
            this.radioButtonHomme.Location = new System.Drawing.Point(18, 19);
            this.radioButtonHomme.Name = "radioButtonHomme";
            this.radioButtonHomme.Size = new System.Drawing.Size(61, 17);
            this.radioButtonHomme.TabIndex = 0;
            this.radioButtonHomme.TabStop = true;
            this.radioButtonHomme.Text = "Homme";
            this.radioButtonHomme.UseVisualStyleBackColor = true;
            // 
            // labelNationalite
            // 
            this.labelNationalite.AutoSize = true;
            this.labelNationalite.Location = new System.Drawing.Point(452, 104);
            this.labelNationalite.Name = "labelNationalite";
            this.labelNationalite.Size = new System.Drawing.Size(57, 13);
            this.labelNationalite.TabIndex = 12;
            this.labelNationalite.Text = "Nationalité";
            // 
            // comboBoxNationalite
            // 
            this.comboBoxNationalite.FormattingEnabled = true;
            this.comboBoxNationalite.Items.AddRange(new object[] {
            "Burundi",
            "Rwanda",
            "Kenya",
            "Tanzanie",
            "Ouganda",
            "RD Congo",
            "Zambie"});
            this.comboBoxNationalite.Location = new System.Drawing.Point(525, 96);
            this.comboBoxNationalite.Name = "comboBoxNationalite";
            this.comboBoxNationalite.Size = new System.Drawing.Size(197, 21);
            this.comboBoxNationalite.TabIndex = 13;
            // 
            // textBoxRechercher
            // 
            this.textBoxRechercher.Location = new System.Drawing.Point(793, 55);
            this.textBoxRechercher.Name = "textBoxRechercher";
            this.textBoxRechercher.Size = new System.Drawing.Size(185, 20);
            this.textBoxRechercher.TabIndex = 14;
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonRechercher.FlatAppearance.BorderSize = 0;
            this.buttonRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRechercher.ForeColor = System.Drawing.Color.White;
            this.buttonRechercher.Location = new System.Drawing.Point(855, 81);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(81, 23);
            this.buttonRechercher.TabIndex = 15;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = false;
            this.buttonRechercher.Click += new System.EventHandler(this.buttonRechercher_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonAjouter.FlatAppearance.BorderSize = 0;
            this.buttonAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouter.ForeColor = System.Drawing.Color.White;
            this.buttonAjouter.Location = new System.Drawing.Point(186, 233);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(75, 23);
            this.buttonAjouter.TabIndex = 16;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonModifier.FlatAppearance.BorderSize = 0;
            this.buttonModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifier.ForeColor = System.Drawing.Color.White;
            this.buttonModifier.Location = new System.Drawing.Point(509, 233);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(75, 23);
            this.buttonModifier.TabIndex = 17;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = false;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonSupprimer.FlatAppearance.BorderSize = 0;
            this.buttonSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimer.ForeColor = System.Drawing.Color.White;
            this.buttonSupprimer.Location = new System.Drawing.Point(684, 233);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(75, 23);
            this.buttonSupprimer.TabIndex = 18;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonReinitialiser
            // 
            this.buttonReinitialiser.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonReinitialiser.FlatAppearance.BorderSize = 0;
            this.buttonReinitialiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReinitialiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReinitialiser.ForeColor = System.Drawing.Color.White;
            this.buttonReinitialiser.Location = new System.Drawing.Point(835, 233);
            this.buttonReinitialiser.Name = "buttonReinitialiser";
            this.buttonReinitialiser.Size = new System.Drawing.Size(82, 23);
            this.buttonReinitialiser.TabIndex = 19;
            this.buttonReinitialiser.Text = "Réinitialiser";
            this.buttonReinitialiser.UseVisualStyleBackColor = false;
            this.buttonReinitialiser.Click += new System.EventHandler(this.buttonReinitialiser_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(113, 298);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(865, 212);
            this.dataGridView.TabIndex = 20;
            // 
            // buttonAfficher
            // 
            this.buttonAfficher.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonAfficher.FlatAppearance.BorderSize = 0;
            this.buttonAfficher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAfficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAfficher.ForeColor = System.Drawing.Color.White;
            this.buttonAfficher.Location = new System.Drawing.Point(346, 233);
            this.buttonAfficher.Name = "buttonAfficher";
            this.buttonAfficher.Size = new System.Drawing.Size(75, 23);
            this.buttonAfficher.TabIndex = 21;
            this.buttonAfficher.Text = "Afficher";
            this.buttonAfficher.UseVisualStyleBackColor = false;
            this.buttonAfficher.Click += new System.EventHandler(this.buttonAfficher_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.buttonAfficher);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonReinitialiser);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.buttonRechercher);
            this.Controls.Add(this.textBoxRechercher);
            this.Controls.Add(this.comboBoxNationalite);
            this.Controls.Add(this.labelNationalite);
            this.Controls.Add(this.groupBoxSexe);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelAdresse);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.panel1);
            this.Name = "Client";
            this.Size = new System.Drawing.Size(1081, 530);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxSexe.ResumeLayout(false);
            this.groupBoxSexe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.GroupBox groupBoxSexe;
        private System.Windows.Forms.RadioButton radioButtonAutre;
        private System.Windows.Forms.RadioButton radioButtonFemme;
        private System.Windows.Forms.RadioButton radioButtonHomme;
        private System.Windows.Forms.Label labelNationalite;
        private System.Windows.Forms.ComboBox comboBoxNationalite;
        private System.Windows.Forms.TextBox textBoxRechercher;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonReinitialiser;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonAfficher;
    }
}
