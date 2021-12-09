namespace Pizzeria
{
    partial class ucFab
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
            this.dataLivreur = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataLivreur)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLivreur
            // 
            this.dataLivreur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLivreur.Location = new System.Drawing.Point(109, 180);
            this.dataLivreur.Name = "dataLivreur";
            this.dataLivreur.Size = new System.Drawing.Size(388, 148);
            this.dataLivreur.TabIndex = 0;
            this.dataLivreur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLivreur_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des livreurs : ";
            // 
            // ucFab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataLivreur);
            this.Name = "ucFab";
            this.Size = new System.Drawing.Size(639, 386);
            this.Load += new System.EventHandler(this.ucFab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLivreur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataLivreur;
        private System.Windows.Forms.Label label1;
    }
}
