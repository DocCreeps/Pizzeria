using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria
{
    public partial class ucPizza : UserControl
    {
        public ucPizza()
        {
            InitializeComponent();
        }
        private void Pizza_Load(object sender, EventArgs e)
        {

            ListePizza.DataSource = db.CataloguePizza.ToList();


            List<CataloguePizza> ListC = new List<CataloguePizza>();
            ListC.AddRange(db.CataloguePizza.ToList());
            comboClient.ValueMember = "NumPizza";
            comboClient.DisplayMember = "NomPizza";
            comboClient.DataSource = ListC;
        }
        PizzeriaEntities db = new PizzeriaEntities();

        private void newPizza_TextChanged(object sender, EventArgs e)
        {

        }
        public CataloguePizza NouvPizza = new CataloguePizza();
        private void ADDPizza_Click(object sender, EventArgs e)
        {
            NouvPizza.NomPizza = newPizza.Text;
            NouvPizza.TaillePizza = taillePizza.Text;
            double prix = Convert.ToDouble(prixPizza.Text);
            NouvPizza.PrixPizza = prix;

            int verif = db.CataloguePizza.Where(vPizza => vPizza.NomPizza == NouvPizza.NomPizza).Count();
            if (verif == 0)
            {
                db.CataloguePizza.Add(NouvPizza);
                db.SaveChanges();
                MessageBox.Show("Ajout effectué avec succès");
                
            }
            else
            {
                MessageBox.Show("Cette Pizza existe déjà");
            }
        }

        private void prixPizza_TextChanged(object sender, EventArgs e)
        {

        }

        private void taillePizza_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
