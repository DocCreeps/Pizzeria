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
    public partial class ucFab : UserControl
    {
        public ucFab()
        {
            InitializeComponent();
        }
        PizzeriaEntities db = new PizzeriaEntities();
        private void dataLivreur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ucFab_Load(object sender, EventArgs e)
        {
            dataLivreur.DataSource = db.LIVREUR.ToList();
        }
    }
}
