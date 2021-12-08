namespace Pizzeria
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
            this.comboClient = new System.Windows.Forms.ComboBox();
            this.ADD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ListePizza = new System.Windows.Forms.DataGridView();
            this.Menu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.newPizza = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ListePizza)).BeginInit();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboClient
            // 
            this.comboClient.FormattingEnabled = true;
            this.comboClient.Location = new System.Drawing.Point(134, 400);
            this.comboClient.Name = "comboClient";
            this.comboClient.Size = new System.Drawing.Size(403, 21);
            this.comboClient.TabIndex = 0;
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(465, 57);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(102, 29);
            this.ADD.TabIndex = 2;
            this.ADD.Text = "Ajouter";
            this.ADD.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Liste Pizza :";
            // 
            // ListePizza
            // 
            this.ListePizza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListePizza.Location = new System.Drawing.Point(134, 204);
            this.ListePizza.Name = "ListePizza";
            this.ListePizza.Size = new System.Drawing.Size(403, 149);
            this.ListePizza.TabIndex = 4;
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.tabPage1);
            this.Menu.Controls.Add(this.tabPage2);
            this.Menu.Controls.Add(this.tabPage3);
            this.Menu.Controls.Add(this.tabPage4);
            this.Menu.Controls.Add(this.tabPage5);
            this.Menu.Controls.Add(this.tabPage6);
            this.Menu.Controls.Add(this.tabPage7);
            this.Menu.Location = new System.Drawing.Point(0, 1);
            this.Menu.Multiline = true;
            this.Menu.Name = "Menu";
            this.Menu.SelectedIndex = 0;
            this.Menu.Size = new System.Drawing.Size(840, 16);
            this.Menu.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(832, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pizza";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(559, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Client";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(832, 0);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Commande";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(559, 0);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Fabrication";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(559, 0);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Facture";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(559, 0);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Livreur";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(559, 0);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Adresse";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Liste des pizzas";
            // 
            // newPizza
            // 
            this.newPizza.Location = new System.Drawing.Point(202, 62);
            this.newPizza.Name = "newPizza";
            this.newPizza.Size = new System.Drawing.Size(246, 20);
            this.newPizza.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ajout d\'une nouvelle pizza : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 534);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newPizza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.ListePizza);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.comboClient);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListePizza)).EndInit();
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboClient;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ListePizza;
        private System.Windows.Forms.TabControl Menu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newPizza;
        private System.Windows.Forms.Label label3;
    }
}

