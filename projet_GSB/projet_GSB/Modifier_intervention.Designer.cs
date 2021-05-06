namespace projet_GSB
{
    partial class Modifier_intervention
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tb_immatriculation = new System.Windows.Forms.TextBox();
            this.tb_dateEntrer = new System.Windows.Forms.TextBox();
            this.tb_dateSortie = new System.Windows.Forms.TextBox();
            this.tb_typeFrais = new System.Windows.Forms.TextBox();
            this.tb_coutFrais = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_validation = new System.Windows.Forms.TextBox();
            this.bt_valider = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(28, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(419, 276);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tb_immatriculation
            // 
            this.tb_immatriculation.Location = new System.Drawing.Point(50, 328);
            this.tb_immatriculation.Name = "tb_immatriculation";
            this.tb_immatriculation.Size = new System.Drawing.Size(100, 22);
            this.tb_immatriculation.TabIndex = 1;
            // 
            // tb_dateEntrer
            // 
            this.tb_dateEntrer.Location = new System.Drawing.Point(50, 374);
            this.tb_dateEntrer.Name = "tb_dateEntrer";
            this.tb_dateEntrer.Size = new System.Drawing.Size(100, 22);
            this.tb_dateEntrer.TabIndex = 2;
            // 
            // tb_dateSortie
            // 
            this.tb_dateSortie.Location = new System.Drawing.Point(50, 421);
            this.tb_dateSortie.Name = "tb_dateSortie";
            this.tb_dateSortie.Size = new System.Drawing.Size(100, 22);
            this.tb_dateSortie.TabIndex = 3;
            // 
            // tb_typeFrais
            // 
            this.tb_typeFrais.Location = new System.Drawing.Point(50, 466);
            this.tb_typeFrais.Name = "tb_typeFrais";
            this.tb_typeFrais.Size = new System.Drawing.Size(100, 22);
            this.tb_typeFrais.TabIndex = 4;
            // 
            // tb_coutFrais
            // 
            this.tb_coutFrais.Location = new System.Drawing.Point(50, 514);
            this.tb_coutFrais.Name = "tb_coutFrais";
            this.tb_coutFrais.Size = new System.Drawing.Size(100, 22);
            this.tb_coutFrais.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Modifier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 493);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 43);
            this.button2.TabIndex = 7;
            this.button2.Text = "Retour";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Immatricule :";
            // 
            // tb_validation
            // 
            this.tb_validation.Location = new System.Drawing.Point(638, 90);
            this.tb_validation.Name = "tb_validation";
            this.tb_validation.Size = new System.Drawing.Size(100, 22);
            this.tb_validation.TabIndex = 9;
            // 
            // bt_valider
            // 
            this.bt_valider.Location = new System.Drawing.Point(577, 158);
            this.bt_valider.Name = "bt_valider";
            this.bt_valider.Size = new System.Drawing.Size(98, 32);
            this.bt_valider.TabIndex = 10;
            this.bt_valider.Text = "Valider";
            this.bt_valider.UseVisualStyleBackColor = true;
            this.bt_valider.Click += new System.EventHandler(this.bt_valider_Click);
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(220, 328);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 22);
            this.tb_id.TabIndex = 11;
            // 
            // Modifier_intervention
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 573);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.bt_valider);
            this.Controls.Add(this.tb_validation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_coutFrais);
            this.Controls.Add(this.tb_typeFrais);
            this.Controls.Add(this.tb_dateSortie);
            this.Controls.Add(this.tb_dateEntrer);
            this.Controls.Add(this.tb_immatriculation);
            this.Controls.Add(this.listBox1);
            this.Name = "Modifier_intervention";
            this.Text = "Modifier_intervention";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Modifier_intervention_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tb_immatriculation;
        private System.Windows.Forms.TextBox tb_dateEntrer;
        private System.Windows.Forms.TextBox tb_dateSortie;
        private System.Windows.Forms.TextBox tb_typeFrais;
        private System.Windows.Forms.TextBox tb_coutFrais;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_validation;
        private System.Windows.Forms.Button bt_valider;
        private System.Windows.Forms.TextBox tb_id;
    }
}