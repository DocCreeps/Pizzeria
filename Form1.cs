using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PizzeriaEntities db = new PizzeriaEntities();

        private ucPizza listePizza = new ucPizza();
        private ucClient listeClient = new ucClient();
        private ucCommande commande = new ucCommande();
        private ucFab Fabrication = new ucFab();
        private ucFacture Facture = new ucFacture();
        private ucLivreur Livreur = new ucLivreur();
        private ucLivraison Livraison = new ucLivraison();

        private void Form1_Load(object sender, EventArgs e)
        {
        

            
        }
       
        private void commandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(listePizza);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(listePizza);
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(listeClient);
        }

        private void commandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(commande);
        }

        private void fabricationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(Fabrication);
        }

        private void livreurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(Livreur);
        }

        private void livraisonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(Livraison);
        }

        private void factureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(Facture);
        }
    }
}
