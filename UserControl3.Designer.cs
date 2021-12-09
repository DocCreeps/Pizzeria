namespace Pizzeria
{
    partial class ucCommande
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
            this.choixPizza = new System.Windows.Forms.ComboBox();
            this.choixTaille = new System.Windows.Forms.ComboBox();
            this.Quantitécmd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addCommande = new System.Windows.Forms.Button();
            this.CommandeValid = new System.Windows.Forms.Button();
            this.LigneCommande = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.LigneCommande)).BeginInit();
            this.SuspendLayout();
            // 
            // choixPizza
            // 
            this.choixPizza.FormattingEnabled = true;
            this.choixPizza.Location = new System.Drawing.Point(353, 81);
            this.choixPizza.Name = "choixPizza";
            this.choixPizza.Size = new System.Drawing.Size(121, 21);
            this.choixPizza.TabIndex = 0;
            this.choixPizza.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // choixTaille
            // 
            this.choixTaille.FormattingEnabled = true;
            this.choixTaille.Location = new System.Drawing.Point(562, 82);
            this.choixTaille.Name = "choixTaille";
            this.choixTaille.Size = new System.Drawing.Size(64, 21);
            this.choixTaille.TabIndex = 1;
            // 
            // Quantitécmd
            // 
            this.Quantitécmd.Location = new System.Drawing.Point(723, 81);
            this.Quantitécmd.Name = "Quantitécmd";
            this.Quantitécmd.Size = new System.Drawing.Size(77, 20);
            this.Quantitécmd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pizza : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Taille : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(661, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantité : ";
            // 
            // addCommande
            // 
            this.addCommande.Location = new System.Drawing.Point(406, 141);
            this.addCommande.Name = "addCommande";
            this.addCommande.Size = new System.Drawing.Size(239, 34);
            this.addCommande.TabIndex = 6;
            this.addCommande.Text = "Ajouter a la commande";
            this.addCommande.UseVisualStyleBackColor = true;
            // 
            // CommandeValid
            // 
            this.CommandeValid.Location = new System.Drawing.Point(406, 476);
            this.CommandeValid.Name = "CommandeValid";
            this.CommandeValid.Size = new System.Drawing.Size(248, 57);
            this.CommandeValid.TabIndex = 7;
            this.CommandeValid.Text = "Commander";
            this.CommandeValid.UseVisualStyleBackColor = true;
            // 
            // LigneCommande
            // 
            this.LigneCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LigneCommande.Location = new System.Drawing.Point(386, 300);
            this.LigneCommande.Name = "LigneCommande";
            this.LigneCommande.Size = new System.Drawing.Size(294, 128);
            this.LigneCommande.TabIndex = 8;
            // 
            // ucCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LigneCommande);
            this.Controls.Add(this.CommandeValid);
            this.Controls.Add(this.addCommande);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Quantitécmd);
            this.Controls.Add(this.choixTaille);
            this.Controls.Add(this.choixPizza);
            this.Name = "ucCommande";
            this.Size = new System.Drawing.Size(1072, 620);
            this.Load += new System.EventHandler(this.ucCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LigneCommande)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox choixPizza;
        private System.Windows.Forms.ComboBox choixTaille;
        private System.Windows.Forms.TextBox Quantitécmd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addCommande;
        private System.Windows.Forms.Button CommandeValid;
        private System.Windows.Forms.DataGridView LigneCommande;
    }
}
