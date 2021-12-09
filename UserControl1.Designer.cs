namespace Pizzeria
{
    partial class ucClient
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
            this.components = new System.ComponentModel.Container();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.listeClient = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.addClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listeClient)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(276, 62);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(287, 20);
            this.txtClient.TabIndex = 0;
            this.txtClient.TextChanged += new System.EventHandler(this.txtClient_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ajouter client : ";
            // 
            // listeClient
            // 
            this.listeClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeClient.Location = new System.Drawing.Point(170, 285);
            this.listeClient.Name = "listeClient";
            this.listeClient.Size = new System.Drawing.Size(357, 161);
            this.listeClient.TabIndex = 3;
            this.listeClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listeClient_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Liste des clients";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // addClient
            // 
            this.addClient.Location = new System.Drawing.Point(276, 142);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(127, 36);
            this.addClient.TabIndex = 5;
            this.addClient.Text = "Ajouter client";
            this.addClient.UseVisualStyleBackColor = true;
            // 
            // ucClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listeClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClient);
            this.Name = "ucClient";
            this.Size = new System.Drawing.Size(764, 496);
            this.Load += new System.EventHandler(this.ucClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listeClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listeClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addClient;
    }
}
