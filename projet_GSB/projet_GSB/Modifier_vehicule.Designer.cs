namespace projet_GSB
{
    partial class Modifier_vehicule
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_modifVehicule = new System.Windows.Forms.Button();
            this.tb_modifEtat = new System.Windows.Forms.TextBox();
            this.tb_modifStockage = new System.Windows.Forms.TextBox();
            this.tb_modifStatue = new System.Windows.Forms.TextBox();
            this.modifStatueVehicule = new System.Windows.Forms.Label();
            this.modifStockageVehicule = new System.Windows.Forms.Label();
            this.modifEtatVehicule = new System.Windows.Forms.Label();
            this.tb_modifType = new System.Windows.Forms.TextBox();
            this.tb_modifModele = new System.Windows.Forms.TextBox();
            this.tb_modifImma = new System.Windows.Forms.TextBox();
            this.tb_modifKilometrage = new System.Windows.Forms.TextBox();
            this.tb_modifPrix = new System.Windows.Forms.TextBox();
            this.tb_modifPayement = new System.Windows.Forms.TextBox();
            this.tb_modifDate = new System.Windows.Forms.TextBox();
            this.modifTypeVehicule = new System.Windows.Forms.Label();
            this.modifModeleVehicule = new System.Windows.Forms.Label();
            this.modifKilometrageVehicule = new System.Windows.Forms.Label();
            this.modifPrixTypeVehicule = new System.Windows.Forms.Label();
            this.modifPrixVehicule = new System.Windows.Forms.Label();
            this.modifImmaVehicule = new System.Windows.Forms.Label();
            this.modifDateVehicule = new System.Windows.Forms.Label();
            this.tbModifImma = new System.Windows.Forms.TextBox();
            this.bt_affichage_modifVehicule = new System.Windows.Forms.Button();
            this.bt_modifRetour = new System.Windows.Forms.Button();
            this.modifKiloAutonomieVehicule = new System.Windows.Forms.Label();
            this.tb_modifKiloAutonomie = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Immatricule :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_modifKiloAutonomie);
            this.panel1.Controls.Add(this.modifKiloAutonomieVehicule);
            this.panel1.Controls.Add(this.bt_modifVehicule);
            this.panel1.Controls.Add(this.tb_modifEtat);
            this.panel1.Controls.Add(this.tb_modifStockage);
            this.panel1.Controls.Add(this.tb_modifStatue);
            this.panel1.Controls.Add(this.modifStatueVehicule);
            this.panel1.Controls.Add(this.modifStockageVehicule);
            this.panel1.Controls.Add(this.modifEtatVehicule);
            this.panel1.Controls.Add(this.tb_modifType);
            this.panel1.Controls.Add(this.tb_modifModele);
            this.panel1.Controls.Add(this.tb_modifImma);
            this.panel1.Controls.Add(this.tb_modifKilometrage);
            this.panel1.Controls.Add(this.tb_modifPrix);
            this.panel1.Controls.Add(this.tb_modifPayement);
            this.panel1.Controls.Add(this.tb_modifDate);
            this.panel1.Controls.Add(this.modifTypeVehicule);
            this.panel1.Controls.Add(this.modifModeleVehicule);
            this.panel1.Controls.Add(this.modifKilometrageVehicule);
            this.panel1.Controls.Add(this.modifPrixTypeVehicule);
            this.panel1.Controls.Add(this.modifPrixVehicule);
            this.panel1.Controls.Add(this.modifImmaVehicule);
            this.panel1.Controls.Add(this.modifDateVehicule);
            this.panel1.Location = new System.Drawing.Point(378, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 523);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // bt_modifVehicule
            // 
            this.bt_modifVehicule.Location = new System.Drawing.Point(602, 225);
            this.bt_modifVehicule.Name = "bt_modifVehicule";
            this.bt_modifVehicule.Size = new System.Drawing.Size(77, 32);
            this.bt_modifVehicule.TabIndex = 42;
            this.bt_modifVehicule.Text = "Modifier";
            this.bt_modifVehicule.UseVisualStyleBackColor = true;
            this.bt_modifVehicule.Click += new System.EventHandler(this.bt_modifVehicule_Click);
            // 
            // tb_modifEtat
            // 
            this.tb_modifEtat.Location = new System.Drawing.Point(654, 124);
            this.tb_modifEtat.Margin = new System.Windows.Forms.Padding(4);
            this.tb_modifEtat.Name = "tb_modifEtat";
            this.tb_modifEtat.Size = new System.Drawing.Size(132, 22);
            this.tb_modifEtat.TabIndex = 41;
            // 
            // tb_modifStockage
            // 
            this.tb_modifStockage.Location = new System.Drawing.Point(654, 66);
            this.tb_modifStockage.Margin = new System.Windows.Forms.Padding(4);
            this.tb_modifStockage.Name = "tb_modifStockage";
            this.tb_modifStockage.Size = new System.Drawing.Size(132, 22);
            this.tb_modifStockage.TabIndex = 40;
            // 
            // tb_modifStatue
            // 
            this.tb_modifStatue.Location = new System.Drawing.Point(328, 66);
            this.tb_modifStatue.Margin = new System.Windows.Forms.Padding(4);
            this.tb_modifStatue.Name = "tb_modifStatue";
            this.tb_modifStatue.Size = new System.Drawing.Size(132, 22);
            this.tb_modifStatue.TabIndex = 39;
            // 
            // modifStatueVehicule
            // 
            this.modifStatueVehicule.AutoSize = true;
            this.modifStatueVehicule.Location = new System.Drawing.Point(252, 69);
            this.modifStatueVehicule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modifStatueVehicule.Name = "modifStatueVehicule";
            this.modifStatueVehicule.Size = new System.Drawing.Size(49, 17);
            this.modifStatueVehicule.TabIndex = 38;
            this.modifStatueVehicule.Text = "Statue";
            // 
            // modifStockageVehicule
            // 
            this.modifStockageVehicule.AutoSize = true;
            this.modifStockageVehicule.Location = new System.Drawing.Point(490, 69);
            this.modifStockageVehicule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modifStockageVehicule.Name = "modifStockageVehicule";
            this.modifStockageVehicule.Size = new System.Drawing.Size(108, 17);
            this.modifStockageVehicule.TabIndex = 37;
            this.modifStockageVehicule.Text = "Stockage (dm3)";
            // 
            // modifEtatVehicule
            // 
            this.modifEtatVehicule.AutoSize = true;
            this.modifEtatVehicule.Location = new System.Drawing.Point(490, 127);
            this.modifEtatVehicule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modifEtatVehicule.Name = "modifEtatVehicule";
            this.modifEtatVehicule.Size = new System.Drawing.Size(111, 17);
            this.modifEtatVehicule.TabIndex = 36;
            this.modifEtatVehicule.Text = "Etat du Vehicule";
            // 
            // tb_modifType
            // 
            this.tb_modifType.Location = new System.Drawing.Point(328, 430);
            this.tb_modifType.Margin = new System.Windows.Forms.Padding(4);
            this.tb_modifType.Name = "tb_modifType";
            this.tb_modifType.Size = new System.Drawing.Size(132, 22);
            this.tb_modifType.TabIndex = 35;
            // 
            // tb_modifModele
            // 
            this.tb_modifModele.Location = new System.Drawing.Point(328, 380);
            this.tb_modifModele.Margin = new System.Windows.Forms.Padding(4);
            this.tb_modifModele.Name = "tb_modifModele";
            this.tb_modifModele.Size = new System.Drawing.Size(132, 22);
            this.tb_modifModele.TabIndex = 34;
            // 
            // tb_modifImma
            // 
            this.tb_modifImma.Location = new System.Drawing.Point(328, 329);
            this.tb_modifImma.Margin = new System.Windows.Forms.Padding(4);
            this.tb_modifImma.Name = "tb_modifImma";
            this.tb_modifImma.Size = new System.Drawing.Size(132, 22);
            this.tb_modifImma.TabIndex = 33;
            // 
            // tb_modifKilometrage
            // 
            this.tb_modifKilometrage.Location = new System.Drawing.Point(328, 275);
            this.tb_modifKilometrage.Margin = new System.Windows.Forms.Padding(4);
            this.tb_modifKilometrage.Name = "tb_modifKilometrage";
            this.tb_modifKilometrage.Size = new System.Drawing.Size(132, 22);
            this.tb_modifKilometrage.TabIndex = 32;
            // 
            // tb_modifPrix
            // 
            this.tb_modifPrix.Location = new System.Drawing.Point(328, 224);
            this.tb_modifPrix.Margin = new System.Windows.Forms.Padding(4);
            this.tb_modifPrix.Name = "tb_modifPrix";
            this.tb_modifPrix.Size = new System.Drawing.Size(132, 22);
            this.tb_modifPrix.TabIndex = 31;
            // 
            // tb_modifPayement
            // 
            this.tb_modifPayement.Location = new System.Drawing.Point(328, 175);
            this.tb_modifPayement.Margin = new System.Windows.Forms.Padding(4);
            this.tb_modifPayement.Name = "tb_modifPayement";
            this.tb_modifPayement.Size = new System.Drawing.Size(132, 22);
            this.tb_modifPayement.TabIndex = 30;
            // 
            // tb_modifDate
            // 
            this.tb_modifDate.Location = new System.Drawing.Point(328, 124);
            this.tb_modifDate.Margin = new System.Windows.Forms.Padding(4);
            this.tb_modifDate.Name = "tb_modifDate";
            this.tb_modifDate.Size = new System.Drawing.Size(132, 22);
            this.tb_modifDate.TabIndex = 29;
            // 
            // modifTypeVehicule
            // 
            this.modifTypeVehicule.AutoSize = true;
            this.modifTypeVehicule.Location = new System.Drawing.Point(82, 439);
            this.modifTypeVehicule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modifTypeVehicule.Name = "modifTypeVehicule";
            this.modifTypeVehicule.Size = new System.Drawing.Size(222, 17);
            this.modifTypeVehicule.TabIndex = 28;
            this.modifTypeVehicule.Text = "Types ? (électrique ou thermique)";
            // 
            // modifModeleVehicule
            // 
            this.modifModeleVehicule.AutoSize = true;
            this.modifModeleVehicule.Location = new System.Drawing.Point(248, 388);
            this.modifModeleVehicule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modifModeleVehicule.Name = "modifModeleVehicule";
            this.modifModeleVehicule.Size = new System.Drawing.Size(54, 17);
            this.modifModeleVehicule.TabIndex = 27;
            this.modifModeleVehicule.Text = "modèle";
            // 
            // modifKilometrageVehicule
            // 
            this.modifKilometrageVehicule.AutoSize = true;
            this.modifKilometrageVehicule.Location = new System.Drawing.Point(220, 284);
            this.modifKilometrageVehicule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modifKilometrageVehicule.Name = "modifKilometrageVehicule";
            this.modifKilometrageVehicule.Size = new System.Drawing.Size(81, 17);
            this.modifKilometrageVehicule.TabIndex = 26;
            this.modifKilometrageVehicule.Text = "kilometrage";
            // 
            // modifPrixTypeVehicule
            // 
            this.modifPrixTypeVehicule.AutoSize = true;
            this.modifPrixTypeVehicule.Location = new System.Drawing.Point(177, 184);
            this.modifPrixTypeVehicule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modifPrixTypeVehicule.Name = "modifPrixTypeVehicule";
            this.modifPrixTypeVehicule.Size = new System.Drawing.Size(125, 17);
            this.modifPrixTypeVehicule.TabIndex = 25;
            this.modifPrixTypeVehicule.Text = "Prix Net ou Loyer?";
            // 
            // modifPrixVehicule
            // 
            this.modifPrixVehicule.AutoSize = true;
            this.modifPrixVehicule.Location = new System.Drawing.Point(269, 233);
            this.modifPrixVehicule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modifPrixVehicule.Name = "modifPrixVehicule";
            this.modifPrixVehicule.Size = new System.Drawing.Size(31, 17);
            this.modifPrixVehicule.TabIndex = 24;
            this.modifPrixVehicule.Text = "Prix";
            // 
            // modifImmaVehicule
            // 
            this.modifImmaVehicule.AutoSize = true;
            this.modifImmaVehicule.Location = new System.Drawing.Point(118, 338);
            this.modifImmaVehicule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modifImmaVehicule.Name = "modifImmaVehicule";
            this.modifImmaVehicule.Size = new System.Drawing.Size(186, 17);
            this.modifImmaVehicule.TabIndex = 23;
            this.modifImmaVehicule.Text = "immatriculation (AA-000-AA)";
            // 
            // modifDateVehicule
            // 
            this.modifDateVehicule.AutoSize = true;
            this.modifDateVehicule.Location = new System.Drawing.Point(220, 132);
            this.modifDateVehicule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modifDateVehicule.Name = "modifDateVehicule";
            this.modifDateVehicule.Size = new System.Drawing.Size(78, 17);
            this.modifDateVehicule.TabIndex = 22;
            this.modifDateVehicule.Text = "Date Achat";
            // 
            // tbModifImma
            // 
            this.tbModifImma.Location = new System.Drawing.Point(180, 52);
            this.tbModifImma.Name = "tbModifImma";
            this.tbModifImma.Size = new System.Drawing.Size(99, 22);
            this.tbModifImma.TabIndex = 2;
            // 
            // bt_affichage_modifVehicule
            // 
            this.bt_affichage_modifVehicule.Location = new System.Drawing.Point(135, 114);
            this.bt_affichage_modifVehicule.Name = "bt_affichage_modifVehicule";
            this.bt_affichage_modifVehicule.Size = new System.Drawing.Size(77, 32);
            this.bt_affichage_modifVehicule.TabIndex = 3;
            this.bt_affichage_modifVehicule.Text = "Valider";
            this.bt_affichage_modifVehicule.UseVisualStyleBackColor = true;
            this.bt_affichage_modifVehicule.Click += new System.EventHandler(this.bt_affichage_modifVehicule_Click);
            // 
            // bt_modifRetour
            // 
            this.bt_modifRetour.Location = new System.Drawing.Point(135, 170);
            this.bt_modifRetour.Name = "bt_modifRetour";
            this.bt_modifRetour.Size = new System.Drawing.Size(77, 32);
            this.bt_modifRetour.TabIndex = 43;
            this.bt_modifRetour.Text = "Retour";
            this.bt_modifRetour.UseVisualStyleBackColor = true;
            this.bt_modifRetour.Click += new System.EventHandler(this.bt_modifRetour_Click);
            // 
            // modifKiloAutonomieVehicule
            // 
            this.modifKiloAutonomieVehicule.AutoSize = true;
            this.modifKiloAutonomieVehicule.Location = new System.Drawing.Point(490, 178);
            this.modifKiloAutonomieVehicule.Name = "modifKiloAutonomieVehicule";
            this.modifKiloAutonomieVehicule.Size = new System.Drawing.Size(138, 17);
            this.modifKiloAutonomieVehicule.TabIndex = 43;
            this.modifKiloAutonomieVehicule.Text = "Kilometre Autonomie";
            // 
            // tb_modifKiloAutonomie
            // 
            this.tb_modifKiloAutonomie.Location = new System.Drawing.Point(654, 175);
            this.tb_modifKiloAutonomie.Name = "tb_modifKiloAutonomie";
            this.tb_modifKiloAutonomie.Size = new System.Drawing.Size(132, 22);
            this.tb_modifKiloAutonomie.TabIndex = 44;
            // 
            // Modifier_vehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 577);
            this.Controls.Add(this.bt_modifRetour);
            this.Controls.Add(this.bt_affichage_modifVehicule);
            this.Controls.Add(this.tbModifImma);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Modifier_vehicule";
            this.Text = "Modifier_vehicule";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Modifier_vehicule_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbModifImma;
        private System.Windows.Forms.Button bt_affichage_modifVehicule;
        private System.Windows.Forms.TextBox tb_modifEtat;
        private System.Windows.Forms.TextBox tb_modifStockage;
        private System.Windows.Forms.TextBox tb_modifStatue;
        private System.Windows.Forms.Label modifStatueVehicule;
        private System.Windows.Forms.Label modifStockageVehicule;
        private System.Windows.Forms.Label modifEtatVehicule;
        private System.Windows.Forms.TextBox tb_modifType;
        private System.Windows.Forms.TextBox tb_modifModele;
        private System.Windows.Forms.TextBox tb_modifImma;
        private System.Windows.Forms.TextBox tb_modifKilometrage;
        private System.Windows.Forms.TextBox tb_modifPrix;
        private System.Windows.Forms.TextBox tb_modifPayement;
        private System.Windows.Forms.TextBox tb_modifDate;
        private System.Windows.Forms.Label modifTypeVehicule;
        private System.Windows.Forms.Label modifModeleVehicule;
        private System.Windows.Forms.Label modifKilometrageVehicule;
        private System.Windows.Forms.Label modifPrixTypeVehicule;
        private System.Windows.Forms.Label modifPrixVehicule;
        private System.Windows.Forms.Label modifImmaVehicule;
        private System.Windows.Forms.Label modifDateVehicule;
        private System.Windows.Forms.Button bt_modifVehicule;
        private System.Windows.Forms.Button bt_modifRetour;
        private System.Windows.Forms.TextBox tb_modifKiloAutonomie;
        private System.Windows.Forms.Label modifKiloAutonomieVehicule;
    }
}