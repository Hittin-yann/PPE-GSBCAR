namespace projet_GSB
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_infoStatue = new System.Windows.Forms.Label();
            this.lb_infoKilometrage = new System.Windows.Forms.Label();
            this.lb_infoStockage = new System.Windows.Forms.Label();
            this.lb_infoEtat = new System.Windows.Forms.Label();
            this.lb_infoModele = new System.Windows.Forms.Label();
            this.lb_infoPlaqueImma = new System.Windows.Forms.Label();
            this.lb_plaque_imma = new System.Windows.Forms.Label();
            this.lb_statue = new System.Windows.Forms.Label();
            this.lb_kilo = new System.Windows.Forms.Label();
            this.lb_stock = new System.Windows.Forms.Label();
            this.lb_etat = new System.Windows.Forms.Label();
            this.lb_modele = new System.Windows.Forms.Label();
            this.ajouter_vehicule = new System.Windows.Forms.Button();
            this.retirer_vehicule = new System.Windows.Forms.Button();
            this.bt_modifier_vehicule = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.ajouter_intervention = new System.Windows.Forms.Button();
            this.modifier_intervention = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(571, 15);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(489, 260);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_infoStatue);
            this.panel1.Controls.Add(this.lb_infoKilometrage);
            this.panel1.Controls.Add(this.lb_infoStockage);
            this.panel1.Controls.Add(this.lb_infoEtat);
            this.panel1.Controls.Add(this.lb_infoModele);
            this.panel1.Controls.Add(this.lb_infoPlaqueImma);
            this.panel1.Controls.Add(this.lb_plaque_imma);
            this.panel1.Controls.Add(this.lb_statue);
            this.panel1.Controls.Add(this.lb_kilo);
            this.panel1.Controls.Add(this.lb_stock);
            this.panel1.Controls.Add(this.lb_etat);
            this.panel1.Controls.Add(this.lb_modele);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 322);
            this.panel1.TabIndex = 1;
            // 
            // lb_infoStatue
            // 
            this.lb_infoStatue.AutoSize = true;
            this.lb_infoStatue.Location = new System.Drawing.Point(301, 271);
            this.lb_infoStatue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_infoStatue.Name = "lb_infoStatue";
            this.lb_infoStatue.Size = new System.Drawing.Size(58, 17);
            this.lb_infoStatue.TabIndex = 11;
            this.lb_infoStatue.Text = "Unknow";
            this.lb_infoStatue.Click += new System.EventHandler(this.Label7_Click);
            // 
            // lb_infoKilometrage
            // 
            this.lb_infoKilometrage.AutoSize = true;
            this.lb_infoKilometrage.Location = new System.Drawing.Point(301, 228);
            this.lb_infoKilometrage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_infoKilometrage.Name = "lb_infoKilometrage";
            this.lb_infoKilometrage.Size = new System.Drawing.Size(32, 17);
            this.lb_infoKilometrage.TabIndex = 10;
            this.lb_infoKilometrage.Text = "Null";
            // 
            // lb_infoStockage
            // 
            this.lb_infoStockage.AutoSize = true;
            this.lb_infoStockage.Location = new System.Drawing.Point(301, 187);
            this.lb_infoStockage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_infoStockage.Name = "lb_infoStockage";
            this.lb_infoStockage.Size = new System.Drawing.Size(32, 17);
            this.lb_infoStockage.TabIndex = 9;
            this.lb_infoStockage.Text = "Null";
            this.lb_infoStockage.Click += new System.EventHandler(this.Label5_Click);
            // 
            // lb_infoEtat
            // 
            this.lb_infoEtat.AutoSize = true;
            this.lb_infoEtat.Location = new System.Drawing.Point(301, 149);
            this.lb_infoEtat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_infoEtat.Name = "lb_infoEtat";
            this.lb_infoEtat.Size = new System.Drawing.Size(58, 17);
            this.lb_infoEtat.TabIndex = 8;
            this.lb_infoEtat.Text = "Unknow";
            // 
            // lb_infoModele
            // 
            this.lb_infoModele.AutoSize = true;
            this.lb_infoModele.Location = new System.Drawing.Point(301, 111);
            this.lb_infoModele.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_infoModele.Name = "lb_infoModele";
            this.lb_infoModele.Size = new System.Drawing.Size(58, 17);
            this.lb_infoModele.TabIndex = 7;
            this.lb_infoModele.Text = "Unknow";
            this.lb_infoModele.Click += new System.EventHandler(this.Label2_Click);
            // 
            // lb_infoPlaqueImma
            // 
            this.lb_infoPlaqueImma.AutoSize = true;
            this.lb_infoPlaqueImma.Location = new System.Drawing.Point(301, 66);
            this.lb_infoPlaqueImma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_infoPlaqueImma.Name = "lb_infoPlaqueImma";
            this.lb_infoPlaqueImma.Size = new System.Drawing.Size(78, 17);
            this.lb_infoPlaqueImma.TabIndex = 6;
            this.lb_infoPlaqueImma.Text = "AA-000-AA";
            this.lb_infoPlaqueImma.Click += new System.EventHandler(this.Label2_Click);
            // 
            // lb_plaque_imma
            // 
            this.lb_plaque_imma.AutoSize = true;
            this.lb_plaque_imma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_plaque_imma.Location = new System.Drawing.Point(29, 62);
            this.lb_plaque_imma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_plaque_imma.Name = "lb_plaque_imma";
            this.lb_plaque_imma.Size = new System.Drawing.Size(233, 23);
            this.lb_plaque_imma.TabIndex = 4;
            this.lb_plaque_imma.Text = "Plaque d\'immatriculation :";
            // 
            // lb_statue
            // 
            this.lb_statue.AutoSize = true;
            this.lb_statue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_statue.Location = new System.Drawing.Point(196, 266);
            this.lb_statue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_statue.Name = "lb_statue";
            this.lb_statue.Size = new System.Drawing.Size(79, 23);
            this.lb_statue.TabIndex = 2;
            this.lb_statue.Text = "Statue :";
            // 
            // lb_kilo
            // 
            this.lb_kilo.AutoSize = true;
            this.lb_kilo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_kilo.Location = new System.Drawing.Point(143, 223);
            this.lb_kilo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_kilo.Name = "lb_kilo";
            this.lb_kilo.Size = new System.Drawing.Size(127, 23);
            this.lb_kilo.TabIndex = 2;
            this.lb_kilo.Text = "Kilométrage :";
            // 
            // lb_stock
            // 
            this.lb_stock.AutoSize = true;
            this.lb_stock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_stock.Location = new System.Drawing.Point(167, 182);
            this.lb_stock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_stock.Name = "lb_stock";
            this.lb_stock.Size = new System.Drawing.Size(105, 23);
            this.lb_stock.TabIndex = 2;
            this.lb_stock.Text = "Stockage :";
            // 
            // lb_etat
            // 
            this.lb_etat.AutoSize = true;
            this.lb_etat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_etat.Location = new System.Drawing.Point(219, 144);
            this.lb_etat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_etat.Name = "lb_etat";
            this.lb_etat.Size = new System.Drawing.Size(58, 23);
            this.lb_etat.TabIndex = 1;
            this.lb_etat.Text = "Etat :";
            // 
            // lb_modele
            // 
            this.lb_modele.AutoSize = true;
            this.lb_modele.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_modele.Location = new System.Drawing.Point(187, 106);
            this.lb_modele.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_modele.Name = "lb_modele";
            this.lb_modele.Size = new System.Drawing.Size(86, 23);
            this.lb_modele.TabIndex = 0;
            this.lb_modele.Text = "modele :";
            this.lb_modele.Click += new System.EventHandler(this.Lb_modele_Click);
            // 
            // ajouter_vehicule
            // 
            this.ajouter_vehicule.Location = new System.Drawing.Point(97, 375);
            this.ajouter_vehicule.Margin = new System.Windows.Forms.Padding(4);
            this.ajouter_vehicule.Name = "ajouter_vehicule";
            this.ajouter_vehicule.Size = new System.Drawing.Size(143, 28);
            this.ajouter_vehicule.TabIndex = 2;
            this.ajouter_vehicule.Text = "Ajouter un véhicule";
            this.ajouter_vehicule.UseVisualStyleBackColor = true;
            this.ajouter_vehicule.Click += new System.EventHandler(this.Ajouter_vehicule_Click);
            // 
            // retirer_vehicule
            // 
            this.retirer_vehicule.Location = new System.Drawing.Point(97, 429);
            this.retirer_vehicule.Margin = new System.Windows.Forms.Padding(4);
            this.retirer_vehicule.Name = "retirer_vehicule";
            this.retirer_vehicule.Size = new System.Drawing.Size(143, 28);
            this.retirer_vehicule.TabIndex = 3;
            this.retirer_vehicule.Text = "Retirer un véhicule";
            this.retirer_vehicule.UseVisualStyleBackColor = true;
            this.retirer_vehicule.Click += new System.EventHandler(this.Retirer_vehicule_Click);
            // 
            // bt_modifier_vehicule
            // 
            this.bt_modifier_vehicule.Location = new System.Drawing.Point(97, 485);
            this.bt_modifier_vehicule.Name = "bt_modifier_vehicule";
            this.bt_modifier_vehicule.Size = new System.Drawing.Size(141, 28);
            this.bt_modifier_vehicule.TabIndex = 4;
            this.bt_modifier_vehicule.Text = "Modifer un véhicle";
            this.bt_modifier_vehicule.UseVisualStyleBackColor = true;
            this.bt_modifier_vehicule.Click += new System.EventHandler(this.bt_modifier_vehicule_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(571, 286);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(489, 260);
            this.listBox2.TabIndex = 5;
            // 
            // ajouter_intervention
            // 
            this.ajouter_intervention.Location = new System.Drawing.Point(311, 375);
            this.ajouter_intervention.Name = "ajouter_intervention";
            this.ajouter_intervention.Size = new System.Drawing.Size(198, 28);
            this.ajouter_intervention.TabIndex = 6;
            this.ajouter_intervention.Text = "Ajouter une intervention";
            this.ajouter_intervention.UseVisualStyleBackColor = true;
            this.ajouter_intervention.Click += new System.EventHandler(this.ajouter_intervention_Click);
            // 
            // modifier_intervention
            // 
            this.modifier_intervention.Location = new System.Drawing.Point(311, 429);
            this.modifier_intervention.Name = "modifier_intervention";
            this.modifier_intervention.Size = new System.Drawing.Size(198, 28);
            this.modifier_intervention.TabIndex = 7;
            this.modifier_intervention.Text = "Modifier une intervention";
            this.modifier_intervention.UseVisualStyleBackColor = true;
            this.modifier_intervention.Click += new System.EventHandler(this.modifier_intervention_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 573);
            this.Controls.Add(this.modifier_intervention);
            this.Controls.Add(this.ajouter_intervention);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.bt_modifier_vehicule);
            this.Controls.Add(this.retirer_vehicule);
            this.Controls.Add(this.ajouter_vehicule);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_stock;
        private System.Windows.Forms.Label lb_etat;
        private System.Windows.Forms.Label lb_modele;
        private System.Windows.Forms.Label lb_kilo;
        private System.Windows.Forms.Label lb_plaque_imma;
        private System.Windows.Forms.Label lb_statue;
        private System.Windows.Forms.Button ajouter_vehicule;
        private System.Windows.Forms.Button retirer_vehicule;
        private System.Windows.Forms.Label lb_infoStatue;
        private System.Windows.Forms.Label lb_infoKilometrage;
        private System.Windows.Forms.Label lb_infoStockage;
        private System.Windows.Forms.Label lb_infoEtat;
        private System.Windows.Forms.Label lb_infoModele;
        private System.Windows.Forms.Label lb_infoPlaqueImma;
        private System.Windows.Forms.Button bt_modifier_vehicule;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button ajouter_intervention;
        private System.Windows.Forms.Button modifier_intervention;
    }
}

