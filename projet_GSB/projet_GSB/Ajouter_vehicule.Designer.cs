namespace projet_GSB
{
    partial class Ajouter_vehicule
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_dateAchat = new System.Windows.Forms.TextBox();
            this.tb_payement = new System.Windows.Forms.TextBox();
            this.tb_prix = new System.Windows.Forms.TextBox();
            this.tb_kilometrage = new System.Windows.Forms.TextBox();
            this.tb_immatriculation = new System.Windows.Forms.TextBox();
            this.tb_modele = new System.Windows.Forms.TextBox();
            this.tb_type = new System.Windows.Forms.TextBox();
            this.bt_ajouter_vehicule = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.etatVehicule = new System.Windows.Forms.Label();
            this.stockageVehicule = new System.Windows.Forms.Label();
            this.statueVehicule = new System.Windows.Forms.Label();
            this.tb_statueVehicule = new System.Windows.Forms.TextBox();
            this.tb_stockageVehicule = new System.Windows.Forms.TextBox();
            this.tb_etatVehicule = new System.Windows.Forms.TextBox();
            this.KilometreAutonomie = new System.Windows.Forms.Label();
            this.tb_kilometrageAutonomie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date Achat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 308);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "immatriculation (AA-000-AA)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prix";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prix Net ou Loyer?";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 254);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "kilometrage";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 358);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "modèle";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 409);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Types ? (électrique ou thermique)";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // tb_dateAchat
            // 
            this.tb_dateAchat.Location = new System.Drawing.Point(247, 94);
            this.tb_dateAchat.Margin = new System.Windows.Forms.Padding(4);
            this.tb_dateAchat.Name = "tb_dateAchat";
            this.tb_dateAchat.Size = new System.Drawing.Size(132, 22);
            this.tb_dateAchat.TabIndex = 7;
            this.tb_dateAchat.Text = "02/02/2020";
            // 
            // tb_payement
            // 
            this.tb_payement.Location = new System.Drawing.Point(247, 145);
            this.tb_payement.Margin = new System.Windows.Forms.Padding(4);
            this.tb_payement.Name = "tb_payement";
            this.tb_payement.Size = new System.Drawing.Size(132, 22);
            this.tb_payement.TabIndex = 8;
            this.tb_payement.Text = "Loyer";
            // 
            // tb_prix
            // 
            this.tb_prix.Location = new System.Drawing.Point(247, 194);
            this.tb_prix.Margin = new System.Windows.Forms.Padding(4);
            this.tb_prix.Name = "tb_prix";
            this.tb_prix.Size = new System.Drawing.Size(132, 22);
            this.tb_prix.TabIndex = 9;
            this.tb_prix.Text = "279";
            // 
            // tb_kilometrage
            // 
            this.tb_kilometrage.Location = new System.Drawing.Point(247, 245);
            this.tb_kilometrage.Margin = new System.Windows.Forms.Padding(4);
            this.tb_kilometrage.Name = "tb_kilometrage";
            this.tb_kilometrage.Size = new System.Drawing.Size(132, 22);
            this.tb_kilometrage.TabIndex = 10;
            this.tb_kilometrage.Text = "15000";
            // 
            // tb_immatriculation
            // 
            this.tb_immatriculation.Location = new System.Drawing.Point(247, 299);
            this.tb_immatriculation.Margin = new System.Windows.Forms.Padding(4);
            this.tb_immatriculation.Name = "tb_immatriculation";
            this.tb_immatriculation.Size = new System.Drawing.Size(132, 22);
            this.tb_immatriculation.TabIndex = 11;
            this.tb_immatriculation.Text = "45AZ55";
            // 
            // tb_modele
            // 
            this.tb_modele.Location = new System.Drawing.Point(247, 350);
            this.tb_modele.Margin = new System.Windows.Forms.Padding(4);
            this.tb_modele.Name = "tb_modele";
            this.tb_modele.Size = new System.Drawing.Size(132, 22);
            this.tb_modele.TabIndex = 12;
            this.tb_modele.Text = "CLIO";
            // 
            // tb_type
            // 
            this.tb_type.Location = new System.Drawing.Point(247, 400);
            this.tb_type.Margin = new System.Windows.Forms.Padding(4);
            this.tb_type.Name = "tb_type";
            this.tb_type.Size = new System.Drawing.Size(132, 22);
            this.tb_type.TabIndex = 13;
            this.tb_type.Text = "Thermique";
            this.tb_type.TextChanged += new System.EventHandler(this.Tb_type_TextChanged);
            // 
            // bt_ajouter_vehicule
            // 
            this.bt_ajouter_vehicule.Location = new System.Drawing.Point(441, 466);
            this.bt_ajouter_vehicule.Margin = new System.Windows.Forms.Padding(4);
            this.bt_ajouter_vehicule.Name = "bt_ajouter_vehicule";
            this.bt_ajouter_vehicule.Size = new System.Drawing.Size(100, 28);
            this.bt_ajouter_vehicule.TabIndex = 14;
            this.bt_ajouter_vehicule.Text = "Ajouter";
            this.bt_ajouter_vehicule.UseVisualStyleBackColor = true;
            this.bt_ajouter_vehicule.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(592, 466);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 15;
            this.button2.Text = "Retour";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // etatVehicule
            // 
            this.etatVehicule.AutoSize = true;
            this.etatVehicule.Location = new System.Drawing.Point(409, 97);
            this.etatVehicule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.etatVehicule.Name = "etatVehicule";
            this.etatVehicule.Size = new System.Drawing.Size(111, 17);
            this.etatVehicule.TabIndex = 16;
            this.etatVehicule.Text = "Etat du Vehicule";
            this.etatVehicule.Click += new System.EventHandler(this.Label8_Click);
            // 
            // stockageVehicule
            // 
            this.stockageVehicule.AutoSize = true;
            this.stockageVehicule.Location = new System.Drawing.Point(409, 39);
            this.stockageVehicule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stockageVehicule.Name = "stockageVehicule";
            this.stockageVehicule.Size = new System.Drawing.Size(108, 17);
            this.stockageVehicule.TabIndex = 17;
            this.stockageVehicule.Text = "Stockage (dm3)";
            this.stockageVehicule.Click += new System.EventHandler(this.Label9_Click);
            // 
            // statueVehicule
            // 
            this.statueVehicule.AutoSize = true;
            this.statueVehicule.Location = new System.Drawing.Point(171, 39);
            this.statueVehicule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statueVehicule.Name = "statueVehicule";
            this.statueVehicule.Size = new System.Drawing.Size(49, 17);
            this.statueVehicule.TabIndex = 18;
            this.statueVehicule.Text = "Statue";
            // 
            // tb_statueVehicule
            // 
            this.tb_statueVehicule.Location = new System.Drawing.Point(247, 36);
            this.tb_statueVehicule.Margin = new System.Windows.Forms.Padding(4);
            this.tb_statueVehicule.Name = "tb_statueVehicule";
            this.tb_statueVehicule.Size = new System.Drawing.Size(132, 22);
            this.tb_statueVehicule.TabIndex = 19;
            this.tb_statueVehicule.Text = "Dispo";
            // 
            // tb_stockageVehicule
            // 
            this.tb_stockageVehicule.Location = new System.Drawing.Point(549, 36);
            this.tb_stockageVehicule.Margin = new System.Windows.Forms.Padding(4);
            this.tb_stockageVehicule.Name = "tb_stockageVehicule";
            this.tb_stockageVehicule.Size = new System.Drawing.Size(132, 22);
            this.tb_stockageVehicule.TabIndex = 20;
            this.tb_stockageVehicule.Text = "500";
            // 
            // tb_etatVehicule
            // 
            this.tb_etatVehicule.Location = new System.Drawing.Point(549, 94);
            this.tb_etatVehicule.Margin = new System.Windows.Forms.Padding(4);
            this.tb_etatVehicule.Name = "tb_etatVehicule";
            this.tb_etatVehicule.Size = new System.Drawing.Size(132, 22);
            this.tb_etatVehicule.TabIndex = 21;
            this.tb_etatVehicule.Text = "Neuf";
            // 
            // KilometreAutonomie
            // 
            this.KilometreAutonomie.AutoSize = true;
            this.KilometreAutonomie.Location = new System.Drawing.Point(403, 148);
            this.KilometreAutonomie.Name = "KilometreAutonomie";
            this.KilometreAutonomie.Size = new System.Drawing.Size(138, 17);
            this.KilometreAutonomie.TabIndex = 22;
            this.KilometreAutonomie.Text = "Kilometre Autonomie";
            // 
            // tb_kilometrageAutonomie
            // 
            this.tb_kilometrageAutonomie.Location = new System.Drawing.Point(549, 145);
            this.tb_kilometrageAutonomie.Name = "tb_kilometrageAutonomie";
            this.tb_kilometrageAutonomie.Size = new System.Drawing.Size(132, 22);
            this.tb_kilometrageAutonomie.TabIndex = 23;
            this.tb_kilometrageAutonomie.Text = "1000";
            // 
            // Ajouter_vehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tb_kilometrageAutonomie);
            this.Controls.Add(this.KilometreAutonomie);
            this.Controls.Add(this.tb_etatVehicule);
            this.Controls.Add(this.tb_stockageVehicule);
            this.Controls.Add(this.tb_statueVehicule);
            this.Controls.Add(this.statueVehicule);
            this.Controls.Add(this.stockageVehicule);
            this.Controls.Add(this.etatVehicule);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bt_ajouter_vehicule);
            this.Controls.Add(this.tb_type);
            this.Controls.Add(this.tb_modele);
            this.Controls.Add(this.tb_immatriculation);
            this.Controls.Add(this.tb_kilometrage);
            this.Controls.Add(this.tb_prix);
            this.Controls.Add(this.tb_payement);
            this.Controls.Add(this.tb_dateAchat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ajouter_vehicule";
            this.Text = "Ajouter_vehicule";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ajouter_vehicule_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_dateAchat;
        private System.Windows.Forms.TextBox tb_payement;
        private System.Windows.Forms.TextBox tb_prix;
        private System.Windows.Forms.TextBox tb_kilometrage;
        private System.Windows.Forms.TextBox tb_immatriculation;
        private System.Windows.Forms.TextBox tb_modele;
        private System.Windows.Forms.TextBox tb_type;
        private System.Windows.Forms.Button bt_ajouter_vehicule;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label etatVehicule;
        private System.Windows.Forms.Label stockageVehicule;
        private System.Windows.Forms.Label statueVehicule;
        private System.Windows.Forms.TextBox tb_statueVehicule;
        private System.Windows.Forms.TextBox tb_stockageVehicule;
        private System.Windows.Forms.TextBox tb_etatVehicule;
        private System.Windows.Forms.Label KilometreAutonomie;
        private System.Windows.Forms.TextBox tb_kilometrageAutonomie;
    }
}