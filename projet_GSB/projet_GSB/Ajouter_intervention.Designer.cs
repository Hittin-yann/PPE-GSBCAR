namespace projet_GSB
{
    partial class Ajouter_intervention
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
            this.tb_immaInter = new System.Windows.Forms.TextBox();
            this.tbDateEntrer = new System.Windows.Forms.TextBox();
            this.tbDateSortie = new System.Windows.Forms.TextBox();
            this.tbTypeFrais = new System.Windows.Forms.TextBox();
            this.tbCoutFrais = new System.Windows.Forms.TextBox();
            this.bt_ajoute_intervention = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Immatriculation :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date d\'entré :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date sortie :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type de frais :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Coût du frais :";
            // 
            // tb_immaInter
            // 
            this.tb_immaInter.Location = new System.Drawing.Point(235, 74);
            this.tb_immaInter.Name = "tb_immaInter";
            this.tb_immaInter.Size = new System.Drawing.Size(100, 22);
            this.tb_immaInter.TabIndex = 5;
            // 
            // tbDateEntrer
            // 
            this.tbDateEntrer.Location = new System.Drawing.Point(235, 122);
            this.tbDateEntrer.Name = "tbDateEntrer";
            this.tbDateEntrer.Size = new System.Drawing.Size(100, 22);
            this.tbDateEntrer.TabIndex = 6;
            // 
            // tbDateSortie
            // 
            this.tbDateSortie.Location = new System.Drawing.Point(235, 170);
            this.tbDateSortie.Name = "tbDateSortie";
            this.tbDateSortie.Size = new System.Drawing.Size(100, 22);
            this.tbDateSortie.TabIndex = 7;
            // 
            // tbTypeFrais
            // 
            this.tbTypeFrais.Location = new System.Drawing.Point(235, 220);
            this.tbTypeFrais.Name = "tbTypeFrais";
            this.tbTypeFrais.Size = new System.Drawing.Size(100, 22);
            this.tbTypeFrais.TabIndex = 8;
            // 
            // tbCoutFrais
            // 
            this.tbCoutFrais.Location = new System.Drawing.Point(235, 265);
            this.tbCoutFrais.Name = "tbCoutFrais";
            this.tbCoutFrais.Size = new System.Drawing.Size(100, 22);
            this.tbCoutFrais.TabIndex = 9;
            // 
            // bt_ajoute_intervention
            // 
            this.bt_ajoute_intervention.Location = new System.Drawing.Point(158, 335);
            this.bt_ajoute_intervention.Name = "bt_ajoute_intervention";
            this.bt_ajoute_intervention.Size = new System.Drawing.Size(96, 37);
            this.bt_ajoute_intervention.TabIndex = 10;
            this.bt_ajoute_intervention.Text = "Ajouter";
            this.bt_ajoute_intervention.UseVisualStyleBackColor = true;
            this.bt_ajoute_intervention.Click += new System.EventHandler(this.bt_ajoute_intervention_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ajouter_intervention
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 547);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_ajoute_intervention);
            this.Controls.Add(this.tbCoutFrais);
            this.Controls.Add(this.tbTypeFrais);
            this.Controls.Add(this.tbDateSortie);
            this.Controls.Add(this.tbDateEntrer);
            this.Controls.Add(this.tb_immaInter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ajouter_intervention";
            this.Text = "Ajouter_intervention";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ajouter_intervention_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_immaInter;
        private System.Windows.Forms.TextBox tbDateEntrer;
        private System.Windows.Forms.TextBox tbDateSortie;
        private System.Windows.Forms.TextBox tbTypeFrais;
        private System.Windows.Forms.TextBox tbCoutFrais;
        private System.Windows.Forms.Button bt_ajoute_intervention;
        private System.Windows.Forms.Button button1;
    }
}