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
        PizzeriaEntities db = new PizzeriaEntities();
        private void Pizza_Load(object sender, EventArgs e)
        {

            ListePizza.DataSource = db.CataloguePizza.ToList();


            List<CataloguePizza> ListC = new List<CataloguePizza>();
            ListC.AddRange(db.CataloguePizza.ToList());
            ComboPizza.ValueMember = "NumPizza";
            ComboPizza.DisplayMember = "NomPizza";
            ComboPizza.DataSource = ListC;
        }
        

        private void newPizza_TextChanged(object sender, EventArgs e)
        {

        }
        public CataloguePizza NouvPizza = new CataloguePizza();
        private void ADDPizza_Click(object sender, EventArgs e)
        {
            int numeroPizza = Convert.ToInt32(txtNumPizza.Text);
            NouvPizza.NumPizza =numeroPizza ;
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
                txtNumPizza.Text = NouvPizza.NumPizza.ToString();
            }
            else
            {
                MessageBox.Show("Cette Pizza existe déjà");
            }
        }

        private void DeletePizza_Click(object sender, EventArgs e)
        {
            String numpizz = ComboPizza.SelectedValue.ToString();
            int Index = Convert.ToInt32(numpizz);

            var result = db.CataloguePizza.SingleOrDefault(cl => cl.NumPizza == Index);

            if (result != null)
            {

                db.CataloguePizza.Remove(result);
                db.SaveChanges();
                MessageBox.Show("Cette pizza a été supprimé ");

            }
            else
            {
                MessageBox.Show("Cette pizza n'existe pas ");

            }
        }
        private void ComboPizza_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void prixPizza_TextChanged(object sender, EventArgs e)
        {

        }

        private void taillePizza_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListePizza_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
