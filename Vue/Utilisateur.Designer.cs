namespace Vue
{
    partial class Utilisateur
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
            this.labelNom = new System.Windows.Forms.Label();
            this.labelMatricule = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.labelSalaire = new System.Windows.Forms.Label();
            this.labelProfil = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxMatricule = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.textBoxSalaire = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.comboBoxProfil = new System.Windows.Forms.ComboBox();
            this.groupBoxSexe = new System.Windows.Forms.GroupBox();
            this.radioButtonAutre = new System.Windows.Forms.RadioButton();
            this.radioButtonFemme = new System.Windows.Forms.RadioButton();
            this.radioButtonHomme = new System.Windows.Forms.RadioButton();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.textBoxRechercher = new System.Windows.Forms.TextBox();
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
            this.panel1.Size = new System.Drawing.Size(1083, 36);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(423, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion des utilisateurs";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelNom.Location = new System.Drawing.Point(61, 88);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(29, 13);
            this.labelNom.TabIndex = 1;
            this.labelNom.Text = "Nom";
            // 
            // labelMatricule
            // 
            this.labelMatricule.AutoSize = true;
            this.labelMatricule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelMatricule.Location = new System.Drawing.Point(61, 53);
            this.labelMatricule.Name = "labelMatricule";
            this.labelMatricule.Size = new System.Drawing.Size(50, 13);
            this.labelMatricule.TabIndex = 2;
            this.labelMatricule.Text = "Matricule";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelPrenom.Location = new System.Drawing.Point(61, 125);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(43, 13);
            this.labelPrenom.TabIndex = 3;
            this.labelPrenom.Text = "Prénom";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelAge.Location = new System.Drawing.Point(61, 160);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(26, 13);
            this.labelAge.TabIndex = 4;
            this.labelAge.Text = "Age";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelPhone.Location = new System.Drawing.Point(61, 201);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(58, 13);
            this.labelPhone.TabIndex = 5;
            this.labelPhone.Text = "Téléphone";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelEmail.Location = new System.Drawing.Point(398, 56);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "Email";
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelAdresse.Location = new System.Drawing.Point(398, 160);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(45, 13);
            this.labelAdresse.TabIndex = 8;
            this.labelAdresse.Text = "Adresse";
            // 
            // labelSalaire
            // 
            this.labelSalaire.AutoSize = true;
            this.labelSalaire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelSalaire.Location = new System.Drawing.Point(398, 124);
            this.labelSalaire.Name = "labelSalaire";
            this.labelSalaire.Size = new System.Drawing.Size(39, 13);
            this.labelSalaire.TabIndex = 9;
            this.labelSalaire.Text = "Salaire";
            // 
            // labelProfil
            // 
            this.labelProfil.AutoSize = true;
            this.labelProfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelProfil.Location = new System.Drawing.Point(398, 88);
            this.labelProfil.Name = "labelProfil";
            this.labelProfil.Size = new System.Drawing.Size(30, 13);
            this.labelProfil.TabIndex = 10;
            this.labelProfil.Text = "Profil";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelUsername.Location = new System.Drawing.Point(398, 201);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(84, 13);
            this.labelUsername.TabIndex = 11;
            this.labelUsername.Text = "Nom d\'utilisateur";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelPassword.Location = new System.Drawing.Point(738, 57);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(71, 13);
            this.labelPassword.TabIndex = 12;
            this.labelPassword.Text = "Mot de passe";
            // 
            // textBoxMatricule
            // 
            this.textBoxMatricule.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxMatricule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMatricule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxMatricule.Location = new System.Drawing.Point(149, 46);
            this.textBoxMatricule.Name = "textBoxMatricule";
            this.textBoxMatricule.Size = new System.Drawing.Size(182, 20);
            this.textBoxMatricule.TabIndex = 13;
            // 
            // textBoxNom
            // 
            this.textBoxNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxNom.Location = new System.Drawing.Point(149, 81);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(182, 20);
            this.textBoxNom.TabIndex = 14;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxPrenom.Location = new System.Drawing.Point(149, 117);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(182, 20);
            this.textBoxPrenom.TabIndex = 15;
            // 
            // textBoxAge
            // 
            this.textBoxAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxAge.Location = new System.Drawing.Point(149, 153);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(182, 20);
            this.textBoxAge.TabIndex = 16;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxPhone.Location = new System.Drawing.Point(149, 194);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(182, 20);
            this.textBoxPhone.TabIndex = 17;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxEmail.Location = new System.Drawing.Point(495, 53);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(182, 20);
            this.textBoxEmail.TabIndex = 18;
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxAdresse.Location = new System.Drawing.Point(495, 157);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(182, 20);
            this.textBoxAdresse.TabIndex = 19;
            // 
            // textBoxSalaire
            // 
            this.textBoxSalaire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBoxSalaire.Location = new System.Drawing.Point(495, 121);
            this.textBoxSalaire.Name = "textBoxSalaire";
            this.textBoxSalaire.ReadOnly = true;
            this.textBoxSalaire.Size = new System.Drawing.Size(182, 20);
            this.textBoxSalaire.TabIndex = 20;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxUsername.Location = new System.Drawing.Point(495, 194);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(182, 20);
            this.textBoxUsername.TabIndex = 21;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxPassword.Location = new System.Drawing.Point(836, 50);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(182, 20);
            this.textBoxPassword.TabIndex = 22;
            // 
            // comboBoxProfil
            // 
            this.comboBoxProfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxProfil.Items.AddRange(new object[] {
            "Gérant",
            "Comptable",
            "Réceptioniste",
            "Serveur",
            "Veternaire"});
            this.comboBoxProfil.Location = new System.Drawing.Point(495, 85);
            this.comboBoxProfil.Name = "comboBoxProfil";
            this.comboBoxProfil.Size = new System.Drawing.Size(182, 21);
            this.comboBoxProfil.TabIndex = 0;
            this.comboBoxProfil.TextChanged += new System.EventHandler(this.comboBoxProfil_TextChanged);
            // 
            // groupBoxSexe
            // 
            this.groupBoxSexe.Controls.Add(this.radioButtonAutre);
            this.groupBoxSexe.Controls.Add(this.radioButtonFemme);
            this.groupBoxSexe.Controls.Add(this.radioButtonHomme);
            this.groupBoxSexe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBoxSexe.Location = new System.Drawing.Point(741, 86);
            this.groupBoxSexe.Name = "groupBoxSexe";
            this.groupBoxSexe.Size = new System.Drawing.Size(277, 55);
            this.groupBoxSexe.TabIndex = 23;
            this.groupBoxSexe.TabStop = false;
            this.groupBoxSexe.Text = "Sexe";
            // 
            // radioButtonAutre
            // 
            this.radioButtonAutre.AutoSize = true;
            this.radioButtonAutre.Location = new System.Drawing.Point(204, 18);
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
            this.radioButtonFemme.Location = new System.Drawing.Point(118, 19);
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
            this.radioButtonHomme.Location = new System.Drawing.Point(31, 19);
            this.radioButtonHomme.Name = "radioButtonHomme";
            this.radioButtonHomme.Size = new System.Drawing.Size(61, 17);
            this.radioButtonHomme.TabIndex = 0;
            this.radioButtonHomme.TabStop = true;
            this.radioButtonHomme.Text = "Homme";
            this.radioButtonHomme.UseVisualStyleBackColor = true;
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonRechercher.FlatAppearance.BorderSize = 0;
            this.buttonRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRechercher.ForeColor = System.Drawing.Color.White;
            this.buttonRechercher.Location = new System.Drawing.Point(843, 183);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(86, 23);
            this.buttonRechercher.TabIndex = 24;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = false;
            this.buttonRechercher.Click += new System.EventHandler(this.buttonRechercher_Click);
            // 
            // textBoxRechercher
            // 
            this.textBoxRechercher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxRechercher.Location = new System.Drawing.Point(794, 157);
            this.textBoxRechercher.Name = "textBoxRechercher";
            this.textBoxRechercher.Size = new System.Drawing.Size(177, 20);
            this.textBoxRechercher.TabIndex = 25;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonAjouter.FlatAppearance.BorderSize = 0;
            this.buttonAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouter.ForeColor = System.Drawing.Color.White;
            this.buttonAjouter.Location = new System.Drawing.Point(149, 264);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(75, 23);
            this.buttonAjouter.TabIndex = 26;
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
            this.buttonModifier.Location = new System.Drawing.Point(517, 264);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(75, 23);
            this.buttonModifier.TabIndex = 27;
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
            this.buttonSupprimer.Location = new System.Drawing.Point(709, 264);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(75, 23);
            this.buttonSupprimer.TabIndex = 28;
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
            this.buttonReinitialiser.Location = new System.Drawing.Point(878, 264);
            this.buttonReinitialiser.Name = "buttonReinitialiser";
            this.buttonReinitialiser.Size = new System.Drawing.Size(82, 23);
            this.buttonReinitialiser.TabIndex = 29;
            this.buttonReinitialiser.Text = "Réinitialiser";
            this.buttonReinitialiser.UseVisualStyleBackColor = false;
            this.buttonReinitialiser.Click += new System.EventHandler(this.buttonReinitialiser_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView.Location = new System.Drawing.Point(64, 330);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(952, 183);
            this.dataGridView.TabIndex = 30;
            // 
            // buttonAfficher
            // 
            this.buttonAfficher.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonAfficher.FlatAppearance.BorderSize = 0;
            this.buttonAfficher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAfficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAfficher.ForeColor = System.Drawing.Color.White;
            this.buttonAfficher.Location = new System.Drawing.Point(330, 264);
            this.buttonAfficher.Name = "buttonAfficher";
            this.buttonAfficher.Size = new System.Drawing.Size(75, 23);
            this.buttonAfficher.TabIndex = 31;
            this.buttonAfficher.Text = "Afficher";
            this.buttonAfficher.UseVisualStyleBackColor = false;
            this.buttonAfficher.Click += new System.EventHandler(this.buttonAfficher_Click);
            // 
            // Utilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.buttonAfficher);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonReinitialiser);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.textBoxRechercher);
            this.Controls.Add(this.buttonRechercher);
            this.Controls.Add(this.groupBoxSexe);
            this.Controls.Add(this.comboBoxProfil);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxSalaire);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.textBoxMatricule);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelProfil);
            this.Controls.Add(this.labelSalaire);
            this.Controls.Add(this.labelAdresse);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelMatricule);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.panel1);
            this.Name = "Utilisateur";
            this.Size = new System.Drawing.Size(1081, 528);
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
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelMatricule;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.Label labelSalaire;
        private System.Windows.Forms.Label labelProfil;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxMatricule;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.TextBox textBoxSalaire;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.ComboBox comboBoxProfil;
        private System.Windows.Forms.GroupBox groupBoxSexe;
        private System.Windows.Forms.RadioButton radioButtonHomme;
        private System.Windows.Forms.RadioButton radioButtonFemme;
        private System.Windows.Forms.RadioButton radioButtonAutre;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.TextBox textBoxRechercher;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonReinitialiser;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonAfficher;
    }
}
