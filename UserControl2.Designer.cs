namespace Pizzeria
{
    partial class ucPizza
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
            this.label3 = new System.Windows.Forms.Label();
            this.newPizza = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ListePizza = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ADDPizza = new System.Windows.Forms.Button();
            this.ComboPizza = new System.Windows.Forms.ComboBox();
            this.taillePizza = new System.Windows.Forms.TextBox();
            this.prixPizza = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumPizza = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label8 = new System.Windows.Forms.Label();
            this.DeletePizza = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListePizza)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ajout d\'une nouvelle pizza : ";
            // 
            // newPizza
            // 
            this.newPizza.Location = new System.Drawing.Point(573, 59);
            this.newPizza.Name = "newPizza";
            this.newPizza.Size = new System.Drawing.Size(246, 20);
            this.newPizza.TabIndex = 21;
            this.newPizza.TextChanged += new System.EventHandler(this.newPizza_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Liste des pizzas";
            // 
            // ListePizza
            // 
            this.ListePizza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListePizza.Location = new System.Drawing.Point(250, 242);
            this.ListePizza.Name = "ListePizza";
            this.ListePizza.Size = new System.Drawing.Size(403, 149);
            this.ListePizza.TabIndex = 19;
            this.ListePizza.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListePizza_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Liste Pizza :";
            // 
            // ADDPizza
            // 
            this.ADDPizza.Location = new System.Drawing.Point(391, 145);
            this.ADDPizza.Name = "ADDPizza";
            this.ADDPizza.Size = new System.Drawing.Size(102, 29);
            this.ADDPizza.TabIndex = 17;
            this.ADDPizza.Text = "Ajouter";
            this.ADDPizza.UseVisualStyleBackColor = true;
            this.ADDPizza.Click += new System.EventHandler(this.ADDPizza_Click);
            // 
            // ComboPizza
            // 
            this.ComboPizza.FormattingEnabled = true;
            this.ComboPizza.Location = new System.Drawing.Point(250, 438);
            this.ComboPizza.Name = "ComboPizza";
            this.ComboPizza.Size = new System.Drawing.Size(403, 21);
            this.ComboPizza.TabIndex = 16;
            this.ComboPizza.SelectedIndexChanged += new System.EventHandler(this.ComboPizza_SelectedIndexChanged);
            // 
            // taillePizza
            // 
            this.taillePizza.Location = new System.Drawing.Point(323, 96);
            this.taillePizza.Name = "taillePizza";
            this.taillePizza.Size = new System.Drawing.Size(130, 20);
            this.taillePizza.TabIndex = 23;
            this.taillePizza.TextChanged += new System.EventHandler(this.taillePizza_TextChanged);
            // 
            // prixPizza
            // 
            this.prixPizza.Location = new System.Drawing.Point(539, 96);
            this.prixPizza.Name = "prixPizza";
            this.prixPizza.Size = new System.Drawing.Size(130, 20);
            this.prixPizza.TabIndex = 24;
            this.prixPizza.TextChanged += new System.EventHandler(this.prixPizza_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Taile: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Prix :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(501, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Nom Pizza : ";
            // 
            // txtNumPizza
            // 
            this.txtNumPizza.Location = new System.Drawing.Point(323, 59);
            this.txtNumPizza.Name = "txtNumPizza";
            this.txtNumPizza.Size = new System.Drawing.Size(137, 20);
            this.txtNumPizza.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Numéro Pizza: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(405, 419);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Recherche Pizza:";
            // 
            // DeletePizza
            // 
            this.DeletePizza.Location = new System.Drawing.Point(359, 483);
            this.DeletePizza.Name = "DeletePizza";
            this.DeletePizza.Size = new System.Drawing.Size(160, 44);
            this.DeletePizza.TabIndex = 31;
            this.DeletePizza.Text = "Supprimer Pizza";
            this.DeletePizza.UseVisualStyleBackColor = true;
            this.DeletePizza.Click += new System.EventHandler(this.DeletePizza_Click);
            // 
            // ucPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeletePizza);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNumPizza);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prixPizza);
            this.Controls.Add(this.taillePizza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newPizza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListePizza);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ADDPizza);
            this.Controls.Add(this.ComboPizza);
            this.Name = "ucPizza";
            this.Size = new System.Drawing.Size(1004, 639);
            this.Load += new System.EventHandler(this.Pizza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListePizza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newPizza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ListePizza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ADDPizza;
        private System.Windows.Forms.ComboBox ComboPizza;
        private System.Windows.Forms.TextBox taillePizza;
        private System.Windows.Forms.TextBox prixPizza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumPizza;
        private System.Windows.Forms.Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button DeletePizza;
    }
}
