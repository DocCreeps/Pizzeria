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
    public partial class ucLivreur : UserControl
    {
        public ucLivreur()
        {
            InitializeComponent();
        }

        PizzeriaEntities db = new PizzeriaEntities();
        private void ucLivreur_Load(object sender, EventArgs e)
        {
            dataLivraison.DataSource = db.LIVRAISON.ToList();
        }
    }
}
