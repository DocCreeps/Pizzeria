﻿namespace Pizzeria
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
            this.nameClient = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.listeClient = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.addClient = new System.Windows.Forms.Button();
            this.prenomClient = new System.Windows.Forms.TextBox();
            this.adresseClient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NumClient = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listeClient)).BeginInit();
            this.SuspendLayout();
            // 
            // nameClient
            // 
            this.nameClient.Location = new System.Drawing.Point(276, 62);
            this.nameClient.Name = "nameClient";
            this.nameClient.Size = new System.Drawing.Size(218, 20);
            this.nameClient.TabIndex = 0;
            this.nameClient.TextChanged += new System.EventHandler(this.txtClient_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 88);
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
            this.addClient.Location = new System.Drawing.Point(276, 162);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(127, 36);
            this.addClient.TabIndex = 5;
            this.addClient.Text = "Ajouter client";
            this.addClient.UseVisualStyleBackColor = true;
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // prenomClient
            // 
            this.prenomClient.Location = new System.Drawing.Point(276, 88);
            this.prenomClient.Name = "prenomClient";
            this.prenomClient.Size = new System.Drawing.Size(218, 20);
            this.prenomClient.TabIndex = 6;
            // 
            // adresseClient
            // 
            this.adresseClient.Location = new System.Drawing.Point(276, 116);
            this.adresseClient.Name = "adresseClient";
            this.adresseClient.Size = new System.Drawing.Size(218, 20);
            this.adresseClient.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Prénom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "adresse";
            // 
            // NumClient
            // 
            this.NumClient.Location = new System.Drawing.Point(276, 36);
            this.NumClient.Name = "NumClient";
            this.NumClient.Size = new System.Drawing.Size(218, 20);
            this.NumClient.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Numéro client";
            // 
            // ucClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NumClient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adresseClient);
            this.Controls.Add(this.prenomClient);
            this.Controls.Add(this.addClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listeClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameClient);
            this.Name = "ucClient";
            this.Size = new System.Drawing.Size(764, 496);
            this.Load += new System.EventHandler(this.ucClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listeClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameClient;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listeClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addClient;
        private System.Windows.Forms.TextBox prenomClient;
        private System.Windows.Forms.TextBox adresseClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NumClient;
        private System.Windows.Forms.Label label6;
    }
}
