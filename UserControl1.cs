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
    public partial class ucClient : UserControl
    {
        public ucClient()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listeClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        PizzeriaEntities db = new PizzeriaEntities();
        private void ucClient_Load(object sender, EventArgs e)
        {
            listeClient.DataSource = db.CLIENT.ToList();
        }

        private void txtClient_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
